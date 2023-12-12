using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace JogoDaMemoria
{
    public partial class Form1 : Form
    {
        static public bool soundON = false;
        static public bool soundOff = false;

        static public bool login = false;

        const int nCartas = 20;

        byte nCliques;
        byte restancesCt = nCartas / 2;
        Button cartaAnterior;
        public Form1()
        {
            InitializeComponent();
            buttonIniciar.Visible = false;
            buttonParar.Visible = false;
            buttonResetar.Visible = false;
            label1.Visible = false;
            buttonMostrar.Visible = false;
            SomOn.BackgroundImage = Properties.Resources.iconVolumeOff;
            button21.Visible = true;
            TemaAesthentic.Visible = false;
            btnTemasMario.Visible = false;
            JogarDeNovo.Visible = false;

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            FormTemas05 frm = new FormTemas05();
            frm.ShowDialog();
            if (login)
            {
                DistribuirCartas();
                AtribuirTags();
                buttonLogin.Visible = false;
                pictureBox1.Visible = false;
                buttonIniciar.Visible = true;
                buttonParar.Visible = true;
                buttonResetar.Visible = true;
                label1.Visible = true;
                buttonMostrar.Visible = true;
                button21.Visible = false;
                btnTemasMario.Visible = false;
                TemaAesthentic.Visible = false;
                JogarDeNovo.Visible = true;
               
            }
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            Ocultar();
            tsLabelData.Text = DateTime.Now.ToLongDateString();
            timer1.Enabled = true;
        }
        private void Ocultar()
        {
            foreach (Control x in this.Controls)
                if (x is Button && x.Tag.ToString() == "c")
                    x.Visible = false;
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            tsLabelHora.Text = DateTime.Now.ToLongTimeString();
        }

        private void buttonMostrar_Click(object sender, EventArgs e)
        {
            foreach (Control x in this.Controls)
                if (x is Button && x.Tag.ToString() != "o")
                {
                    string s = "_" + x.Tag.ToString();
                    object o = Properties.Resources.ResourceManager.GetObject(s);
                    x.BackgroundImage = (System.Drawing.Image)o;                                                    
               }
            Application.DoEvents();
            System.Threading.Thread.Sleep(500);

            foreach (Control x in this.Controls)
                if (x is Button && x.Tag.ToString() != "o")
                    x.BackgroundImage = Properties.Resources.Design_sem_nome_removebg_preview;

           // SoundPlayer som = new SoundPlayer(@"");
           // som.Play();
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            {
                Button cartaAtual = (sender as Button);
                string s = "_" + cartaAtual.Tag.ToString();
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
        }
        private void CompararCartas(Button cAnterior, Button cAtual)
        {
            Application.DoEvents();
            System.Threading.Thread.Sleep(600);
            if (cAnterior == cAtual)
            {
                MessageBox.Show("Selecionou a mesma carta");
                nCliques = 0;
                cAtual.BackgroundImage = Properties.Resources.Design_sem_nome_removebg_preview;

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
                    cAnterior.BackgroundImage = Properties.Resources.Design_sem_nome_removebg_preview;
                    cAtual.BackgroundImage = Properties.Resources.Design_sem_nome_removebg_preview;

                }

            }
        }

        private void VerificarSeGanhou()
        {

        }
        int h = 0, m = 0, s = 0;
        private void timer2_Tick(object sender, EventArgs e)
        {
            s++;
            if (s==60)
            {
                m++;
                s = 0;           
            }else if(m==60)
            {
                h++;
                m = 0;
            }
            label1.Text = $"{h}:{m}:{s}";
        }

        private void buttonIniciar_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }
        private void buttonParar_Click(object sender, EventArgs e)
        {
            timer2.Stop();
        }
        private void buttonResetar_Click(object sender, EventArgs e)
        {
            timer2.Dispose();
            h = 0;
            m = 0;
            s = 0;
            label1.Text = $"{h}:{m}:{s}";
        }
        private void SomOn_Click(object sender, EventArgs e)
        {
            Stream funk = Properties.Resources.SOM_JOGOMEMORIA__online_audio_converter_com_;
            System.Media.SoundPlayer sp = new System.Media.SoundPlayer(funk);

            if (soundON)
            {
                sp.Stop();
                soundON = false;
                SomOn.BackgroundImage = Properties.Resources.iconVolumeOff;
            }
            else
            {
                sp.PlayLooping();
                soundON = true;
                SomOn.BackgroundImage = Properties.Resources.music_sound_png1;
            }
        }

        private void SomOff_Click(object sender, EventArgs e)
        {
           
        }

        private void JogarDeNovo_Click_1(object sender, EventArgs e)
        {

            FormTemas05 frm5 = new FormTemas05();
            frm5.ShowDialog();
        }
    }
}


