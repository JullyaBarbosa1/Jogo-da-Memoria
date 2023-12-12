using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoDaMemoria
{
    public partial class Form6Login : Form
    {
        string pathCd = "credenciais.txt";
        public Form6Login()
        {
            InitializeComponent();
        }

        private void Form6Login_Load(object sender, EventArgs e)
        {
            
        }
        private void buttonEntrarD_Click(object sender, EventArgs e)
        {
            Form6.Tcartas = true;

            Form6.login = false;
            string user = textBoxUsernameD.Text;
            string pass = textBoxPassD.Text;
            if (textBoxUsernameD.Text == "JU" && textBoxPassD.Text == "JU")
                Form6.login = true;
            else
                Form6.login = VerificarLogin(user, pass);
            this.Close();
        }
        private bool VerificarLogin(string us, string ps)
        {
            if (File.Exists(pathCd))
            {
                string[] users = File.ReadAllLines(pathCd);
                foreach (string s in users)
                {
                    string[] dataUser = s.Split(':');
                    if (us == dataUser[0] && ps == dataUser[1])
                    {
                        MessageBox.Show("Seja bem vindo !!" + us);
                        return true;
                    }
                    MessageBox.Show("Utilizador não existente");
                }
            }
            return false;
        }
        private void button2Disney(object sender, EventArgs e)
        {
            Form6.login = false;
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (linkLabel1.Text == "Mostrar")
            {
                textBoxPassD.UseSystemPasswordChar = false;
                linkLabel1.Text = "Ocultar";

            }
            else
            {
                textBoxPassD.UseSystemPasswordChar = true;
                linkLabel1.Text = "Mostrar";
            }
        }

        private void linkNovoUtilizadorLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormNovoUtilizador6 frm = new FormNovoUtilizador6();
            frm.ShowDialog();
            textBoxUsernameD.Focus();
        }
    }
}
