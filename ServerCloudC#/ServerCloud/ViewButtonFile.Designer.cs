
namespace ServerCloud
{
	partial class ViewButtonFile
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewButtonFile));
			this.Pic = new System.Windows.Forms.PictureBox();
			this.LbCaptionFile = new System.Windows.Forms.Label();
			this.BtDownload = new System.Windows.Forms.Button();
			this.ImgList = new System.Windows.Forms.ImageList(this.components);
			this.LbBytes = new System.Windows.Forms.Label();
			this.pn1 = new System.Windows.Forms.Panel();
			this.pnDivider = new System.Windows.Forms.Panel();
			this.ProgressBar = new System.Windows.Forms.ProgressBar();
			((System.ComponentModel.ISupportInitialize)(this.Pic)).BeginInit();
			this.pn1.SuspendLayout();
			this.SuspendLayout();
			// 
			// Pic
			// 
			this.Pic.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.Pic.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.Pic.Image = global::ServerCloud.Properties.Resources.file_104px;
			this.Pic.Location = new System.Drawing.Point(21, 3);
			this.Pic.Name = "Pic";
			this.Pic.Size = new System.Drawing.Size(65, 65);
			this.Pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.Pic.TabIndex = 0;
			this.Pic.TabStop = false;
			// 
			// LbCaptionFile
			// 
			this.LbCaptionFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.LbCaptionFile.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.LbCaptionFile.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.LbCaptionFile.Location = new System.Drawing.Point(2, 91);
			this.LbCaptionFile.Name = "LbCaptionFile";
			this.LbCaptionFile.Size = new System.Drawing.Size(103, 25);
			this.LbCaptionFile.TabIndex = 1;
			this.LbCaptionFile.Text = "File";
			this.LbCaptionFile.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// BtDownload
			// 
			this.BtDownload.BackColor = System.Drawing.Color.Transparent;
			this.BtDownload.Cursor = System.Windows.Forms.Cursors.Hand;
			this.BtDownload.FlatAppearance.BorderSize = 0;
			this.BtDownload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtDownload.ImageKey = "downloading_updates_64px.png";
			this.BtDownload.ImageList = this.ImgList;
			this.BtDownload.Location = new System.Drawing.Point(90, 2);
			this.BtDownload.Name = "BtDownload";
			this.BtDownload.Size = new System.Drawing.Size(13, 17);
			this.BtDownload.TabIndex = 2;
			this.BtDownload.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			this.BtDownload.UseVisualStyleBackColor = false;
			this.BtDownload.Click += new System.EventHandler(this.Click);
			// 
			// ImgList
			// 
			this.ImgList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			this.ImgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImgList.ImageStream")));
			this.ImgList.TransparentColor = System.Drawing.Color.Transparent;
			this.ImgList.Images.SetKeyName(0, "downloading_updates_64px.png");
			// 
			// LbBytes
			// 
			this.LbBytes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.LbBytes.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.LbBytes.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.LbBytes.Location = new System.Drawing.Point(0, 0);
			this.LbBytes.Name = "LbBytes";
			this.LbBytes.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
			this.LbBytes.Size = new System.Drawing.Size(73, 20);
			this.LbBytes.TabIndex = 3;
			this.LbBytes.Text = "0 B";
			this.LbBytes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pn1
			// 
			this.pn1.Controls.Add(this.LbBytes);
			this.pn1.Controls.Add(this.BtDownload);
			this.pn1.Location = new System.Drawing.Point(0, 68);
			this.pn1.Name = "pn1";
			this.pn1.Size = new System.Drawing.Size(106, 22);
			this.pn1.TabIndex = 4;
			// 
			// pnDivider
			// 
			this.pnDivider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.pnDivider.Location = new System.Drawing.Point(0, 89);
			this.pnDivider.Name = "pnDivider";
			this.pnDivider.Size = new System.Drawing.Size(107, 2);
			this.pnDivider.TabIndex = 5;
			// 
			// ProgressBar
			// 
			this.ProgressBar.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.ProgressBar.Location = new System.Drawing.Point(0, 119);
			this.ProgressBar.MarqueeAnimationSpeed = 60;
			this.ProgressBar.Name = "ProgressBar";
			this.ProgressBar.Size = new System.Drawing.Size(107, 2);
			this.ProgressBar.Step = 15;
			this.ProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
			this.ProgressBar.TabIndex = 6;
			this.ProgressBar.Value = 100;
			this.ProgressBar.Visible = false;
			// 
			// ViewButtonFile
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.ProgressBar);
			this.Controls.Add(this.pnDivider);
			this.Controls.Add(this.pn1);
			this.Controls.Add(this.LbCaptionFile);
			this.Controls.Add(this.Pic);
			this.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.Name = "ViewButtonFile";
			this.Size = new System.Drawing.Size(107, 121);
			this.DoubleClick += new System.EventHandler(this.Click);
			((System.ComponentModel.ISupportInitialize)(this.Pic)).EndInit();
			this.pn1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox Pic;
		public System.Windows.Forms.Label LbCaptionFile;
		private System.Windows.Forms.Button BtDownload;
		private System.Windows.Forms.ImageList ImgList;
		public System.Windows.Forms.Label LbBytes;
		private System.Windows.Forms.Panel pn1;
		private System.Windows.Forms.Panel pnDivider;
		public System.Windows.Forms.ProgressBar ProgressBar;
	}
}
