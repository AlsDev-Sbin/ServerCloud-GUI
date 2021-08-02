
namespace ServerCloud
{
	partial class MainLogin
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.TabMain = new System.Windows.Forms.TabControl();
			this.PageLogin = new System.Windows.Forms.TabPage();
			this.ProgressBarLogin = new System.Windows.Forms.ProgressBar();
			this.LinkCriarConta = new System.Windows.Forms.LinkLabel();
			this.BtEntrar = new System.Windows.Forms.Button();
			this.Lb2 = new System.Windows.Forms.Label();
			this.Lb1 = new System.Windows.Forms.Label();
			this.TxSenha = new System.Windows.Forms.TextBox();
			this.TxUsuario = new System.Windows.Forms.TextBox();
			this.PagePastas = new System.Windows.Forms.TabPage();
			this.PnPastas = new System.Windows.Forms.Panel();
			this.BtVoltar = new System.Windows.Forms.Button();
			this.TabMain.SuspendLayout();
			this.PageLogin.SuspendLayout();
			this.PagePastas.SuspendLayout();
			this.SuspendLayout();
			// 
			// TabMain
			// 
			this.TabMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.TabMain.Controls.Add(this.PageLogin);
			this.TabMain.Controls.Add(this.PagePastas);
			this.TabMain.Location = new System.Drawing.Point(-4, -24);
			this.TabMain.Name = "TabMain";
			this.TabMain.SelectedIndex = 0;
			this.TabMain.Size = new System.Drawing.Size(808, 508);
			this.TabMain.TabIndex = 6;
			// 
			// PageLogin
			// 
			this.PageLogin.Controls.Add(this.ProgressBarLogin);
			this.PageLogin.Controls.Add(this.LinkCriarConta);
			this.PageLogin.Controls.Add(this.BtEntrar);
			this.PageLogin.Controls.Add(this.Lb2);
			this.PageLogin.Controls.Add(this.Lb1);
			this.PageLogin.Controls.Add(this.TxSenha);
			this.PageLogin.Controls.Add(this.TxUsuario);
			this.PageLogin.Location = new System.Drawing.Point(4, 25);
			this.PageLogin.Name = "PageLogin";
			this.PageLogin.Padding = new System.Windows.Forms.Padding(3);
			this.PageLogin.Size = new System.Drawing.Size(800, 479);
			this.PageLogin.TabIndex = 0;
			this.PageLogin.Text = "Login";
			this.PageLogin.UseVisualStyleBackColor = true;
			// 
			// ProgressBarLogin
			// 
			this.ProgressBarLogin.Location = new System.Drawing.Point(-1, 476);
			this.ProgressBarLogin.Margin = new System.Windows.Forms.Padding(0);
			this.ProgressBarLogin.MarqueeAnimationSpeed = 20;
			this.ProgressBarLogin.Name = "ProgressBarLogin";
			this.ProgressBarLogin.Size = new System.Drawing.Size(801, 4);
			this.ProgressBarLogin.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
			this.ProgressBarLogin.TabIndex = 12;
			// 
			// LinkCriarConta
			// 
			this.LinkCriarConta.AutoSize = true;
			this.LinkCriarConta.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.LinkCriarConta.Location = new System.Drawing.Point(327, 303);
			this.LinkCriarConta.Name = "LinkCriarConta";
			this.LinkCriarConta.Size = new System.Drawing.Size(70, 16);
			this.LinkCriarConta.TabIndex = 11;
			this.LinkCriarConta.TabStop = true;
			this.LinkCriarConta.Text = "Criar conta";
			// 
			// BtEntrar
			// 
			this.BtEntrar.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.BtEntrar.Location = new System.Drawing.Point(288, 265);
			this.BtEntrar.Name = "BtEntrar";
			this.BtEntrar.Size = new System.Drawing.Size(153, 35);
			this.BtEntrar.TabIndex = 10;
			this.BtEntrar.Text = "Entrar";
			this.BtEntrar.UseVisualStyleBackColor = true;
			this.BtEntrar.Click += new System.EventHandler(this.BtEntrar_Click);
			// 
			// Lb2
			// 
			this.Lb2.AutoSize = true;
			this.Lb2.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.Lb2.Location = new System.Drawing.Point(171, 183);
			this.Lb2.Name = "Lb2";
			this.Lb2.Size = new System.Drawing.Size(51, 18);
			this.Lb2.TabIndex = 9;
			this.Lb2.Text = "Senha";
			// 
			// Lb1
			// 
			this.Lb1.AutoSize = true;
			this.Lb1.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.Lb1.Location = new System.Drawing.Point(171, 93);
			this.Lb1.Name = "Lb1";
			this.Lb1.Size = new System.Drawing.Size(62, 18);
			this.Lb1.TabIndex = 8;
			this.Lb1.Text = "Usuário";
			// 
			// TxSenha
			// 
			this.TxSenha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.TxSenha.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.TxSenha.Location = new System.Drawing.Point(171, 206);
			this.TxSenha.Name = "TxSenha";
			this.TxSenha.Size = new System.Drawing.Size(403, 26);
			this.TxSenha.TabIndex = 7;
			// 
			// TxUsuario
			// 
			this.TxUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.TxUsuario.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.TxUsuario.Location = new System.Drawing.Point(171, 115);
			this.TxUsuario.Name = "TxUsuario";
			this.TxUsuario.Size = new System.Drawing.Size(403, 26);
			this.TxUsuario.TabIndex = 6;
			// 
			// PagePastas
			// 
			this.PagePastas.Controls.Add(this.PnPastas);
			this.PagePastas.Controls.Add(this.BtVoltar);
			this.PagePastas.Location = new System.Drawing.Point(4, 25);
			this.PagePastas.Name = "PagePastas";
			this.PagePastas.Padding = new System.Windows.Forms.Padding(3);
			this.PagePastas.Size = new System.Drawing.Size(800, 479);
			this.PagePastas.TabIndex = 1;
			this.PagePastas.Text = "tabPage2";
			this.PagePastas.UseVisualStyleBackColor = true;
			// 
			// PnPastas
			// 
			this.PnPastas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.PnPastas.Location = new System.Drawing.Point(6, 49);
			this.PnPastas.Name = "PnPastas";
			this.PnPastas.Size = new System.Drawing.Size(788, 424);
			this.PnPastas.TabIndex = 2;
			// 
			// BtVoltar
			// 
			this.BtVoltar.FlatAppearance.BorderSize = 0;
			this.BtVoltar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.BtVoltar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
			this.BtVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtVoltar.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.BtVoltar.Location = new System.Drawing.Point(6, 6);
			this.BtVoltar.Name = "BtVoltar";
			this.BtVoltar.Size = new System.Drawing.Size(98, 37);
			this.BtVoltar.TabIndex = 1;
			this.BtVoltar.Text = "◀️ Voltar";
			this.BtVoltar.UseVisualStyleBackColor = true;
			this.BtVoltar.Click += new System.EventHandler(this.BtVoltar_Click);
			// 
			// MainLogin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 480);
			this.Controls.Add(this.TabMain);
			this.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.Name = "MainLogin";
			this.Text = "ServerCloud";
			this.TabMain.ResumeLayout(false);
			this.PageLogin.ResumeLayout(false);
			this.PageLogin.PerformLayout();
			this.PagePastas.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl TabMain;
		private System.Windows.Forms.TabPage PageLogin;
		private System.Windows.Forms.LinkLabel LinkCriarConta;
		private System.Windows.Forms.Button BtEntrar;
		private System.Windows.Forms.Label Lb2;
		private System.Windows.Forms.Label Lb1;
		private System.Windows.Forms.TextBox TxSenha;
		private System.Windows.Forms.TextBox TxUsuario;
		private System.Windows.Forms.TabPage PagePastas;
		private System.Windows.Forms.ProgressBar ProgressBarLogin;
		private System.Windows.Forms.Button BtVoltar;
		private System.Windows.Forms.Panel PnPastas;
	}
}

