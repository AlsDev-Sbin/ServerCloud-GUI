using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ServerCloud.RemoteServerCloud.API;
using ServerCloud.RemoteServerCloud.Model;

namespace ServerCloud
{
	public partial class MainPastas : UserControl
	{
		private ModelLoginUser User { get; set; }
		private List<ModelSelectPath> Paths { get; set; }
		public MainPastas(ModelLoginUser user)
		{
			Paths = new();
			User = user;
			InitializeComponent();
		}

		public (string Path, int IdPath) CurrentPath = ("root", 0);

		private async void ProgressBar_VisibleChanged(object sender, EventArgs e)
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
							Path = path.Path
						}
					);
					if (Paths.Count > 1)
					{
						Paths.ForEach(path =>
						{
							var panel = new ViewButtonFolder(path.IdPath, ClickFolder);
							panel.LbCaptionFolder.Text = path.Path;
							FlowContainerFolders.Controls.Add(panel);
						});

						CurrentPath = (Paths.First().Path.Split('\\').First(), Paths.First().IdPath);
					} else
						CurrentPath = (Paths.First().Path, Paths.First().IdPath);
				}
			}

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

				}
			}
		}

		public void ClickFolder(int IdPath)
		{

		}
	}
}
