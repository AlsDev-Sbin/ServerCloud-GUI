
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
			this.TableMain = new System.Windows.Forms.TableLayoutPanel();
			this.TableOpracoes = new System.Windows.Forms.TableLayoutPanel();
			this.BtAvancar = new System.Windows.Forms.Button();
			this.BtVoltar = new System.Windows.Forms.Button();
			this.TxPastaAtual = new System.Windows.Forms.TextBox();
			this.FlowContainerFolders = new System.Windows.Forms.FlowLayoutPanel();
			this.PnRigth = new System.Windows.Forms.Panel();
			this.PnLeft = new System.Windows.Forms.Panel();
			this.PnBot = new System.Windows.Forms.Panel();
			this.PnTop = new System.Windows.Forms.Panel();
			this.ProgressBar = new System.Windows.Forms.ProgressBar();
			this.TableMain.SuspendLayout();
			this.TableOpracoes.SuspendLayout();
			this.SuspendLayout();
			// 
			// TableMain
			// 
			this.TableMain.ColumnCount = 1;
			this.TableMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.TableMain.Controls.Add(this.TableOpracoes, 0, 0);
			this.TableMain.Controls.Add(this.FlowContainerFolders, 0, 1);
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
			this.TableOpracoes.ColumnCount = 3;
			this.TableOpracoes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.272727F));
			this.TableOpracoes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.532467F));
			this.TableOpracoes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85.19481F));
			this.TableOpracoes.Controls.Add(this.BtAvancar, 1, 0);
			this.TableOpracoes.Controls.Add(this.BtVoltar, 0, 0);
			this.TableOpracoes.Controls.Add(this.TxPastaAtual, 2, 0);
			this.TableOpracoes.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TableOpracoes.Location = new System.Drawing.Point(3, 3);
			this.TableOpracoes.Name = "TableOpracoes";
			this.TableOpracoes.RowCount = 1;
			this.TableOpracoes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.TableOpracoes.Size = new System.Drawing.Size(771, 42);
			this.TableOpracoes.TabIndex = 3;
			// 
			// BtAvancar
			// 
			this.BtAvancar.Dock = System.Windows.Forms.DockStyle.Left;
			this.BtAvancar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
			this.BtAvancar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.BtAvancar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
			this.BtAvancar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtAvancar.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.BtAvancar.Location = new System.Drawing.Point(59, 3);
			this.BtAvancar.Name = "BtAvancar";
			this.BtAvancar.Size = new System.Drawing.Size(38, 36);
			this.BtAvancar.TabIndex = 3;
			this.BtAvancar.Text = "▶️";
			this.BtAvancar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.BtAvancar.UseVisualStyleBackColor = true;
			// 
			// BtVoltar
			// 
			this.BtVoltar.Dock = System.Windows.Forms.DockStyle.Left;
			this.BtVoltar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
			this.BtVoltar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.BtVoltar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
			this.BtVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtVoltar.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.BtVoltar.Location = new System.Drawing.Point(3, 3);
			this.BtVoltar.Name = "BtVoltar";
			this.BtVoltar.Size = new System.Drawing.Size(38, 36);
			this.BtVoltar.TabIndex = 2;
			this.BtVoltar.Text = "◀️";
			this.BtVoltar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.BtVoltar.UseVisualStyleBackColor = true;
			// 
			// TxPastaAtual
			// 
			this.TxPastaAtual.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TxPastaAtual.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.TxPastaAtual.Location = new System.Drawing.Point(117, 3);
			this.TxPastaAtual.Multiline = true;
			this.TxPastaAtual.Name = "TxPastaAtual";
			this.TxPastaAtual.Size = new System.Drawing.Size(651, 36);
			this.TxPastaAtual.TabIndex = 4;
			// 
			// FlowContainerFolders
			// 
			this.FlowContainerFolders.Dock = System.Windows.Forms.DockStyle.Fill;
			this.FlowContainerFolders.Location = new System.Drawing.Point(3, 51);
			this.FlowContainerFolders.Name = "FlowContainerFolders";
			this.FlowContainerFolders.Size = new System.Drawing.Size(771, 362);
			this.FlowContainerFolders.TabIndex = 4;
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
		private System.Windows.Forms.FlowLayoutPanel FlowContainerFolders;
	}
}
