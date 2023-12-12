using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace JogoDaMemoria
{
    public partial class FormLogin : Form
    {
        string pathCd = "credenciais.txt";
        public FormLogin()
        {
            InitializeComponent();
            
        }
        

        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.login = false;
            string user = textBoxUsername.Text;
            string pass = textBoxPass.Text;
            if (textBoxUsername.Text == "J" && textBoxPass.Text == "J")
                Form1.login = true;
            else
                Form1.login= VerificarLogin(user, pass);           
            this.Close();        
        }
        private bool VerificarLogin (string us, string ps)
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

        private void button2_Click(object sender, EventArgs e)
        {
            Form1.login = false;
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(linkLabel1.Text=="Mostrar")
            {
                textBoxPass.UseSystemPasswordChar = false;
                linkLabel1.Text = "Ocultar";

            }
            else
            {
                textBoxPass.UseSystemPasswordChar = true;
                linkLabel1.Text = "Mostrar";
            }
        }

        private void linkLNovoUtilz_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormNovoUtilizador frm = new FormNovoUtilizador();
            frm.ShowDialog();
            textBoxUsername.Focus();

        }
    }
}
