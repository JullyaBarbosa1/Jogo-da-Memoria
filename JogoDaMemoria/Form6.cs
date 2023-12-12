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
    public partial class Form6 : Form
    {
        static public bool soundON = false;
        static public bool soundOff = false;

        static public bool login = false;
        static public bool Tcartas = false;

        const int numCartas = 32;

        byte nCliques;
        byte restancesCt = numCartas / 2;
        Button cartaAnterior;
        public Form6()
        {
            InitializeComponent();

           
        }
        private void Form6_Load(object sender, EventArgs e)
        {
            Ocultar();
            tsLabelDataD.Text = DateTime.Now.ToLongDateString();
            timer2.Enabled = true;
            TemaDisney.Visible = true;
            //SomOn.BackgroundImage = Properties.Resources.iconVolumeOff;
            buttonLoginDisney.Visible = true;
            pictureBoxDisney.Visible = true;
            JogardeNovoDisney.Visible = false;
            buttonMostrarDisney.Visible = false;
            label1.Visible = false;
            buttonIniciarDisney.Visible = false;
            buttonPararDisney.Visible = false;
            buttonResetarDisney.Visible = false;
            JogardeNovoDisney.Visible = false;
            pictureBoxTaparCartas.Visible = true;
        }
        private void Ocultar ()
        {
            if (login)
            {
                foreach (Control x in this.Controls)
                    if (x is Button && x.Tag.ToString() == "c")
                        x.Visible = false;
            }
        }
        private void buttonLoginDisney_Click(object sender, EventArgs e)
        {
            Form6Login frm6 = new Form6Login();
            frm6.ShowDialog();
            if (login)
            {
                DistribuirCartas();
                AtribuirTags();
                TemaDisney.Visible = true;
                buttonLoginDisney.Visible = false;
                pictureBoxDisney.Visible = false;
                buttonMostrarDisney.Visible = true;
                
            }
            if (Tcartas == true)
            {
                pictureBoxTaparCartas.Visible = false;
            }
        }
        private void DistribuirCartas()
        {
            foreach (Control x in this.Controls)
                if (x is Button && x.Tag.ToString() == "c")
                {
                    x.BackgroundImage = Properties.Resources.disney_costas;
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
                if (Array.IndexOf(tags, n) == -1)
                {
                    tags[i] = n;
                    i++;
                }
            }
            for (int j = 0; j < numCartas; j++)
                if (tags[j] > numCartas / 2)
                    tags[j] = tags[j] - (numCartas / 2);

            //for (int j = 0; j < numCartas; j++)
            //MessageBox.Show("tags[" + j + "]=" + tags[j]);
            i = 0;
            foreach (Control x in this.Controls)
                if (x is Button && x.Tag.ToString() == "c")
                {
                    x.Tag = tags[i];
                    i++;
                }
        }
       

        private void buttonMostrarDisney_Click(object sender, EventArgs e)
        {
            foreach (Control x in this.Controls)
                if (x is Button && x.Tag.ToString() != "o")
                {
                    string s = "D" + x.Tag.ToString();
                    object o = Properties.Resources.ResourceManager.GetObject(s);
                    x.BackgroundImage = (System.Drawing.Image)o;
                }
              
            Application.DoEvents();
            System.Threading.Thread.Sleep(500);

            foreach (Control x in this.Controls)
                if (x is Button && x.Tag.ToString() != "o")
                    x.BackgroundImage = Properties.Resources.disney_costas;

        }
        private void button1Disney_Click(object sender, EventArgs e)
        {
            Button cartaAtual = (sender as Button);
            string s = "D" + cartaAtual.Tag.ToString();
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
                cAtual.BackgroundImage = Properties.Resources.disney_costas;

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
                    cAnterior.BackgroundImage = Properties.Resources.disney_costas;
                    cAtual.BackgroundImage = Properties.Resources.disney_costas;

                }
            }
        }
        private void VerificarSeGanhou()
        {

        }
        private void JogardeNovoDisney_Click(object sender, EventArgs e)
        {
            FormTemas05 form05 = new FormTemas05();
            form05.ShowDialog();
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

        
        int h = 0, m = 0, s = 0;
        private void buttonIniciarDisney_Click(object sender, EventArgs e)
        {
            timer3.Start();
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
            label1.Text = $"{h}:{m}:{s}";
        }

        private void buttonLoginDisney_Click_1(object sender, EventArgs e)
        {
            Form6Login frm6 = new Form6Login();
            frm6.ShowDialog();
            if (login)
            {
                DistribuirCartas();
                AtribuirTags();
                buttonLoginDisney.Visible = false;
                pictureBoxDisney.Visible = false;
                buttonMostrarDisney.Visible = true;
                TemaDisney.Visible = false;
                JogardeNovoDisney.Visible = true;

            }
        }

        private void buttonPararDisney_Click(object sender, EventArgs e)
        {
            timer3.Stop();
        }       
     
        private void buttonResetarDisney_Click(object sender, EventArgs e)
        {
            timer3.Dispose();
            h = 0;
            m = 0;
            s = 0;
            label1.Text = $"{h}:{m}:{s}";
        }

        
    }
}
