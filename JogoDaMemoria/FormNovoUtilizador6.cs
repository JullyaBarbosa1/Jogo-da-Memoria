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
    public partial class FormNovoUtilizador6 : Form
    {
        string pathCd = "credenciais.txt";
        public FormNovoUtilizador6()
        {
            InitializeComponent();
        }

        private void buttonRegistrarD_Click(object sender, EventArgs e)
        {
            if (textBoxUsernameDisney.Text != "" && textBoxPassDisney.Text != "") ;
            {
                if (textBoxPassDisney.Text == textBoxRepPasswordDisney.Text)
                {
                    if (!UtilizadorJaExistente(textBoxUsernameDisney.Text))
                        RegistrarUtilizador(textBoxUsernameDisney.Text, textBoxPassDisney.Text);
                    else
                    {
                        MessageBox.Show("Utilizador ja existente! Insira novos dados");
                        textBoxUsernameDisney.Text = "";
                        textBoxPassDisney.Text = "";
                        textBoxRepPasswordDisney.Text = "";
                        textBoxUsernameDisney.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("As passwords não coincidem!");
                    textBoxPassDisney.Text = "";
                    textBoxRepPasswordDisney.Text = "";
                    textBoxPassDisney.Focus();
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

        private void buttonCancelarD_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
