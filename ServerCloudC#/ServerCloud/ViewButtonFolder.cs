using System;
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

		private void PicExcluir_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Deseja realmente apagar a pasta selecionada?\nApós apagar, não será possível recuperar.", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
			{

				//var model = 

			}
		}
	}
}
