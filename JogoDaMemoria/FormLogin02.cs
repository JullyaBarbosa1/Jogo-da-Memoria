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
    public partial class FormLogin02 : Form
    {
        string pathCd = "credenciais.txt";
        public FormLogin02()
        {
            InitializeComponent();
        }

        private void FormLogin02_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form1.login = false;
            string user = textBoxUsernameMario.Text;
            string pass = textBoxPassMario.Text;
            if (textBoxUsernameMario.Text == "JU" && textBoxPassMario.Text == "JU")
                Form1.login = true;
            else
                Form1.login = VerificarLogin(user, pass);
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

        private void button2Mario_Click(object sender, EventArgs e)
        {
            Form02.login = false;
            this.Close();
        }

        private void linkLabel1Mario_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (linkLabel1Mario.Text == "Mostrar")
            {
                textBoxPassMario.UseSystemPasswordChar = false;
                linkLabel1Mario.Text = "Ocultar";

            }
            else
            {
                textBoxPassMario.UseSystemPasswordChar = true;
                linkLabel1Mario.Text = "Mostrar";
            }

        }

        private void linkLNovoUtilzMario_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormNovoUtilizador02 frm02 = new FormNovoUtilizador02();
            frm02.ShowDialog();
            textBoxUsernameMario.Focus();
        }

        private void EntrarMario_Click(object sender, EventArgs e)
        {
            Form02.login = false;
            string user = textBoxUsernameMario.Text;
            string pass = textBoxPassMario.Text;
            if (textBoxUsernameMario.Text == "JU" && textBoxPassMario.Text == "JU")
                Form02.login = true;
            else
                Form02.login = VerificarLogin(user, pass);
            this.Close();
        }
    }
}
