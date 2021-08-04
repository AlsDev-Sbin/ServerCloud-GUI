using ServerCloud.RemoteServerCloud.API;
using ServerCloud.RemoteServerCloud.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServerCloud
{
	public partial class MainPastas : UserControl
	{
		private ModelLoginUser User { get; set; }
		private List<ModelSelectPath> Paths { get; set; }
		private List<ModelSelectLink> Links { get; set; }
		private List<(string FileName, bool Concluded)> CurrentDownloadLinks { get; set; }
		public MainPastas(ModelLoginUser user)
		{
			Links = new();
			Paths = new();
			User = user;
			InitializeComponent();
		}

		public (string Path, int IdPath, int Parent) CurrentPath = ("", 0, 0);

		private async void ProgressBar_VisibleChanged(object sender, EventArgs e)
		{
			FlowContainerFolders.Controls.Clear();
			await ListFolders();
			AbrirPasta();

			await ListLinks();
			AbrirArquivo();
		}

		protected async void AbrirArquivo()
		{
			Links.Where(l => l.IdPath == CurrentPath.IdPath).ToList().ForEach(link =>
			{
				var panel = new ViewButtonFile(link.Id, ClickDownloadFile);
				panel.LbCaptionFile.Text = link.FileName;
				panel.LbBytes.Text = link.str_bytes;

				FlowContainerFolders.Controls.Add(panel);
			});
		}

		private async void AbrirPasta(int? IdPath = null)
		{
			if (Paths.Count > 1)
			{
				var Parent = CurrentPath.Parent;
				var PathsFilter = IdPath is null ?
					Paths.OrderBy(p => p.IdPath).ToList() :
					Paths.OrderBy(p => p.IdPath).Where(p => p.Parent == (int)IdPath || p.IdPath == (int)IdPath).ToList();

				foreach (var path in PathsFilter)
				{
					if (CurrentPath.IdPath == 0)
						CurrentPath = (path.Path, path.IdPath, IdPath is null ? Parent : path.Parent);
					else
					{
						var PathsLevel = from p in Paths where p.Parent == CurrentPath.IdPath select p;

						if (PathsLevel != null)
						{
							foreach (var pathLevel in PathsLevel)
							{
								var bt = new ViewButtonFolder(pathLevel.IdPath, ClickFolder);
								bt.LbCaptionFolder.Text = pathLevel.Path;
								FlowContainerFolders.Controls.Add(bt);
							}
							break;
						}
					}
				}
			} else
				CurrentPath = (Paths.First().Path, Paths.First().IdPath, 0);
		}

		protected async Task ListLinks()
		{
			using (var req = new RequestServer(EnumEndPoints.EndPoint.SelectLink))
			{
				var model = new ModelSelectLink
				{
					IdPath = CurrentPath.IdPath,
					IdUser = User.IdUser,
					Method = "Find/Path"
				};

				using (var resp = await req.RequestServerCloud(model))
				{
					if (resp != null && resp.InformationRequest.ValueError == 200)
					{
						Links.Clear();
						Links.AddRange(
							from link in resp.data.First().links
							select new ModelSelectLink
							{
								Id = link.Id.Value,
								FileName = link.FileName,
								bytes = link.bytes.Value,
								IdLink = link.IdLink,
								IdPath = link.IdPath.Value,
								str_bytes = link.str_bytes,
							}
						);

					}
				}
			}
		}

		protected async Task ListFolders()
		{
			using (var req = new RequestServer(EnumEndPoints.EndPoint.SelectPath))
			{
				var model = new ModelSelectPath
				{
					IdUser = User.IdUser
				};
				var resp = await req.RequestServerCloud(model);
				if (resp != null || resp.InformationRequest.ValueError == 200)
				{
					Paths.AddRange(
						from path in resp.data.First().paths
						select new ModelSelectPath
						{
							IdPath = path.Id,
							Path = path.Path,
							Parent = path.Parent
						}
					);

				}
			}
		}

		public async void ClickDownloadFile(int IdFile, Control control)
		{
			control.Visible = true;
			string PathSave = @$"{Directory.GetCurrentDirectory()}\Download";
			if (!Directory.Exists(PathSave))
				Directory.CreateDirectory(PathSave);

			var link = Links.Where(l => l.Id == IdFile).First();

			if (System.IO.File.Exists(@$"{PathSave}\{link.FileName}"))
			{
				if (MessageBox.Show("Já existe um arquivo com esse nome, deseja substituir?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
					System.IO.File.Delete(@$"{PathSave}\{link.FileName}");
				else
				{
					control.Visible = false;
					return;
				}
			}

			var api = new APIAnonFiles();
			await api.DownloadFile($"https://anonfiles.com/{link.IdLink}", @$"{PathSave}\{link.FileName}", async () =>
			{
				await Task.Delay(500);
				control.Invoke(() => control.Visible = false);
			});
		}

		public async void ClickFolder(int IdPath)
		{
			FlowContainerFolders.Controls.Clear();
			CurrentPath = ("", 0, CurrentPath.Parent);
			AbrirPasta(IdPath);
			await ListLinks();

			AbrirArquivo();
		}

		private async void BtAddFolder_Click(object sender, EventArgs e)
		{
			var viewNameFolder = new ViewNameFolder();
			if (viewNameFolder.ShowDialog() == DialogResult.OK)
			{
				var model = new ModelInsertPath()
				{
					IdUser = User.IdUser,
					Path = viewNameFolder.NameFolder,
					Parent = CurrentPath.IdPath
				};

				if (Paths.Where(p => p.Parent == model.Parent & p.Path == model.Path).Any())
				{
					MessageBox.Show("Já existe uma pasta com esse nome!");
					return;
				}

				using (var req = new RequestServer(EnumEndPoints.EndPoint.InsertPath))
				{
					using (var resp = await req.RequestServerCloud(model))
					{
						if (resp.InformationRequest.ValueError == 200)
						{

							FlowContainerFolders.Controls.Clear();
							Paths.Add(new()
							{
								IdPath = resp.data.First().id,
								Path = model.Path,
								Parent = model.Parent
							});

							AbrirPasta();

							AbrirArquivo();
						}
					}
				}
			}
		}

		private async void BtVoltar_Click(object sender, EventArgs e)
		{
			if (CurrentPath.Parent > 0)
			{
				FlowContainerFolders.Controls.Clear();
				var IdPath = CurrentPath.IdPath;
				CurrentPath.IdPath = 0;

				AbrirPasta(CurrentPath.Parent);

				await ListLinks();
				AbrirArquivo();
			}
		}

		private async void BtUpload_Click(object sender, EventArgs e)
		{
			if (CurrentDownloadLinks is null)
				CurrentDownloadLinks = new();

			var list = new List<ModelInsertLink>();

			var openFile = new OpenFileDialog()
			{
				CheckFileExists = true,
				CheckPathExists = true,
				Multiselect = true,
				RestoreDirectory = true,
				ShowHelp = true,
				Title = "Selecione seu arquivo"
			};

			if (openFile.ShowDialog() == DialogResult.OK)
			{
				var files = openFile.FileNames;

				CurrentDownloadLinks.AddRange(
					from file in files
					let f = file.Split('\\').Last()
					select (f, false)
				);

				foreach (var file in files)
				{
					var FileName = file.Split('\\').Last();

					var modelApi = new ModelAPIAnonFiles()
					{
						data = new()
						{
							file = new()
							{
								metadata = new()
								{
									name = FileName
								}
							}
						}
					};

					var api = new APIAnonFiles();
					modelApi = await api.UploadFile(modelApi, file);

					if (modelApi.status)
					{
						var modelLink = new ModelInsertLink()
						{
							bytes = modelApi.data.file.metadata.size.bytes.ToString(),
							str_bytes = modelApi.data.file.metadata.size.readable,
							FileName = FileName,
							IdPath = CurrentPath.IdPath,
							IdUser = User.IdUser,
							IdLink = $"{modelApi.data.file.metadata.id}/{FileName}"
						};
						Links.Add(new()
						{
							IdPath = modelLink.IdPath,
							bytes = Convert.ToInt32(modelLink.bytes),
							FileName = modelLink.FileName,
							IdLink = modelLink.IdLink,
							IdUser = modelLink.IdUser,
							str_bytes = modelLink.str_bytes,
						});
						using var req = new RequestServer(EnumEndPoints.EndPoint.InsertLink);
						using var resp = await req.RequestServerCloud(modelLink);

						foreach (var item in ListDownloads.Items)
							if (item == modelLink.FileName)
								ListDownloads.Items.Remove(item);
					}
				}

				FlowContainerFolders.Controls.Clear();
				AbrirPasta();

				AbrirArquivo();
			}
		}

		private void ListDownload_Click(object sender, EventArgs e)
		{
			if (PnListDownloads.Visible)
			{
				PnListDownloads.Visible = false;
				return;
			}
			if (CurrentDownloadLinks is not null)
			{
				ListDownloads.Items.Clear();
				CurrentDownloadLinks.ForEach(cdl =>
				{
					ListDownloads.Items.Add($"{(cdl.Concluded ? "✔️" : "⬆️⬆️")} {cdl.FileName}");
				});

				PnListDownloads.Visible = true;
			}
		}
		private void BtLimparListaDownload_Click(object sender, EventArgs e)
		{
			ListDownloads.Items.Clear();
		}
	}
}
