using ServerCloud.RemoteServerCloud.API;
using ServerCloud.RemoteServerCloud.Model;
using System;
using System.Windows.Forms;

namespace ServerCloud
{
	public partial class MainCreateAccount : UserControl
	{
		public MainCreateAccount()
		{
			InitializeComponent();

			TxCreateUser.Text = "teste_ola";
			TxCreateSenha.Text = "ola.4321";
			TxCreatePrimaryName.Text = "Teste_ola_mundo_teste";
			TxCreateSecondName.Text = "Teste_ola_mundo_teste";
		}

		private async void BtCreateAccount_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(TxCreatePrimaryName.Text))
				MessageBox.Show("Campo primeiro nome está vazio, favor preencher.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			else if (string.IsNullOrEmpty(TxCreateSecondName.Text))
				MessageBox.Show("Campo segundo nome está vazio, favor preencher.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			else if (string.IsNullOrEmpty(TxCreateUser.Text))
				MessageBox.Show("Campo Usuário está vazio, favor preencher.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			else if (string.IsNullOrEmpty(TxCreateSenha.Text))
				MessageBox.Show("Campo senha está vazio, favor preencher.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);

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
					Token = token
				};

				using var req = new RequestServer(EnumEndPoints.EndPoint.InsertUser);
				using var resp = await req.RequestServerCloud(model);
				if (resp.InformationRequest.ValueError == 200)
					MessageBox.Show("Conta criada com sucesso.", "Parabéns", MessageBoxButtons.OK, MessageBoxIcon.Information);
				else
					MessageBox.Show($"Falha ao criar a conta : {resp.InformationRequest.MessageError}");
			}
		}
	}
}
