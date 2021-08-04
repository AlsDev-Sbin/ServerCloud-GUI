using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ServerCloud.RemoteServerCloud.Model;
using ServerCloud.RemoteServerCloud.API;

namespace ServerCloud
{
	public partial class MainCreateAccount : UserControl
	{
		public MainCreateAccount()
		{
			InitializeComponent();
		}

		private async void BtCreateAccount_Click(object sender, EventArgs e)
		{
			TxCreateUser.Text = "teste_ola";
			TxCreateSenha.Text = "ola.4321";

			var api = new APIAnonFiles();
			if (await api.CreateUser(TxCreateUser.Text, TxCreateSenha.Text))
			{
				var token = await api.GetTokenUser(TxCreateUser.Text, TxCreateSenha.Text);

				var model = new ModelInsertUser()
				{
					UserName = TxCreateUser.Text,
					Pass = TxCreateSenha.Text,
					PrimaryName = TxCreatePrimaryName.Text,
					SecondName = TxCreateSecondName.Text,
					token = token
				};

				using var req = new RequestServer(EnumEndPoints.EndPoint.InsertUser);
				using var resp = await req.RequestServerCloud(model);
				if (resp.InformationRequest.ValueError == 200)
					MessageBox.Show("Conta criada com sucesso.");
				else
					MessageBox.Show($"Falha ao criar a conta : {resp.InformationRequest.MessageError}");
			}
		}
	}
}
