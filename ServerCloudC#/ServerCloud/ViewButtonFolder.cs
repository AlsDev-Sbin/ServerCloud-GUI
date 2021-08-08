using ServerCloud.RemoteServerCloud.API;
using ServerCloud.RemoteServerCloud.Model.API;
using System;
using System.Linq;
using System.Windows.Forms;

namespace ServerCloud
{
	public partial class ViewButtonFolder : UserControl
	{
		public Action<int?> AbrirPasta { get; set; }
		public int? IdPath { get; private set; }

		public ViewButtonFolder(int? IdPath, Action<int?> action)
		{
			InitializeComponent();
			AbrirPasta = action;
			this.IdPath = IdPath;
		}

		public void Click(object sender, EventArgs e)
		{
			AbrirPasta(IdPath);
		}

		private async void PicExcluir_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Deseja realmente apagar a pasta selecionada?\nApós apagar, não será possível recuperar.", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
			{

				var model = new ModelDeletePath
				{
					Id = IdPath,
				};

				using var req = new RequestServer(EnumEndPoints.EndPoint.DeletePath);
				using var resp = await req.RequestServerCloud(model);

				using (var api = new APIAnonFiles())
				{
					using (var delete = api.DeleteFiles())
					{
						delete.Initialize(MainPastas.User.UserName, MainPastas.User.PSW);
						foreach (var data in resp.data)
						{
							if (data is null || data.links is null || data.links.Count == 0)
								break;

							foreach (var link in data.links)
							{
								try
								{
									await delete.DeleteFile(link.IdLink.Split('/').First());
								} catch { }
							}
						}
					}
				}

			}
		}
	}
}
