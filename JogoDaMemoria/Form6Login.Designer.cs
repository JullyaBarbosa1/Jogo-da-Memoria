namespace JogoDaMemoria
{
    partial class Form6Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6Login));
            this.linkNovoUtilizadorLabel = new System.Windows.Forms.LinkLabel();
            this.buttonCancelarD = new System.Windows.Forms.Button();
            this.buttonEntrarD = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.textBoxPassD = new System.Windows.Forms.TextBox();
            this.textBoxUsernameD = new System.Windows.Forms.TextBox();
            this.TemaDisney = new System.Windows.Forms.Button();
            this.pictureBoxDisney = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDisney)).BeginInit();
            this.SuspendLayout();
            // 
            // linkNovoUtilizadorLabel
            // 
            this.linkNovoUtilizadorLabel.AutoSize = true;
            this.linkNovoUtilizadorLabel.Location = new System.Drawing.Point(362, 225);
            this.linkNovoUtilizadorLabel.Name = "linkNovoUtilizadorLabel";
            this.linkNovoUtilizadorLabel.Size = new System.Drawing.Size(102, 13);
            this.linkNovoUtilizadorLabel.TabIndex = 13;
            this.linkNovoUtilizadorLabel.TabStop = true;
            this.linkNovoUtilizadorLabel.Text = "Criar novo utilizador ";
            this.linkNovoUtilizadorLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkNovoUtilizadorLabel_LinkClicked);
            // 
            // buttonCancelarD
            // 
            this.buttonCancelarD.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelarD.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonCancelarD.Location = new System.Drawing.Point(341, 304);
            this.buttonCancelarD.Name = "buttonCancelarD";
            this.buttonCancelarD.Size = new System.Drawing.Size(100, 36);
            this.buttonCancelarD.TabIndex = 12;
            this.buttonCancelarD.Text = "Cancelar";
            this.buttonCancelarD.UseVisualStyleBackColor = true;
            // 
            // buttonEntrarD
            // 
            this.buttonEntrarD.FlatAppearance.BorderSize = 3;
            this.buttonEntrarD.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEntrarD.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonEntrarD.Location = new System.Drawing.Point(124, 304);
            this.buttonEntrarD.Name = "buttonEntrarD";
            this.buttonEntrarD.Size = new System.Drawing.Size(100, 36);
            this.buttonEntrarD.TabIndex = 11;
            this.buttonEntrarD.Text = "Entrar";
            this.buttonEntrarD.UseVisualStyleBackColor = true;
            this.buttonEntrarD.Click += new System.EventHandler(this.buttonEntrarD_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(362, 260);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(42, 13);
            this.linkLabel1.TabIndex = 10;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Mostrar";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // textBoxPassD
            // 
            this.textBoxPassD.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassD.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxPassD.Location = new System.Drawing.Point(190, 269);
            this.textBoxPassD.Name = "textBoxPassD";
            this.textBoxPassD.Size = new System.Drawing.Size(166, 29);
            this.textBoxPassD.TabIndex = 9;
            this.textBoxPassD.Tag = "c";
            this.textBoxPassD.Text = "Password";
            this.textBoxPassD.UseSystemPasswordChar = true;
            // 
            // textBoxUsernameD
            // 
            this.textBoxUsernameD.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textBoxUsernameD.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsernameD.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxUsernameD.Location = new System.Drawing.Point(190, 233);
            this.textBoxUsernameD.Multiline = true;
            this.textBoxUsernameD.Name = "textBoxUsernameD";
            this.textBoxUsernameD.Size = new System.Drawing.Size(166, 30);
            this.textBoxUsernameD.TabIndex = 7;
            this.textBoxUsernameD.Tag = "c";
            this.textBoxUsernameD.Text = "username";
            // 
            // TemaDisney
            // 
            this.TemaDisney.AccessibleName = "";
            this.TemaDisney.BackColor = System.Drawing.Color.Transparent;
            this.TemaDisney.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TemaDisney.BackgroundImage")));
            this.TemaDisney.FlatAppearance.BorderSize = 0;
            this.TemaDisney.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TemaDisney.Font = new System.Drawing.Font("Pixar", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TemaDisney.Location = new System.Drawing.Point(139, -13);
            this.TemaDisney.Name = "TemaDisney";
            this.TemaDisney.Size = new System.Drawing.Size(253, 100);
            this.TemaDisney.TabIndex = 73;
            this.TemaDisney.Tag = "o";
            this.TemaDisney.UseVisualStyleBackColor = false;
            // 
            // pictureBoxDisney
            // 
            this.pictureBoxDisney.AccessibleName = "";
            this.pictureBoxDisney.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxDisney.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxDisney.Image")));
            this.pictureBoxDisney.Location = new System.Drawing.Point(179, 34);
            this.pictureBoxDisney.Name = "pictureBoxDisney";
            this.pictureBoxDisney.Size = new System.Drawing.Size(189, 193);
            this.pictureBoxDisney.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDisney.TabIndex = 72;
            this.pictureBoxDisney.TabStop = false;
            this.pictureBoxDisney.Tag = "o";
            // 
            // Form6Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(576, 345);
            this.Controls.Add(this.TemaDisney);
            this.Controls.Add(this.pictureBoxDisney);
            this.Controls.Add(this.linkNovoUtilizadorLabel);
            this.Controls.Add(this.buttonCancelarD);
            this.Controls.Add(this.buttonEntrarD);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.textBoxPassD);
            this.Controls.Add(this.textBoxUsernameD);
            this.Name = "Form6Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form6Login";
            this.Load += new System.EventHandler(this.Form6Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDisney)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkNovoUtilizadorLabel;
        private System.Windows.Forms.Button buttonCancelarD;
        private System.Windows.Forms.Button buttonEntrarD;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.TextBox textBoxPassD;
        private System.Windows.Forms.TextBox textBoxUsernameD;
        private System.Windows.Forms.PictureBox pictureBoxDisney;
        private System.Windows.Forms.Button TemaDisney;
    }
}