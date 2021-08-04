
namespace ServerCloud
{
	partial class MainPastas
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPastas));
			this.TableMain = new System.Windows.Forms.TableLayoutPanel();
			this.TableOpracoes = new System.Windows.Forms.TableLayoutPanel();
			this.ListDownload = new System.Windows.Forms.Button();
			this.Img = new System.Windows.Forms.ImageList(this.components);
			this.BtAddFolder = new System.Windows.Forms.Button();
			this.BtUpload = new System.Windows.Forms.Button();
			this.BtAvancar = new System.Windows.Forms.Button();
			this.BtVoltar = new System.Windows.Forms.Button();
			this.TxPastaAtual = new System.Windows.Forms.TextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.PnListDownloads = new System.Windows.Forms.Panel();
			this.ListDownloads = new System.Windows.Forms.ListBox();
			this.BtLimparListaDownload = new System.Windows.Forms.Button();
			this.FlowContainerFolders = new System.Windows.Forms.FlowLayoutPanel();
			this.PnRigth = new System.Windows.Forms.Panel();
			this.PnLeft = new System.Windows.Forms.Panel();
			this.PnBot = new System.Windows.Forms.Panel();
			this.PnTop = new System.Windows.Forms.Panel();
			this.ProgressBar = new System.Windows.Forms.ProgressBar();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.TableMain.SuspendLayout();
			this.TableOpracoes.SuspendLayout();
			this.panel1.SuspendLayout();
			this.PnListDownloads.SuspendLayout();
			this.SuspendLayout();
			// 
			// TableMain
			// 
			this.TableMain.ColumnCount = 1;
			this.TableMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.TableMain.Controls.Add(this.TableOpracoes, 0, 0);
			this.TableMain.Controls.Add(this.panel1, 0, 1);
			this.TableMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TableMain.Location = new System.Drawing.Point(2, 2);
			this.TableMain.Name = "TableMain";
			this.TableMain.RowCount = 2;
			this.TableMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
			this.TableMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.TableMain.Size = new System.Drawing.Size(777, 416);
			this.TableMain.TabIndex = 1;
			// 
			// TableOpracoes
			// 
			this.TableOpracoes.ColumnCount = 6;
			this.TableOpracoes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.163242F));
			this.TableOpracoes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.163242F));
			this.TableOpracoes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.163242F));
			this.TableOpracoes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.163242F));
			this.TableOpracoes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.34703F));
			this.TableOpracoes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 48F));
			this.TableOpracoes.Controls.Add(this.ListDownload, 6, 0);
			this.TableOpracoes.Controls.Add(this.BtAddFolder, 3, 0);
			this.TableOpracoes.Controls.Add(this.BtUpload, 2, 0);
			this.TableOpracoes.Controls.Add(this.BtAvancar, 1, 0);
			this.TableOpracoes.Controls.Add(this.BtVoltar, 0, 0);
			this.TableOpracoes.Controls.Add(this.TxPastaAtual, 4, 0);
			this.TableOpracoes.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TableOpracoes.Location = new System.Drawing.Point(3, 3);
			this.TableOpracoes.Name = "TableOpracoes";
			this.TableOpracoes.RowCount = 1;
			this.TableOpracoes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.TableOpracoes.Size = new System.Drawing.Size(771, 42);
			this.TableOpracoes.TabIndex = 3;
			// 
			// ListDownload
			// 
			this.ListDownload.BackColor = System.Drawing.Color.Transparent;
			this.ListDownload.Cursor = System.Windows.Forms.Cursors.Hand;
			this.ListDownload.Dock = System.Windows.Forms.DockStyle.Left;
			this.ListDownload.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
			this.ListDownload.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
			this.ListDownload.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.ListDownload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ListDownload.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.ListDownload.ImageKey = "menu_64px.png";
			this.ListDownload.ImageList = this.Img;
			this.ListDownload.Location = new System.Drawing.Point(722, 3);
			this.ListDownload.Name = "ListDownload";
			this.ListDownload.Size = new System.Drawing.Size(37, 36);
			this.ListDownload.TabIndex = 7;
			this.ListDownload.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.ListDownload.UseVisualStyleBackColor = false;
			this.ListDownload.Click += new System.EventHandler(this.ListDownload_Click);
			// 
			// Img
			// 
			this.Img.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			this.Img.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("Img.ImageStream")));
			this.Img.TransparentColor = System.Drawing.Color.Transparent;
			this.Img.Images.SetKeyName(0, "downloading_updates_64px.png");
			this.Img.Images.SetKeyName(1, "menu_64px.png");
			this.Img.Images.SetKeyName(2, "upload_64px.png");
			this.Img.Images.SetKeyName(3, "add_folder_64px.png");
			this.Img.Images.SetKeyName(4, "back_64px.png");
			this.Img.Images.SetKeyName(5, "more_than_64px.png");
			this.Img.Images.SetKeyName(6, "trash_64px.png");
			// 
			// BtAddFolder
			// 
			this.BtAddFolder.BackColor = System.Drawing.Color.Transparent;
			this.BtAddFolder.Cursor = System.Windows.Forms.Cursors.Hand;
			this.BtAddFolder.Dock = System.Windows.Forms.DockStyle.Left;
			this.BtAddFolder.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
			this.BtAddFolder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
			this.BtAddFolder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.BtAddFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtAddFolder.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.BtAddFolder.ImageKey = "add_folder_64px.png";
			this.BtAddFolder.ImageList = this.Img;
			this.BtAddFolder.Location = new System.Drawing.Point(156, 3);
			this.BtAddFolder.Name = "BtAddFolder";
			this.BtAddFolder.Size = new System.Drawing.Size(38, 36);
			this.BtAddFolder.TabIndex = 6;
			this.BtAddFolder.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.BtAddFolder.UseVisualStyleBackColor = false;
			this.BtAddFolder.Click += new System.EventHandler(this.BtAddFolder_Click);
			// 
			// BtUpload
			// 
			this.BtUpload.BackColor = System.Drawing.Color.Transparent;
			this.BtUpload.Cursor = System.Windows.Forms.Cursors.Hand;
			this.BtUpload.Dock = System.Windows.Forms.DockStyle.Left;
			this.BtUpload.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
			this.BtUpload.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
			this.BtUpload.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.BtUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtUpload.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.BtUpload.ImageKey = "upload_64px.png";
			this.BtUpload.ImageList = this.Img;
			this.BtUpload.Location = new System.Drawing.Point(105, 3);
			this.BtUpload.Name = "BtUpload";
			this.BtUpload.Size = new System.Drawing.Size(38, 36);
			this.BtUpload.TabIndex = 5;
			this.BtUpload.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.BtUpload.UseVisualStyleBackColor = false;
			this.BtUpload.Click += new System.EventHandler(this.BtUpload_Click);
			// 
			// BtAvancar
			// 
			this.BtAvancar.BackColor = System.Drawing.Color.Transparent;
			this.BtAvancar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.BtAvancar.Dock = System.Windows.Forms.DockStyle.Left;
			this.BtAvancar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
			this.BtAvancar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
			this.BtAvancar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.BtAvancar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtAvancar.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.BtAvancar.ImageKey = "more_than_64px.png";
			this.BtAvancar.ImageList = this.Img;
			this.BtAvancar.Location = new System.Drawing.Point(54, 3);
			this.BtAvancar.Name = "BtAvancar";
			this.BtAvancar.Size = new System.Drawing.Size(38, 36);
			this.BtAvancar.TabIndex = 3;
			this.BtAvancar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.BtAvancar.UseVisualStyleBackColor = false;
			// 
			// BtVoltar
			// 
			this.BtVoltar.BackColor = System.Drawing.Color.Transparent;
			this.BtVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.BtVoltar.Dock = System.Windows.Forms.DockStyle.Left;
			this.BtVoltar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
			this.BtVoltar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
			this.BtVoltar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.BtVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtVoltar.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.BtVoltar.ImageKey = "back_64px.png";
			this.BtVoltar.ImageList = this.Img;
			this.BtVoltar.Location = new System.Drawing.Point(3, 3);
			this.BtVoltar.Name = "BtVoltar";
			this.BtVoltar.Size = new System.Drawing.Size(38, 36);
			this.BtVoltar.TabIndex = 2;
			this.BtVoltar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.BtVoltar.UseVisualStyleBackColor = false;
			this.BtVoltar.Click += new System.EventHandler(this.BtVoltar_Click);
			// 
			// TxPastaAtual
			// 
			this.TxPastaAtual.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TxPastaAtual.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.TxPastaAtual.Location = new System.Drawing.Point(207, 3);
			this.TxPastaAtual.Margin = new System.Windows.Forms.Padding(3, 3, 15, 3);
			this.TxPastaAtual.Multiline = true;
			this.TxPastaAtual.Name = "TxPastaAtual";
			this.TxPastaAtual.Size = new System.Drawing.Size(497, 36);
			this.TxPastaAtual.TabIndex = 4;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.PnListDownloads);
			this.panel1.Controls.Add(this.FlowContainerFolders);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 48);
			this.panel1.Margin = new System.Windows.Forms.Padding(0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(777, 368);
			this.panel1.TabIndex = 4;
			// 
			// PnListDownloads
			// 
			this.PnListDownloads.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.PnListDownloads.Controls.Add(this.ListDownloads);
			this.PnListDownloads.Controls.Add(this.BtLimparListaDownload);
			this.PnListDownloads.Location = new System.Drawing.Point(575, 0);
			this.PnListDownloads.Name = "PnListDownloads";
			this.PnListDownloads.Size = new System.Drawing.Size(200, 368);
			this.PnListDownloads.TabIndex = 6;
			this.PnListDownloads.Visible = false;
			// 
			// ListDownloads
			// 
			this.ListDownloads.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ListDownloads.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.ListDownloads.ItemHeight = 20;
			this.ListDownloads.Location = new System.Drawing.Point(2, 1);
			this.ListDownloads.Margin = new System.Windows.Forms.Padding(0);
			this.ListDownloads.Name = "ListDownloads";
			this.ListDownloads.Size = new System.Drawing.Size(197, 304);
			this.ListDownloads.Sorted = true;
			this.ListDownloads.TabIndex = 8;
			// 
			// BtLimparListaDownload
			// 
			this.BtLimparListaDownload.BackColor = System.Drawing.Color.Transparent;
			this.BtLimparListaDownload.Cursor = System.Windows.Forms.Cursors.Hand;
			this.BtLimparListaDownload.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.BtLimparListaDownload.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
			this.BtLimparListaDownload.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
			this.BtLimparListaDownload.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.BtLimparListaDownload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtLimparListaDownload.Font = new System.Drawing.Font("Lucida Sans Unicode", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.BtLimparListaDownload.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(118)))), ((int)(((byte)(152)))));
			this.BtLimparListaDownload.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.BtLimparListaDownload.ImageKey = "trash_64px.png";
			this.BtLimparListaDownload.ImageList = this.Img;
			this.BtLimparListaDownload.Location = new System.Drawing.Point(0, 332);
			this.BtLimparListaDownload.Name = "BtLimparListaDownload";
			this.BtLimparListaDownload.Size = new System.Drawing.Size(200, 36);
			this.BtLimparListaDownload.TabIndex = 7;
			this.BtLimparListaDownload.Text = "Limpar";
			this.BtLimparListaDownload.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			this.BtLimparListaDownload.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.BtLimparListaDownload.UseVisualStyleBackColor = false;
			this.BtLimparListaDownload.Click += new System.EventHandler(this.BtLimparListaDownload_Click);
			// 
			// FlowContainerFolders
			// 
			this.FlowContainerFolders.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.FlowContainerFolders.Location = new System.Drawing.Point(2, 0);
			this.FlowContainerFolders.Margin = new System.Windows.Forms.Padding(0);
			this.FlowContainerFolders.Name = "FlowContainerFolders";
			this.FlowContainerFolders.Size = new System.Drawing.Size(574, 368);
			this.FlowContainerFolders.TabIndex = 5;
			// 
			// PnRigth
			// 
			this.PnRigth.BackColor = System.Drawing.Color.Silver;
			this.PnRigth.Dock = System.Windows.Forms.DockStyle.Right;
			this.PnRigth.Location = new System.Drawing.Point(779, 0);
			this.PnRigth.Name = "PnRigth";
			this.PnRigth.Size = new System.Drawing.Size(2, 423);
			this.PnRigth.TabIndex = 2;
			// 
			// PnLeft
			// 
			this.PnLeft.BackColor = System.Drawing.Color.Silver;
			this.PnLeft.Dock = System.Windows.Forms.DockStyle.Left;
			this.PnLeft.ForeColor = System.Drawing.Color.Silver;
			this.PnLeft.Location = new System.Drawing.Point(0, 0);
			this.PnLeft.Name = "PnLeft";
			this.PnLeft.Size = new System.Drawing.Size(2, 423);
			this.PnLeft.TabIndex = 3;
			// 
			// PnBot
			// 
			this.PnBot.BackColor = System.Drawing.Color.Silver;
			this.PnBot.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.PnBot.ForeColor = System.Drawing.Color.Silver;
			this.PnBot.Location = new System.Drawing.Point(2, 421);
			this.PnBot.Name = "PnBot";
			this.PnBot.Size = new System.Drawing.Size(777, 2);
			this.PnBot.TabIndex = 4;
			// 
			// PnTop
			// 
			this.PnTop.BackColor = System.Drawing.Color.Silver;
			this.PnTop.Dock = System.Windows.Forms.DockStyle.Top;
			this.PnTop.ForeColor = System.Drawing.Color.Silver;
			this.PnTop.Location = new System.Drawing.Point(2, 0);
			this.PnTop.Name = "PnTop";
			this.PnTop.Size = new System.Drawing.Size(777, 2);
			this.PnTop.TabIndex = 5;
			// 
			// ProgressBar
			// 
			this.ProgressBar.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.ProgressBar.Location = new System.Drawing.Point(2, 418);
			this.ProgressBar.MarqueeAnimationSpeed = 20;
			this.ProgressBar.Name = "ProgressBar";
			this.ProgressBar.Size = new System.Drawing.Size(777, 3);
			this.ProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
			this.ProgressBar.TabIndex = 4;
			this.ProgressBar.VisibleChanged += new System.EventHandler(this.ProgressBar_VisibleChanged);
			// 
			// imageList1
			// 
			this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			this.imageList1.Images.SetKeyName(0, "upload_64px.png");
			this.imageList1.Images.SetKeyName(1, "checkmark_64px.png");
			// 
			// MainPastas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.TableMain);
			this.Controls.Add(this.ProgressBar);
			this.Controls.Add(this.PnTop);
			this.Controls.Add(this.PnBot);
			this.Controls.Add(this.PnLeft);
			this.Controls.Add(this.PnRigth);
			this.Name = "MainPastas";
			this.Size = new System.Drawing.Size(781, 423);
			this.TableMain.ResumeLayout(false);
			this.TableOpracoes.ResumeLayout(false);
			this.TableOpracoes.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.PnListDownloads.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel TableMain;
		private System.Windows.Forms.TableLayoutPanel TableOpracoes;
		private System.Windows.Forms.Button BtAvancar;
		private System.Windows.Forms.Button BtVoltar;
		private System.Windows.Forms.TextBox TxPastaAtual;
		private System.Windows.Forms.Panel PnRigth;
		private System.Windows.Forms.Panel PnLeft;
		private System.Windows.Forms.Panel PnBot;
		private System.Windows.Forms.Panel PnTop;
		private System.Windows.Forms.ProgressBar ProgressBar;
		private System.Windows.Forms.Button BtAddFolder;
		private System.Windows.Forms.ImageList Img;
		private System.Windows.Forms.Button BtUpload;
		private System.Windows.Forms.Button ListDownload;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel PnListDownloads;
		private System.Windows.Forms.FlowLayoutPanel FlowContainerFolders;
		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.Button BtLimparListaDownload;
		private System.Windows.Forms.ListBox ListDownloads;
	}
}
