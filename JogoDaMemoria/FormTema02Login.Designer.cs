namespace JogoDaMemoria
{
    partial class FormTema02Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTema02Login));
            this.linkLNovoUtilzMario = new System.Windows.Forms.LinkLabel();
            this.buttonCancelarMario = new System.Windows.Forms.Button();
            this.Entrar = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.textBoxPassMario = new System.Windows.Forms.TextBox();
            this.UsernameMario = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // linkLNovoUtilzMario
            // 
            this.linkLNovoUtilzMario.AutoSize = true;
            this.linkLNovoUtilzMario.Location = new System.Drawing.Point(363, 183);
            this.linkLNovoUtilzMario.Name = "linkLNovoUtilzMario";
            this.linkLNovoUtilzMario.Size = new System.Drawing.Size(102, 13);
            this.linkLNovoUtilzMario.TabIndex = 13;
            this.linkLNovoUtilzMario.TabStop = true;
            this.linkLNovoUtilzMario.Text = "Criar novo utilizador ";
            // 
            // buttonCancelarMario
            // 
            this.buttonCancelarMario.Location = new System.Drawing.Point(330, 243);
            this.buttonCancelarMario.Name = "buttonCancelarMario";
            this.buttonCancelarMario.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelarMario.TabIndex = 12;
            this.buttonCancelarMario.Text = "Cancelar";
            this.buttonCancelarMario.UseVisualStyleBackColor = true;
            // 
            // Entrar
            // 
            this.Entrar.FlatAppearance.BorderSize = 3;
            this.Entrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Entrar.Location = new System.Drawing.Point(151, 243);
            this.Entrar.Name = "Entrar";
            this.Entrar.Size = new System.Drawing.Size(69, 24);
            this.Entrar.TabIndex = 11;
            this.Entrar.Text = "Entrar";
            this.Entrar.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(363, 218);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(42, 13);
            this.linkLabel1.TabIndex = 10;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Mostrar";
            // 
            // textBoxPassMario
            // 
            this.textBoxPassMario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassMario.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxPassMario.Location = new System.Drawing.Point(191, 208);
            this.textBoxPassMario.Name = "textBoxPassMario";
            this.textBoxPassMario.Size = new System.Drawing.Size(166, 29);
            this.textBoxPassMario.TabIndex = 9;
            this.textBoxPassMario.Tag = "c";
            this.textBoxPassMario.Text = "Password";
            // 
            // UsernameMario
            // 
            this.UsernameMario.BackColor = System.Drawing.SystemColors.MenuBar;
            this.UsernameMario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameMario.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.UsernameMario.Location = new System.Drawing.Point(191, 172);
            this.UsernameMario.Multiline = true;
            this.UsernameMario.Name = "UsernameMario";
            this.UsernameMario.Size = new System.Drawing.Size(166, 30);
            this.UsernameMario.TabIndex = 7;
            this.UsernameMario.Tag = "c";
            this.UsernameMario.Text = "username";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(191, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(166, 163);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // FormTema02Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 299);
            this.Controls.Add(this.linkLNovoUtilzMario);
            this.Controls.Add(this.buttonCancelarMario);
            this.Controls.Add(this.Entrar);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.textBoxPassMario);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.UsernameMario);
            this.Name = "FormTema02Login";
            this.Text = "FormTema02Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLNovoUtilzMario;
        private System.Windows.Forms.Button buttonCancelarMario;
        private System.Windows.Forms.Button Entrar;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.TextBox textBoxPassMario;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox UsernameMario;
    }
}