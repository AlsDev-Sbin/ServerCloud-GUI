
namespace ServerCloud
{
	partial class ViewNameFolder
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.TxNomePasta = new System.Windows.Forms.TextBox();
			this.LbTitulo = new System.Windows.Forms.Label();
			this.BtCancelar = new System.Windows.Forms.Button();
			this.BtGravar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// TxNomePasta
			// 
			this.TxNomePasta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.TxNomePasta.Location = new System.Drawing.Point(12, 48);
			this.TxNomePasta.Name = "TxNomePasta";
			this.TxNomePasta.Size = new System.Drawing.Size(454, 37);
			this.TxNomePasta.TabIndex = 0;
			// 
			// LbTitulo
			// 
			this.LbTitulo.Dock = System.Windows.Forms.DockStyle.Top;
			this.LbTitulo.Location = new System.Drawing.Point(0, 0);
			this.LbTitulo.Name = "LbTitulo";
			this.LbTitulo.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
			this.LbTitulo.Size = new System.Drawing.Size(478, 45);
			this.LbTitulo.TabIndex = 1;
			this.LbTitulo.Text = "Nome da nova pasta";
			this.LbTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// BtCancelar
			// 
			this.BtCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.BtCancelar.Location = new System.Drawing.Point(241, 93);
			this.BtCancelar.Name = "BtCancelar";
			this.BtCancelar.Size = new System.Drawing.Size(225, 36);
			this.BtCancelar.TabIndex = 2;
			this.BtCancelar.Text = "Cancelar";
			this.BtCancelar.UseVisualStyleBackColor = true;
			this.BtCancelar.Click += new System.EventHandler(this.BtCancelar_Click);
			// 
			// BtGravar
			// 
			this.BtGravar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.BtGravar.Location = new System.Drawing.Point(12, 93);
			this.BtGravar.Name = "BtGravar";
			this.BtGravar.Size = new System.Drawing.Size(225, 36);
			this.BtGravar.TabIndex = 1;
			this.BtGravar.Text = "Gravar";
			this.BtGravar.UseVisualStyleBackColor = true;
			this.BtGravar.Click += new System.EventHandler(this.BtGravar_Click);
			// 
			// ViewNameFolder
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(478, 139);
			this.Controls.Add(this.BtGravar);
			this.Controls.Add(this.BtCancelar);
			this.Controls.Add(this.LbTitulo);
			this.Controls.Add(this.TxNomePasta);
			this.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Margin = new System.Windows.Forms.Padding(5);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "ViewNameFolder";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ViewNameFolder_FormClosing);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox TxNomePasta;
		private System.Windows.Forms.Label LbTitulo;
		private System.Windows.Forms.Button BtCancelar;
		private System.Windows.Forms.Button BtGravar;
	}
}