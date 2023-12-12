namespace JogoDaMemoria
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonMostrar = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsLabelAutor = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsLabelData = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsLabelHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.buttonParar = new System.Windows.Forms.Button();
            this.buttonResetar = new System.Windows.Forms.Button();
            this.buttonIniciar = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.TemaAesthentic = new System.Windows.Forms.Button();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.btnTemasMario = new System.Windows.Forms.Button();
            this.SomOn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.JogarDeNovo = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonMostrar
            // 
            this.buttonMostrar.BackColor = System.Drawing.Color.Transparent;
            this.buttonMostrar.FlatAppearance.BorderSize = 0;
            this.buttonMostrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMostrar.Font = new System.Drawing.Font("Wigglye", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMostrar.ForeColor = System.Drawing.Color.Black;
            this.buttonMostrar.Location = new System.Drawing.Point(304, 12);
            this.buttonMostrar.Name = "buttonMostrar";
            this.buttonMostrar.Size = new System.Drawing.Size(185, 46);
            this.buttonMostrar.TabIndex = 21;
            this.buttonMostrar.Tag = "o";
            this.buttonMostrar.Text = "Mostrar";
            this.buttonMostrar.UseVisualStyleBackColor = false;
            this.buttonMostrar.Click += new System.EventHandler(this.buttonMostrar_Click);
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
            this.statusStrip1.Location = new System.Drawing.Point(0, 462);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(240, 22);
            this.statusStrip1.TabIndex = 45;
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
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 31);
            this.label1.TabIndex = 61;
            this.label1.Text = "00:00.00";
            // 
            // buttonParar
            // 
            this.buttonParar.BackColor = System.Drawing.Color.Red;
            this.buttonParar.Location = new System.Drawing.Point(25, 172);
            this.buttonParar.Name = "buttonParar";
            this.buttonParar.Size = new System.Drawing.Size(58, 23);
            this.buttonParar.TabIndex = 62;
            this.buttonParar.Tag = "o";
            this.buttonParar.Text = "Parar:";
            this.buttonParar.UseVisualStyleBackColor = false;
            this.buttonParar.Click += new System.EventHandler(this.buttonParar_Click);
            // 
            // buttonResetar
            // 
            this.buttonResetar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonResetar.Location = new System.Drawing.Point(25, 201);
            this.buttonResetar.Name = "buttonResetar";
            this.buttonResetar.Size = new System.Drawing.Size(58, 23);
            this.buttonResetar.TabIndex = 63;
            this.buttonResetar.Tag = "o";
            this.buttonResetar.Text = "Resetar:";
            this.buttonResetar.UseVisualStyleBackColor = false;
            this.buttonResetar.Click += new System.EventHandler(this.buttonResetar_Click);
            // 
            // buttonIniciar
            // 
            this.buttonIniciar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonIniciar.Location = new System.Drawing.Point(25, 143);
            this.buttonIniciar.Name = "buttonIniciar";
            this.buttonIniciar.Size = new System.Drawing.Size(58, 23);
            this.buttonIniciar.TabIndex = 64;
            this.buttonIniciar.Tag = "o";
            this.buttonIniciar.Text = "Iniciar:";
            this.buttonIniciar.UseVisualStyleBackColor = false;
            this.buttonIniciar.Click += new System.EventHandler(this.buttonIniciar_Click);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // button16
            // 
            this.button16.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button16.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button16.FlatAppearance.BorderSize = 3;
            this.button16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button16.Location = new System.Drawing.Point(171, 352);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(88, 90);
            this.button16.TabIndex = 89;
            this.button16.Tag = "c";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button17
            // 
            this.button17.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button17.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button17.FlatAppearance.BorderSize = 3;
            this.button17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button17.Location = new System.Drawing.Point(266, 353);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(88, 90);
            this.button17.TabIndex = 88;
            this.button17.Tag = "c";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button18
            // 
            this.button18.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button18.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button18.FlatAppearance.BorderSize = 3;
            this.button18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button18.Location = new System.Drawing.Point(359, 353);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(88, 90);
            this.button18.TabIndex = 87;
            this.button18.Tag = "c";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button19
            // 
            this.button19.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button19.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button19.FlatAppearance.BorderSize = 3;
            this.button19.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button19.Location = new System.Drawing.Point(453, 353);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(88, 90);
            this.button19.TabIndex = 86;
            this.button19.Tag = "c";
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button20
            // 
            this.button20.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button20.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button20.FlatAppearance.BorderSize = 3;
            this.button20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button20.Location = new System.Drawing.Point(547, 353);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(88, 90);
            this.button20.TabIndex = 85;
            this.button20.Tag = "c";
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button11
            // 
            this.button11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button11.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button11.FlatAppearance.BorderSize = 3;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Location = new System.Drawing.Point(171, 256);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(88, 90);
            this.button11.TabIndex = 84;
            this.button11.Tag = "c";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button12
            // 
            this.button12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button12.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button12.FlatAppearance.BorderSize = 3;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Location = new System.Drawing.Point(265, 257);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(88, 90);
            this.button12.TabIndex = 83;
            this.button12.Tag = "c";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button13
            // 
            this.button13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button13.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button13.FlatAppearance.BorderSize = 3;
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button13.Location = new System.Drawing.Point(359, 256);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(88, 90);
            this.button13.TabIndex = 82;
            this.button13.Tag = "c";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button14
            // 
            this.button14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button14.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button14.FlatAppearance.BorderSize = 3;
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button14.Location = new System.Drawing.Point(453, 256);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(88, 90);
            this.button14.TabIndex = 81;
            this.button14.Tag = "c";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button15
            // 
            this.button15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button15.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button15.FlatAppearance.BorderSize = 3;
            this.button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button15.Location = new System.Drawing.Point(547, 256);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(88, 90);
            this.button15.TabIndex = 80;
            this.button15.Tag = "c";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button6
            // 
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button6.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button6.FlatAppearance.BorderSize = 3;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Location = new System.Drawing.Point(171, 160);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(88, 90);
            this.button6.TabIndex = 79;
            this.button6.Tag = "c";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button7
            // 
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button7.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button7.FlatAppearance.BorderSize = 3;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Location = new System.Drawing.Point(268, 160);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(88, 90);
            this.button7.TabIndex = 78;
            this.button7.Tag = "c";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button8
            // 
            this.button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button8.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button8.FlatAppearance.BorderSize = 3;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Location = new System.Drawing.Point(362, 161);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(88, 90);
            this.button8.TabIndex = 77;
            this.button8.Tag = "c";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button9
            // 
            this.button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button9.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button9.FlatAppearance.BorderSize = 3;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Location = new System.Drawing.Point(453, 160);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(88, 90);
            this.button9.TabIndex = 76;
            this.button9.Tag = "c";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button10
            // 
            this.button10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button10.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button10.FlatAppearance.BorderSize = 3;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Location = new System.Drawing.Point(547, 161);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(88, 90);
            this.button10.TabIndex = 75;
            this.button10.Tag = "c";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button1.FlatAppearance.BorderSize = 3;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(171, 64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 90);
            this.button1.TabIndex = 74;
            this.button1.Tag = "c";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.SomOn_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button2.FlatAppearance.BorderSize = 3;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(265, 64);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 90);
            this.button2.TabIndex = 73;
            this.button2.Tag = "c";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button3
            // 
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button3.FlatAppearance.BorderSize = 3;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(359, 64);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(88, 90);
            this.button3.TabIndex = 72;
            this.button3.Tag = "c";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button4
            // 
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button4.FlatAppearance.BorderSize = 3;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(453, 64);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(88, 90);
            this.button4.TabIndex = 71;
            this.button4.Tag = "c";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button5
            // 
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button5.FlatAppearance.BorderSize = 3;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(547, 65);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(88, 90);
            this.button5.TabIndex = 70;
            this.button5.Tag = "c";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // TemaAesthentic
            // 
            this.TemaAesthentic.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TemaAesthentic.BackgroundImage")));
            this.TemaAesthentic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TemaAesthentic.Location = new System.Drawing.Point(653, 135);
            this.TemaAesthentic.Name = "TemaAesthentic";
            this.TemaAesthentic.Size = new System.Drawing.Size(150, 75);
            this.TemaAesthentic.TabIndex = 90;
            this.TemaAesthentic.Tag = "o";
            this.TemaAesthentic.UseVisualStyleBackColor = true;
            // 
            // buttonLogin
            // 
            this.buttonLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonLogin.BackColor = System.Drawing.Color.Transparent;
            this.buttonLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonLogin.BackgroundImage")));
            this.buttonLogin.FlatAppearance.BorderSize = 0;
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.ForeColor = System.Drawing.Color.Black;
            this.buttonLogin.Location = new System.Drawing.Point(293, 356);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(258, 84);
            this.buttonLogin.TabIndex = 69;
            this.buttonLogin.Tag = "o";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // button21
            // 
            this.button21.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button21.BackColor = System.Drawing.Color.Transparent;
            this.button21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button21.BackgroundImage")));
            this.button21.FlatAppearance.BorderSize = 0;
            this.button21.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button21.Font = new System.Drawing.Font("Pixar", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button21.Location = new System.Drawing.Point(288, 64);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(274, 105);
            this.button21.TabIndex = 68;
            this.button21.Tag = "o";
            this.button21.UseVisualStyleBackColor = false;
            // 
            // btnTemasMario
            // 
            this.btnTemasMario.BackColor = System.Drawing.Color.Transparent;
            this.btnTemasMario.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTemasMario.BackgroundImage")));
            this.btnTemasMario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTemasMario.Location = new System.Drawing.Point(669, 53);
            this.btnTemasMario.Name = "btnTemasMario";
            this.btnTemasMario.Size = new System.Drawing.Size(134, 73);
            this.btnTemasMario.TabIndex = 67;
            this.btnTemasMario.Tag = "o";
            this.btnTemasMario.UseVisualStyleBackColor = false;
            // 
            // SomOn
            // 
            this.SomOn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.SomOn.BackColor = System.Drawing.Color.Transparent;
            this.SomOn.BackgroundImage = global::JogoDaMemoria.Properties.Resources.music_sound_png1;
            this.SomOn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SomOn.FlatAppearance.BorderSize = 0;
            this.SomOn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SomOn.Location = new System.Drawing.Point(724, 413);
            this.SomOn.Name = "SomOn";
            this.SomOn.Size = new System.Drawing.Size(43, 40);
            this.SomOn.TabIndex = 65;
            this.SomOn.Tag = "o";
            this.SomOn.UseVisualStyleBackColor = false;
            this.SomOn.Click += new System.EventHandler(this.SomOn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(346, 188);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(143, 141);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "o";
            // 
            // JogarDeNovo
            // 
            this.JogarDeNovo.BackColor = System.Drawing.Color.Transparent;
            this.JogarDeNovo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("JogarDeNovo.BackgroundImage")));
            this.JogarDeNovo.FlatAppearance.BorderSize = 0;
            this.JogarDeNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.JogarDeNovo.Font = new System.Drawing.Font("Pixar", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JogarDeNovo.Location = new System.Drawing.Point(288, 282);
            this.JogarDeNovo.Name = "JogarDeNovo";
            this.JogarDeNovo.Size = new System.Drawing.Size(258, 108);
            this.JogarDeNovo.TabIndex = 92;
            this.JogarDeNovo.Tag = "o";
            this.JogarDeNovo.UseVisualStyleBackColor = false;
            this.JogarDeNovo.Click += new System.EventHandler(this.JogarDeNovo_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(829, 484);
            this.Controls.Add(this.TemaAesthentic);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.button21);
            this.Controls.Add(this.btnTemasMario);
            this.Controls.Add(this.SomOn);
            this.Controls.Add(this.buttonIniciar);
            this.Controls.Add(this.buttonResetar);
            this.Controls.Add(this.buttonParar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonMostrar);
            this.Controls.Add(this.JogarDeNovo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "c";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.button1_Click_1);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonMostrar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsLabelAutor;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel tsLabelData;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel tsLabelHora;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonParar;
        private System.Windows.Forms.Button buttonResetar;
        private System.Windows.Forms.Button buttonIniciar;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button SomOn;
        private System.Windows.Forms.Button btnTemasMario;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button TemaAesthentic;
        private System.Windows.Forms.Button JogarDeNovo;
    }
}

