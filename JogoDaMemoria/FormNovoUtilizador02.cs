using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace JogoDaMemoria
{
    public partial class FormNovoUtilizador02 : Form
    {
        string pathCd = "credenciais.txt";
        public FormNovoUtilizador02()
        {
            InitializeComponent();
        }

        private void FormNovoUtilizador02_Load(object sender, EventArgs e)
        {

        }

        private void btnRegistrarMario_Click(object sender, EventArgs e)
        {
            if (textBoxUsernameMario.Text != "" && textBoxPassMario.Text != "") ;
            {
                if (textBoxPassMario.Text == textBoxRepPasswordMario.Text)
                {
                    if (!UtilizadorJaExistente(textBoxUsernameMario.Text))
                        RegistrarUtilizador(textBoxUsernameMario.Text, textBoxPassMario.Text);
                    else
                    {
                        MessageBox.Show("Utilizador ja existente! Insira novos dados");
                        textBoxUsernameMario.Text = "";
                        textBoxPassMario.Text = "";
                        textBoxRepPasswordMario.Text = "";
                        textBoxUsernameMario.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("As passwords não coincidem!");
                    textBoxPassMario.Text = "";
                    textBoxRepPasswordMario.Text = "";
                    textBoxPassMario.Focus();
                }
            }
        }
        private bool UtilizadorJaExistente(string user)

        {
            if (File.Exists(pathCd))
            {
                try
                {
                    string[] dadosUser = File.ReadAllLines(pathCd);
                    foreach (string linha in dadosUser)
                    {
                        string[] dadosUsr = linha.Split(':');
                        if (user == dadosUsr[0]) return true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                }
            }
            return false;
        }
        private void RegistrarUtilizador(string user, string pass)
        {
            try
            {
                string texto = user + ':' + pass;
                File.AppendAllText(pathCd, texto);
                MessageBox.Show("Dados do utilizador registrados com sucesso!");


            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex.Message);
            }
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
