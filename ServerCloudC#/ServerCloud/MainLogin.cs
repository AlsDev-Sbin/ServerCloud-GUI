using ServerCloud.RemoteServerCloud.API;
using ServerCloud.RemoteServerCloud.Model;
using System;
using System.Linq;
using System.Windows.Forms;

namespace ServerCloud
{
	public partial class MainLogin : Form
	{
		protected ModelLoginUser user { get; set; }

		public MainLogin()
		{
			InitializeComponent();

			TxUsuario.Text = "teste_ola";
			TxSenha.Text = "ola.4321";
		}

		private async void BtEntrar_Click(object sender, EventArgs e)
		{
			if (TxUsuario.Text == "" & TxSenha.Text == "")
				return;

			ProgressBarLogin.PerformStep();
			var req = new RequestServer(EnumEndPoints.EndPoint.LoginUser);

			ProgressBarLogin.PerformStep();
			var modeljson = new ModelLoginUser
			{
				UserName = TxUsuario.Text,
				PSW = TxSenha.Text
			};

			ProgressBarLogin.PerformStep();
			var json = await req.RequestServerCloud(modeljson);


			ProgressBarLogin.PerformStep();
			if (json == null || json.InformationRequest.ValueError == 200)
			{
				user = modeljson;
				user.IdUser = json.data.First().user.First().Id;
				user.PrimaryName = json.data.First().user.First().PrimaryName;
				user.SecondName = json.data.First().user.First().SecondName;
				user.Token = json.data.First().user.First().Token;

				PnPastas.Controls.Add(new MainPastas(user) { Dock = DockStyle.Fill });

				ProgressBarLogin.Value = 100;

				TabMain.SelectedIndex = 2;
				return;
			}

			MessageBox.Show("Usuário ou senha incorreto.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			ProgressBarLogin.Value = 0;
		}
		private void LinkCriarConta_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			PnCreateAccount.Controls.Add(new MainCreateAccount() { Dock = DockStyle.Fill });
			TabMain.SelectedIndex = 1;
		}

		private void BtVoltar_Click(object sender, EventArgs e)
		{
			user = new();
			TabMain.SelectedIndex = 0;
			ProgressBarLogin.Value = 0;
			PnPastas.Controls[0].Dispose();
		}
		private void BtVoltar2_Click(object sender, EventArgs e)
		{
			ProgressBarLogin.Value = 0;
			TabMain.SelectedIndex = 0;
			PnCreateAccount.Controls[0].Dispose();
		}
	}
}
