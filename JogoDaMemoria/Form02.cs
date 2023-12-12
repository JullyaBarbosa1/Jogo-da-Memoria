using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace JogoDaMemoria
{
    public partial class Form02 : Form
    {
        static public bool soundON = false;
        static public bool soundOff = false;

        static public bool login = false;

        const int numCartas = 28;

        byte nCliques;
        byte restancesCt = numCartas / 2;
        Button cartaAnterior;

         public Form02()
        {
            InitializeComponent();

        }

        

        private void Form02_Load(object sender, EventArgs e)
        {
            
            buttonJogarMario.Visible = false;
            buttonMostrarMario.Visible = false;
            Ocultar();
            tsLabelDataMario.Text = DateTime.Now.ToLongDateString();
            timer2.Enabled = true;
        }
        
        private void Ocultar()
        {
            foreach (Control x in this.Controls)
                if (x is Button && x.Tag.ToString() == "c")
                    x.Visible = false;
        }

        private void buttonLoginMario_Click(object sender, EventArgs e)
        {
            FormLogin02 frm02 = new FormLogin02();
            frm02.ShowDialog();
            if (login)
            {
                DistribuirCartas();
                AtribuirTags();
                buttonLoginMario.Visible = false;             
                pictureBox2.Visible = false;
                buttonMostrarMario.Visible = true;           
                buttonNomeM.Visible = false;
                buttonJogarMario.Visible = true;
                
            }
        }
        private void DistribuirCartas()
        {
            foreach (Control x in this.Controls)
                if (x is Button && x.Tag.ToString() == "c")
                {
                    x.BackgroundImage = Properties.Resources.MarioCostasCarta;
                    x.Visible = true;
                }
        }
        private void AtribuirTags()
        {
            int[] tags = new int[numCartas];
            Random rnd = new Random();
            int n;
            int i = 0;
            while (i < numCartas)
            {
                n = rnd.Next(1, numCartas + 1);
                if (Array.IndexOf(tags, n) == -01)
                {
                    tags[i] = n;
                    i++;
                }
            }

            for (int j = 0; j < numCartas; j++)
                if (tags[j] > numCartas / 2)
                    tags[j] = tags[j] - (numCartas / 2);

            //for (int j = 0; j < nCartas; j++)
            //MessageBox.Show("tags[" + j + "]=" + tags[j]);
            i = 0;
            foreach (Control x in this.Controls)
                if (x is Button && x.Tag.ToString() == "c")
                {
                    x.Tag = tags[i];
                    i++;
                }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            tsLabelHoraMario.Text = DateTime.Now.ToLongTimeString();

        }

        private void buttonMostrarMario_Click(object sender, EventArgs e)
        {
            foreach (Control x in this.Controls)
                if (x is Button && x.Tag.ToString() != "o")
                {
                    string s = "M" + x.Tag.ToString();
                    object o = Properties.Resources.ResourceManager.GetObject(s);
                    x.BackgroundImage = (System.Drawing.Image)o;
                }

            Application.DoEvents();
            System.Threading.Thread.Sleep(500);

            foreach (Control x in this.Controls)
                if (x is Button && x.Tag.ToString() != "o")
                    x.BackgroundImage = Properties.Resources.MarioCostasCarta;

            //SoundPlayer som = new SoundPlayer(@"");
            //som.Play();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button cartaAtual = (sender as Button);
            string s = "M" + cartaAtual.Tag.ToString();
            object o = Properties.Resources.ResourceManager.GetObject(s);
            cartaAtual.BackgroundImage = (System.Drawing.Image)o;

            if (nCliques == 0)
            {
                cartaAnterior = cartaAtual;
                nCliques++;

            }
            else
                CompararCartas(cartaAnterior, cartaAtual);
        }
        private void CompararCartas(Button cAnterior, Button cAtual)
        {
            Application.DoEvents();
            System.Threading.Thread.Sleep(600);
            if (cAnterior == cAtual)
            {
                MessageBox.Show("Selecionou a mesma carta");
                nCliques = 0;
                cAtual.BackgroundImage = Properties.Resources.MarioCostasCarta;

            }
            else
            {
                if (cAtual.Tag.ToString() == cAnterior.Tag.ToString())
                {
                    restancesCt--;
                    nCliques = 0;
                    cAnterior.Visible = false;
                    cAtual.Visible = false;
                    VerificarSeGanhou();
                }
                else
                {
                    nCliques = 0;
                    cAnterior.BackgroundImage = Properties.Resources.MarioCostasCarta;
                    cAtual.BackgroundImage = Properties.Resources.MarioCostasCarta;

                }
            }
        }
        private void VerificarSeGanhou()
        {

        }
        int h = 0, m = 0, s = 0;

       

        private void buttonJogarMario_Click(object sender, EventArgs e)
        {
            FormTemas05 frm5 = new FormTemas05();
            frm5.ShowDialog();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            s++;
            if (s == 60)
            {
                m++;
                s = 0;
            }
            else if (m == 60)
            {
                h++;
                m = 0;
            }
            //label1.Text = $"{h}:{m}:{s}";
        }
    }
}
