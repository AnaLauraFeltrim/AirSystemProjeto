namespace AirSystem
{
    partial class frmLogin
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.tbxUsuario = new System.Windows.Forms.TextBox();
            this.tbxSenha = new System.Windows.Forms.TextBox();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.btnCadastrese = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(333, 184);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(60, 18);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Usuário";
            this.lblUsuario.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.Location = new System.Drawing.Point(333, 265);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(50, 18);
            this.lblSenha.TabIndex = 1;
            this.lblSenha.Text = "Senha";
            // 
            // tbxUsuario
            // 
            this.tbxUsuario.Location = new System.Drawing.Point(280, 205);
            this.tbxUsuario.Name = "tbxUsuario";
            this.tbxUsuario.Size = new System.Drawing.Size(175, 20);
            this.tbxUsuario.TabIndex = 2;
            this.tbxUsuario.TextChanged += new System.EventHandler(this.tbxUsuario_TextChanged);
            // 
            // tbxSenha
            // 
            this.tbxSenha.Location = new System.Drawing.Point(280, 286);
            this.tbxSenha.Name = "tbxSenha";
            this.tbxSenha.Size = new System.Drawing.Size(175, 20);
            this.tbxSenha.TabIndex = 3;
            // 
            // btnEntrar
            // 
            this.btnEntrar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnEntrar.Location = new System.Drawing.Point(233, 375);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(75, 23);
            this.btnEntrar.TabIndex = 4;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = false;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // btnCadastrese
            // 
            this.btnCadastrese.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnCadastrese.Location = new System.Drawing.Point(403, 375);
            this.btnCadastrese.Name = "btnCadastrese";
            this.btnCadastrese.Size = new System.Drawing.Size(86, 23);
            this.btnCadastrese.TabIndex = 5;
            this.btnCadastrese.Text = "Novo Usuário";
            this.btnCadastrese.UseVisualStyleBackColor = false;
            this.btnCadastrese.Click += new System.EventHandler(this.btnCadastrese_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnSair.Location = new System.Drawing.Point(320, 375);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(73, 23);
            this.btnSair.TabIndex = 6;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AirSystem.Properties.Resources.Logo1;
            this.pictureBox1.Location = new System.Drawing.Point(233, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(714, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnCadastrese);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.tbxSenha);
            this.Controls.Add(this.tbxUsuario);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblUsuario);
            this.Name = "frmLogin";
            this.Text = "Login - AirSystem";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox tbxUsuario;
        private System.Windows.Forms.TextBox tbxSenha;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Button btnCadastrese;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

