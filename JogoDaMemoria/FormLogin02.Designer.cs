namespace JogoDaMemoria
{
    partial class FormLogin02
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin02));
            this.linkLNovoUtilzMario = new System.Windows.Forms.LinkLabel();
            this.button2Mario = new System.Windows.Forms.Button();
            this.EntrarMario = new System.Windows.Forms.Button();
            this.linkLabel1Mario = new System.Windows.Forms.LinkLabel();
            this.textBoxPassMario = new System.Windows.Forms.TextBox();
            this.textBoxUsernameMario = new System.Windows.Forms.TextBox();
            this.buttonNomeM = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // linkLNovoUtilzMario
            // 
            this.linkLNovoUtilzMario.AutoSize = true;
            this.linkLNovoUtilzMario.Location = new System.Drawing.Point(368, 250);
            this.linkLNovoUtilzMario.Name = "linkLNovoUtilzMario";
            this.linkLNovoUtilzMario.Size = new System.Drawing.Size(102, 13);
            this.linkLNovoUtilzMario.TabIndex = 13;
            this.linkLNovoUtilzMario.TabStop = true;
            this.linkLNovoUtilzMario.Text = "Criar novo utilizador ";
            this.linkLNovoUtilzMario.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLNovoUtilzMario_LinkClicked);
            // 
            // button2Mario
            // 
            this.button2Mario.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2Mario.ForeColor = System.Drawing.Color.Red;
            this.button2Mario.Location = new System.Drawing.Point(351, 309);
            this.button2Mario.Name = "button2Mario";
            this.button2Mario.Size = new System.Drawing.Size(101, 35);
            this.button2Mario.TabIndex = 12;
            this.button2Mario.Text = "Cancelar";
            this.button2Mario.UseVisualStyleBackColor = true;
            this.button2Mario.Click += new System.EventHandler(this.button2Mario_Click);
            // 
            // EntrarMario
            // 
            this.EntrarMario.FlatAppearance.BorderSize = 3;
            this.EntrarMario.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EntrarMario.ForeColor = System.Drawing.Color.Red;
            this.EntrarMario.Location = new System.Drawing.Point(145, 309);
            this.EntrarMario.Name = "EntrarMario";
            this.EntrarMario.Size = new System.Drawing.Size(82, 35);
            this.EntrarMario.TabIndex = 11;
            this.EntrarMario.Text = "Entrar";
            this.EntrarMario.UseVisualStyleBackColor = true;
            this.EntrarMario.Click += new System.EventHandler(this.EntrarMario_Click);
            // 
            // linkLabel1Mario
            // 
            this.linkLabel1Mario.AutoSize = true;
            this.linkLabel1Mario.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1Mario.Location = new System.Drawing.Point(368, 286);
            this.linkLabel1Mario.Name = "linkLabel1Mario";
            this.linkLabel1Mario.Size = new System.Drawing.Size(42, 13);
            this.linkLabel1Mario.TabIndex = 10;
            this.linkLabel1Mario.TabStop = true;
            this.linkLabel1Mario.Text = "Mostrar";
            this.linkLabel1Mario.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1Mario_LinkClicked);
            // 
            // textBoxPassMario
            // 
            this.textBoxPassMario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassMario.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxPassMario.Location = new System.Drawing.Point(196, 275);
            this.textBoxPassMario.Name = "textBoxPassMario";
            this.textBoxPassMario.Size = new System.Drawing.Size(166, 29);
            this.textBoxPassMario.TabIndex = 9;
            this.textBoxPassMario.Tag = "c";
            this.textBoxPassMario.Text = "Password";
            this.textBoxPassMario.UseSystemPasswordChar = true;
            // 
            // textBoxUsernameMario
            // 
            this.textBoxUsernameMario.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textBoxUsernameMario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsernameMario.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxUsernameMario.Location = new System.Drawing.Point(196, 239);
            this.textBoxUsernameMario.Multiline = true;
            this.textBoxUsernameMario.Name = "textBoxUsernameMario";
            this.textBoxUsernameMario.Size = new System.Drawing.Size(166, 30);
            this.textBoxUsernameMario.TabIndex = 7;
            this.textBoxUsernameMario.Tag = "c";
            this.textBoxUsernameMario.Text = "username";
            // 
            // buttonNomeM
            // 
            this.buttonNomeM.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonNomeM.BackColor = System.Drawing.Color.Transparent;
            this.buttonNomeM.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonNomeM.BackgroundImage")));
            this.buttonNomeM.FlatAppearance.BorderSize = 0;
            this.buttonNomeM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNomeM.Font = new System.Drawing.Font("Pixar", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNomeM.Location = new System.Drawing.Point(150, -21);
            this.buttonNomeM.Name = "buttonNomeM";
            this.buttonNomeM.Size = new System.Drawing.Size(260, 97);
            this.buttonNomeM.TabIndex = 110;
            this.buttonNomeM.Tag = "o";
            this.buttonNomeM.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(196, 70);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(166, 163);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // FormLogin02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Brown;
            this.ClientSize = new System.Drawing.Size(576, 345);
            this.Controls.Add(this.buttonNomeM);
            this.Controls.Add(this.linkLNovoUtilzMario);
            this.Controls.Add(this.button2Mario);
            this.Controls.Add(this.EntrarMario);
            this.Controls.Add(this.linkLabel1Mario);
            this.Controls.Add(this.textBoxPassMario);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBoxUsernameMario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormLogin02";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLogin02";
            this.Load += new System.EventHandler(this.FormLogin02_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLNovoUtilzMario;
        private System.Windows.Forms.Button button2Mario;
        private System.Windows.Forms.Button EntrarMario;
        private System.Windows.Forms.LinkLabel linkLabel1Mario;
        private System.Windows.Forms.TextBox textBoxPassMario;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBoxUsernameMario;
        private System.Windows.Forms.Button buttonNomeM;
    }
}