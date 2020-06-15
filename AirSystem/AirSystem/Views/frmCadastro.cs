using System;
using AirSystem.Views;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AirSystem.Models;
using System.Text.RegularExpressions;

namespace AirSystem.Views
{
    public partial class frmCadastro : Form
    {
        public frmCadastro()
        {
            InitializeComponent();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

       

        private void frmCadastro_Load(object sender, EventArgs e)
        {

        }

        private void tbxNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbxSobrenome_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbxEnderco_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbxNumero_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePickerNascimento_ValueChanged(object sender, EventArgs e)
        {

        }

        private void tbxUsuario_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void tbxSenha_TextChanged(object sender, EventArgs e)
        {
           
            
        }

        private void tbxConfirmar_TextChanged(object sender, EventArgs e)
        {

        }

        private bool isPasswordRight(string password)
        {
            if (password.Length >= 8)
            {
                // Tem pelo menos uma letra minúscula
                string pattern = "[a-z]{1,}";
                if (Regex.IsMatch(password, pattern))
                {
                    // Tem ao menos uma letra maiúscula
                    pattern = "[A-Z]{1,}";
                }
                if (Regex.IsMatch(password, pattern))
                {
                    // Tem ao menos um número
                    pattern = "[0-9]{1,}";
                    if (Regex.IsMatch(password, pattern))
                    {
                        return true;
                    }
                }

            }
            return false;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            if (txt != null)
            {
                txt.BackColor = Color.LightYellow;
                if (txt.Text == "")
                {
                    txt.Text = "Digite seu " + txt.AccessibleName;
                }
            }

        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            
            ofd.Filter = "Arquivos de imagens(*.jpg;*.png)|*.jpg;*.png";
           
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                //Carregar a imagem selecionada no picturebox
                pictureBox1.Image = Image.FromFile(ofd.FileName);

            }

        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
