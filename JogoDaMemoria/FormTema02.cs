using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoDaMemoria
{
    public partial class FormTema02 : Form
    {

        static public bool soundON = false;
        static public bool soundOff = false;

        static public bool login = false;

        const int nCartas = 20;

        byte nCliques;
        byte restancesCt = nCartas / 2;
        Button cartaAnterior;

        public FormTema02()
        {
            InitializeComponent();
            
        }

        private void FormTema02_Load(object sender, EventArgs e)
        {
           

        }
        private void Ocultar()
        {
            foreach (Control x in this.Controls)
                if (x is Button && x.Tag.ToString() == "c")
                    x.Visible = false;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            FormLogin frm = new FormLogin();
            frm.ShowDialog();
            if (login)
            {
                DistribuirCartas();
                AtribuirTags();
                buttonLogin.Visible = false;
                buttonJogar.Visible = false;
                pictureBox1.Visible = false;
                label1.Visible = true;
                buttonMostrar.Visible = true;


            }
        }
        private void DistribuirCartas()
        {
            foreach (Control x in this.Controls)
                if (x is Button && x.Tag.ToString() == "c")
                {
                    x.BackgroundImage = Properties.Resources.Design_sem_nome_removebg_preview;
                    x.Visible = true;
                }
        }
        private void AtribuirTags()
        {
            int[] tags = new int[nCartas];
            Random rnd = new Random();
            int n;
            int i = 0;
            while (i < nCartas)
            {
                n = rnd.Next(1, nCartas + 1);
                if (Array.IndexOf(tags, n) == -1)
                {
                    tags[i] = n;
                    i++;
                }
            }
            for (int j = 0; j < nCartas; j++)
                if (tags[j] > nCartas / 2)
                    tags[j] = tags[j] - (nCartas / 2);

            i = 0;
            foreach (Control x in this.Controls)
                if (x is Button && x.Tag.ToString() == "c")
                {
                    x.Tag = tags[i];
                    i++;
                }
        }
        
    }
}
