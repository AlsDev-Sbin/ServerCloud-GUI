using System;
using System.Windows.Forms;

namespace ServerCloud
{
	public partial class ViewNameFolder : Form
	{
		public string NameFolder { get; set; }
		public ViewNameFolder()
		{
			InitializeComponent();
		}

		private void BtGravar_Click(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(TxNomePasta.Text))
			{
				NameFolder = TxNomePasta.Text;
				DialogResult = DialogResult.OK;
				Close();
			} else
				MessageBox.Show("Favor preencher o campo, antes de continuar");
		}

		private void BtCancelar_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			Close();
		}

		private void ViewNameFolder_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (DialogResult == DialogResult.None)
				DialogResult = DialogResult.Cancel;
		}
	}
}
