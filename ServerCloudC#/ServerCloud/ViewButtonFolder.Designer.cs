
namespace ServerCloud
{
	partial class ViewButtonFolder
	{
		/// <summary> 
		/// Variável de designer necessária.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Limpar os recursos que estão sendo usados.
		/// </summary>
		/// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código gerado pelo Designer de Componentes

		/// <summary> 
		/// Método necessário para suporte ao Designer - não modifique 
		/// o conteúdo deste método com o editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.Pic = new System.Windows.Forms.PictureBox();
			this.LbCaptionFolder = new System.Windows.Forms.Label();
			this.PicExcluir = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.Pic)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PicExcluir)).BeginInit();
			this.SuspendLayout();
			// 
			// Pic
			// 
			this.Pic.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.Pic.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Pic.Image = global::ServerCloud.Properties.Resources.folder_104px;
			this.Pic.Location = new System.Drawing.Point(12, 3);
			this.Pic.Name = "Pic";
			this.Pic.Size = new System.Drawing.Size(84, 82);
			this.Pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.Pic.TabIndex = 0;
			this.Pic.TabStop = false;
			this.Pic.DoubleClick += new System.EventHandler(this.Click);
			// 
			// LbCaptionFolder
			// 
			this.LbCaptionFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.LbCaptionFolder.Cursor = System.Windows.Forms.Cursors.Hand;
			this.LbCaptionFolder.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.LbCaptionFolder.Location = new System.Drawing.Point(3, 88);
			this.LbCaptionFolder.Name = "LbCaptionFolder";
			this.LbCaptionFolder.Size = new System.Drawing.Size(104, 28);
			this.LbCaptionFolder.TabIndex = 1;
			this.LbCaptionFolder.Text = "Folder";
			this.LbCaptionFolder.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.LbCaptionFolder.DoubleClick += new System.EventHandler(this.Click);
			// 
			// PicExcluir
			// 
			this.PicExcluir.BackColor = System.Drawing.Color.Transparent;
			this.PicExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
			this.PicExcluir.Image = global::ServerCloud.Properties.Resources.trash_64px;
			this.PicExcluir.Location = new System.Drawing.Point(-4, -3);
			this.PicExcluir.Name = "PicExcluir";
			this.PicExcluir.Size = new System.Drawing.Size(17, 20);
			this.PicExcluir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.PicExcluir.TabIndex = 2;
			this.PicExcluir.TabStop = false;
			this.PicExcluir.Click += new System.EventHandler(this.PicExcluir_Click);
			// 
			// ViewButtonFolder
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.PicExcluir);
			this.Controls.Add(this.LbCaptionFolder);
			this.Controls.Add(this.Pic);
			this.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.Name = "ViewButtonFolder";
			this.Size = new System.Drawing.Size(107, 121);
			this.DoubleClick += new System.EventHandler(this.Click);
			((System.ComponentModel.ISupportInitialize)(this.Pic)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PicExcluir)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox Pic;
		public System.Windows.Forms.Label LbCaptionFolder;
		private System.Windows.Forms.PictureBox PicExcluir;
	}
}
