namespace AirSystem.Views
{
    partial class frmCadastro
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
            this.lblNome = new System.Windows.Forms.Label();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.lblDataNascimento = new System.Windows.Forms.Label();
            this.tbxNome = new System.Windows.Forms.TextBox();
            this.tbxSobrenome = new System.Windows.Forms.TextBox();
            this.tbxEnderco = new System.Windows.Forms.TextBox();
            this.dateTimePickerNascimento = new System.Windows.Forms.DateTimePicker();
            this.tbxConfirmar = new System.Windows.Forms.TextBox();
            this.lblSobrenome = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblConfirmar = new System.Windows.Forms.Label();
            this.tbxSenha = new System.Windows.Forms.TextBox();
            this.tbxUsuario = new System.Windows.Forms.TextBox();
            this.tbxNumero = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.lblFoto = new System.Windows.Forms.Label();
            this.btnSelecionar = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.checkBoxAdm = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(50, 48);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome";
            this.lblNome.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Location = new System.Drawing.Point(50, 104);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(53, 13);
            this.lblEndereco.TabIndex = 2;
            this.lblEndereco.Text = "Endereço";
            // 
            // lblDataNascimento
            // 
            this.lblDataNascimento.AutoSize = true;
            this.lblDataNascimento.Location = new System.Drawing.Point(50, 167);
            this.lblDataNascimento.Name = "lblDataNascimento";
            this.lblDataNascimento.Size = new System.Drawing.Size(89, 13);
            this.lblDataNascimento.TabIndex = 3;
            this.lblDataNascimento.Text = "Data Nascimento";
            // 
            // tbxNome
            // 
            this.tbxNome.Location = new System.Drawing.Point(109, 45);
            this.tbxNome.Name = "tbxNome";
            this.tbxNome.Size = new System.Drawing.Size(100, 20);
            this.tbxNome.TabIndex = 4;
            this.tbxNome.TextChanged += new System.EventHandler(this.tbxNome_TextChanged);
            // 
            // tbxSobrenome
            // 
            this.tbxSobrenome.Location = new System.Drawing.Point(311, 45);
            this.tbxSobrenome.Name = "tbxSobrenome";
            this.tbxSobrenome.Size = new System.Drawing.Size(100, 20);
            this.tbxSobrenome.TabIndex = 5;
            this.tbxSobrenome.TextChanged += new System.EventHandler(this.tbxSobrenome_TextChanged);
            // 
            // tbxEnderco
            // 
            this.tbxEnderco.Location = new System.Drawing.Point(109, 101);
            this.tbxEnderco.Name = "tbxEnderco";
            this.tbxEnderco.Size = new System.Drawing.Size(100, 20);
            this.tbxEnderco.TabIndex = 6;
            this.tbxEnderco.TextChanged += new System.EventHandler(this.tbxEnderco_TextChanged);
            // 
            // dateTimePickerNascimento
            // 
            this.dateTimePickerNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerNascimento.Location = new System.Drawing.Point(156, 167);
            this.dateTimePickerNascimento.Name = "dateTimePickerNascimento";
            this.dateTimePickerNascimento.Size = new System.Drawing.Size(100, 20);
            this.dateTimePickerNascimento.TabIndex = 7;
            this.dateTimePickerNascimento.ValueChanged += new System.EventHandler(this.dateTimePickerNascimento_ValueChanged);
            // 
            // tbxConfirmar
            // 
            this.tbxConfirmar.Location = new System.Drawing.Point(156, 326);
            this.tbxConfirmar.Name = "tbxConfirmar";
            this.tbxConfirmar.Size = new System.Drawing.Size(100, 20);
            this.tbxConfirmar.TabIndex = 8;
            this.tbxConfirmar.TextChanged += new System.EventHandler(this.tbxConfirmar_TextChanged);
            // 
            // lblSobrenome
            // 
            this.lblSobrenome.AutoSize = true;
            this.lblSobrenome.Location = new System.Drawing.Point(244, 48);
            this.lblSobrenome.Name = "lblSobrenome";
            this.lblSobrenome.Size = new System.Drawing.Size(61, 13);
            this.lblSobrenome.TabIndex = 9;
            this.lblSobrenome.Text = "Sobrenome";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(244, 104);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(19, 13);
            this.lblNumero.TabIndex = 10;
            this.lblNumero.Text = "Nº";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(50, 224);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(43, 13);
            this.lblUsuario.TabIndex = 11;
            this.lblUsuario.Text = "Usuario";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(50, 278);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(38, 13);
            this.lblSenha.TabIndex = 12;
            this.lblSenha.Text = "Senha";
            // 
            // lblConfirmar
            // 
            this.lblConfirmar.AutoSize = true;
            this.lblConfirmar.Location = new System.Drawing.Point(50, 329);
            this.lblConfirmar.Name = "lblConfirmar";
            this.lblConfirmar.Size = new System.Drawing.Size(83, 13);
            this.lblConfirmar.TabIndex = 13;
            this.lblConfirmar.Text = "Confirmar senha";
            this.lblConfirmar.Click += new System.EventHandler(this.label8_Click);
            // 
            // tbxSenha
            // 
            this.tbxSenha.Location = new System.Drawing.Point(109, 271);
            this.tbxSenha.Name = "tbxSenha";
            this.tbxSenha.Size = new System.Drawing.Size(100, 20);
            this.tbxSenha.TabIndex = 14;
            this.tbxSenha.TextChanged += new System.EventHandler(this.tbxSenha_TextChanged);
            // 
            // tbxUsuario
            // 
            this.tbxUsuario.Location = new System.Drawing.Point(109, 221);
            this.tbxUsuario.Name = "tbxUsuario";
            this.tbxUsuario.Size = new System.Drawing.Size(100, 20);
            this.tbxUsuario.TabIndex = 15;
            this.tbxUsuario.TextChanged += new System.EventHandler(this.tbxUsuario_TextChanged);
            // 
            // tbxNumero
            // 
            this.tbxNumero.Location = new System.Drawing.Point(311, 104);
            this.tbxNumero.Name = "tbxNumero";
            this.tbxNumero.Size = new System.Drawing.Size(100, 20);
            this.tbxNumero.TabIndex = 16;
            this.tbxNumero.TextChanged += new System.EventHandler(this.tbxNumero_TextChanged);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(336, 404);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrar.TabIndex = 17;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // lblFoto
            // 
            this.lblFoto.AutoSize = true;
            this.lblFoto.Location = new System.Drawing.Point(463, 45);
            this.lblFoto.Name = "lblFoto";
            this.lblFoto.Size = new System.Drawing.Size(28, 13);
            this.lblFoto.TabIndex = 19;
            this.lblFoto.Text = "Foto";
            // 
            // btnSelecionar
            // 
            this.btnSelecionar.Location = new System.Drawing.Point(603, 48);
            this.btnSelecionar.Name = "btnSelecionar";
            this.btnSelecionar.Size = new System.Drawing.Size(75, 23);
            this.btnSelecionar.TabIndex = 20;
            this.btnSelecionar.Text = "Alterar";
            this.btnSelecionar.UseVisualStyleBackColor = true;
            this.btnSelecionar.Click += new System.EventHandler(this.btnSelecionar_Click);
            // 
            // btnDeletar
            // 
            this.btnDeletar.Location = new System.Drawing.Point(603, 77);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(75, 23);
            this.btnDeletar.TabIndex = 21;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(497, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 73);
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // checkBoxAdm
            // 
            this.checkBoxAdm.AutoSize = true;
            this.checkBoxAdm.Location = new System.Drawing.Point(497, 152);
            this.checkBoxAdm.Name = "checkBoxAdm";
            this.checkBoxAdm.Size = new System.Drawing.Size(47, 17);
            this.checkBoxAdm.TabIndex = 23;
            this.checkBoxAdm.Text = "Adm";
            this.checkBoxAdm.UseVisualStyleBackColor = true;
            // 
            // frmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 450);
            this.Controls.Add(this.checkBoxAdm);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnSelecionar);
            this.Controls.Add(this.lblFoto);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.tbxNumero);
            this.Controls.Add(this.tbxUsuario);
            this.Controls.Add(this.tbxSenha);
            this.Controls.Add(this.lblConfirmar);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.lblSobrenome);
            this.Controls.Add(this.tbxConfirmar);
            this.Controls.Add(this.dateTimePickerNascimento);
            this.Controls.Add(this.tbxEnderco);
            this.Controls.Add(this.tbxSobrenome);
            this.Controls.Add(this.tbxNome);
            this.Controls.Add(this.lblDataNascimento);
            this.Controls.Add(this.lblEndereco);
            this.Controls.Add(this.lblNome);
            this.Name = "frmCadastro";
            this.Text = "Cadastro - AirSystem";
            this.Load += new System.EventHandler(this.frmCadastro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.Label lblDataNascimento;
        private System.Windows.Forms.TextBox tbxNome;
        private System.Windows.Forms.TextBox tbxSobrenome;
        private System.Windows.Forms.TextBox tbxEnderco;
        private System.Windows.Forms.DateTimePicker dateTimePickerNascimento;
        private System.Windows.Forms.TextBox tbxConfirmar;
        private System.Windows.Forms.Label lblSobrenome;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblConfirmar;
        private System.Windows.Forms.TextBox tbxSenha;
        private System.Windows.Forms.TextBox tbxUsuario;
        private System.Windows.Forms.TextBox tbxNumero;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label lblFoto;
        private System.Windows.Forms.Button btnSelecionar;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox checkBoxAdm;
    }
}