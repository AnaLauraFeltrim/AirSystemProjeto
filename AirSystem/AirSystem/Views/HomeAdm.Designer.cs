namespace AirSystem.Views
{
    partial class HomeAdm
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
            this.btnListarUsuarios = new System.Windows.Forms.Button();
            this.btnListarAvioes = new System.Windows.Forms.Button();
            this.btnGerenciarAviao = new System.Windows.Forms.Button();
            this.btnGerenciarCompanhia = new System.Windows.Forms.Button();
            this.btnGrnRelatorios = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnListarUsuarios
            // 
            this.btnListarUsuarios.Location = new System.Drawing.Point(78, 70);
            this.btnListarUsuarios.Name = "btnListarUsuarios";
            this.btnListarUsuarios.Size = new System.Drawing.Size(209, 126);
            this.btnListarUsuarios.TabIndex = 0;
            this.btnListarUsuarios.Text = "Listar Usuários";
            this.btnListarUsuarios.UseVisualStyleBackColor = true;
            this.btnListarUsuarios.Click += new System.EventHandler(this.btnListarUsuarios_Click);
            // 
            // btnListarAvioes
            // 
            this.btnListarAvioes.Location = new System.Drawing.Point(313, 70);
            this.btnListarAvioes.Name = "btnListarAvioes";
            this.btnListarAvioes.Size = new System.Drawing.Size(209, 126);
            this.btnListarAvioes.TabIndex = 1;
            this.btnListarAvioes.Text = "Listar Aviões";
            this.btnListarAvioes.UseVisualStyleBackColor = true;
            this.btnListarAvioes.Click += new System.EventHandler(this.btnListarAvioes_Click);
            // 
            // btnGerenciarAviao
            // 
            this.btnGerenciarAviao.Location = new System.Drawing.Point(547, 70);
            this.btnGerenciarAviao.Name = "btnGerenciarAviao";
            this.btnGerenciarAviao.Size = new System.Drawing.Size(209, 126);
            this.btnGerenciarAviao.TabIndex = 2;
            this.btnGerenciarAviao.Text = "Gerenciar Avião";
            this.btnGerenciarAviao.UseVisualStyleBackColor = true;
            // 
            // btnGerenciarCompanhia
            // 
            this.btnGerenciarCompanhia.Location = new System.Drawing.Point(78, 237);
            this.btnGerenciarCompanhia.Name = "btnGerenciarCompanhia";
            this.btnGerenciarCompanhia.Size = new System.Drawing.Size(209, 126);
            this.btnGerenciarCompanhia.TabIndex = 3;
            this.btnGerenciarCompanhia.Text = "Gerenciar Companhia";
            this.btnGerenciarCompanhia.UseVisualStyleBackColor = true;
            // 
            // btnGrnRelatorios
            // 
            this.btnGrnRelatorios.Location = new System.Drawing.Point(313, 237);
            this.btnGrnRelatorios.Name = "btnGrnRelatorios";
            this.btnGrnRelatorios.Size = new System.Drawing.Size(209, 126);
            this.btnGrnRelatorios.TabIndex = 4;
            this.btnGrnRelatorios.Text = "Gerenciar Relatórios";
            this.btnGrnRelatorios.UseVisualStyleBackColor = true;
            // 
            // HomeAdm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGrnRelatorios);
            this.Controls.Add(this.btnGerenciarCompanhia);
            this.Controls.Add(this.btnGerenciarAviao);
            this.Controls.Add(this.btnListarAvioes);
            this.Controls.Add(this.btnListarUsuarios);
            this.Name = "HomeAdm";
            this.Text = "Tela Principal - AirSystem";
            this.Load += new System.EventHandler(this.TelaPrincipalAdm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnListarUsuarios;
        private System.Windows.Forms.Button btnListarAvioes;
        private System.Windows.Forms.Button btnGerenciarAviao;
        private System.Windows.Forms.Button btnGerenciarCompanhia;
        private System.Windows.Forms.Button btnGrnRelatorios;
    }
}