namespace JogoDaMemoria
{
    partial class FormTemas05
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTemas05));
            this.btnTemasMario = new System.Windows.Forms.Button();
            this.TemaDisney = new System.Windows.Forms.Button();
            this.buttonMostrar = new System.Windows.Forms.Button();
            this.TemaAesthentic = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsLabelAutor = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsLabelData = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsLabelHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTemasMario
            // 
            this.btnTemasMario.BackColor = System.Drawing.Color.Transparent;
            this.btnTemasMario.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTemasMario.BackgroundImage")));
            this.btnTemasMario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTemasMario.FlatAppearance.BorderSize = 0;
            this.btnTemasMario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTemasMario.Location = new System.Drawing.Point(273, 176);
            this.btnTemasMario.Name = "btnTemasMario";
            this.btnTemasMario.Size = new System.Drawing.Size(162, 92);
            this.btnTemasMario.TabIndex = 68;
            this.btnTemasMario.Tag = "o";
            this.btnTemasMario.UseVisualStyleBackColor = false;
            this.btnTemasMario.Click += new System.EventHandler(this.btnTemasMario_Click);
            // 
            // TemaDisney
            // 
            this.TemaDisney.AccessibleName = "";
            this.TemaDisney.BackColor = System.Drawing.Color.Transparent;
            this.TemaDisney.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TemaDisney.BackgroundImage")));
            this.TemaDisney.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TemaDisney.FlatAppearance.BorderSize = 0;
            this.TemaDisney.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TemaDisney.Font = new System.Drawing.Font("Pixar", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TemaDisney.Location = new System.Drawing.Point(58, 176);
            this.TemaDisney.Name = "TemaDisney";
            this.TemaDisney.Size = new System.Drawing.Size(258, 118);
            this.TemaDisney.TabIndex = 73;
            this.TemaDisney.Tag = "o";
            this.TemaDisney.UseVisualStyleBackColor = false;
            this.TemaDisney.Click += new System.EventHandler(this.TemaDisney_Click);
            // 
            // buttonMostrar
            // 
            this.buttonMostrar.BackColor = System.Drawing.Color.Transparent;
            this.buttonMostrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonMostrar.BackgroundImage")));
            this.buttonMostrar.FlatAppearance.BorderSize = 0;
            this.buttonMostrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMostrar.Font = new System.Drawing.Font("Pixar", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMostrar.Location = new System.Drawing.Point(209, 37);
            this.buttonMostrar.Name = "buttonMostrar";
            this.buttonMostrar.Size = new System.Drawing.Size(258, 106);
            this.buttonMostrar.TabIndex = 71;
            this.buttonMostrar.Tag = "o";
            this.buttonMostrar.UseVisualStyleBackColor = false;
            // 
            // TemaAesthentic
            // 
            this.TemaAesthentic.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TemaAesthentic.BackgroundImage")));
            this.TemaAesthentic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TemaAesthentic.FlatAppearance.BorderSize = 0;
            this.TemaAesthentic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TemaAesthentic.Location = new System.Drawing.Point(441, 166);
            this.TemaAesthentic.Name = "TemaAesthentic";
            this.TemaAesthentic.Size = new System.Drawing.Size(150, 139);
            this.TemaAesthentic.TabIndex = 69;
            this.TemaAesthentic.UseVisualStyleBackColor = true;
            this.TemaAesthentic.Click += new System.EventHandler(this.TemaAesthentic_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.statusStrip1.BackColor = System.Drawing.Color.Transparent;
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsLabelAutor,
            this.toolStripStatusLabel1,
            this.tsLabelData,
            this.toolStripStatusLabel2,
            this.tsLabelHora});
            this.statusStrip1.Location = new System.Drawing.Point(9, 376);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(240, 22);
            this.statusStrip1.TabIndex = 74;
            this.statusStrip1.Tag = "o";
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsLabelAutor
            // 
            this.tsLabelAutor.Name = "tsLabelAutor";
            this.tsLabelAutor.Size = new System.Drawing.Size(139, 17);
            this.tsLabelAutor.Text = "©Jullya Maria A. Barbosa";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(10, 17);
            this.toolStripStatusLabel1.Text = "|";
            // 
            // tsLabelData
            // 
            this.tsLabelData.Name = "tsLabelData";
            this.tsLabelData.Size = new System.Drawing.Size(31, 17);
            this.tsLabelData.Text = "Data";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(10, 17);
            this.toolStripStatusLabel2.Text = "|";
            // 
            // tsLabelHora
            // 
            this.tsLabelHora.Name = "tsLabelHora";
            this.tsLabelHora.Size = new System.Drawing.Size(33, 17);
            this.tsLabelHora.Text = "Hora";
            // 
            // timer1
            // 
            this.timer1.Tag = "o";
            // 
            // FormTemas05
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(684, 398);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.TemaAesthentic);
            this.Controls.Add(this.btnTemasMario);
            this.Controls.Add(this.buttonMostrar);
            this.Controls.Add(this.TemaDisney);
            this.Name = "FormTemas05";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormTemas05";
            this.Load += new System.EventHandler(this.FormTemas05_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTemasMario;
        private System.Windows.Forms.Button TemaAesthentic;
        private System.Windows.Forms.Button buttonMostrar;
        private System.Windows.Forms.Button TemaDisney;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsLabelAutor;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel tsLabelData;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel tsLabelHora;
        private System.Windows.Forms.Timer timer1;
    }
}