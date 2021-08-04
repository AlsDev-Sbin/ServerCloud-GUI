using System;
using System.Windows.Forms;

namespace ServerCloud
{
	public partial class ViewButtonFile : UserControl
	{
		public Action<int, Control> Download { get; set; }
		public int IdFile { get; private set; }

		public ViewButtonFile(int IdFile, Action<int, Control> action)
		{
			InitializeComponent();
			Download = action;
			this.IdFile = IdFile;
		}

		public void Click(object sender, EventArgs e)
		{
			Download(IdFile, ProgressBar);
		}
	}
}
