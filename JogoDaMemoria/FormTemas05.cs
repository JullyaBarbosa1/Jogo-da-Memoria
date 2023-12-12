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
    public partial class FormTemas05 : Form
    {
        public FormTemas05()
        {
            InitializeComponent();
            TemaAesthentic.Visible = true;
        }

        private void btnTemasMario_Click(object sender, EventArgs e)
        {
            Form02 frm02 = new Form02();
            frm02.ShowDialog();
        }

        private void TemaAesthentic_Click(object sender, EventArgs e)
        {
            
            FormLogin form1 = new FormLogin();
            form1.ShowDialog();
            this.Close();
        }

        private void TemaDisney_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
                form6.ShowDialog();
            this.Close();
        }

        private void FormTemas05_Load(object sender, EventArgs e)
        {
           
        }
       
        
    }
}
