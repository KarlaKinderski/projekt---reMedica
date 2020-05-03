namespace PIS_Projekt
{
    partial class Prijava
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Prijava));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Prijavabutton = new System.Windows.Forms.Button();
            this.korisnickoIme = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lozinka = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Prijava2button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(153, 9);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Prijavabutton
            // 
            this.Prijavabutton.BackColor = System.Drawing.SystemColors.Menu;
            this.Prijavabutton.Font = new System.Drawing.Font("Arial", 10.2F);
            this.Prijavabutton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Prijavabutton.Location = new System.Drawing.Point(95, 483);
            this.Prijavabutton.Name = "Prijavabutton";
            this.Prijavabutton.Size = new System.Drawing.Size(367, 49);
            this.Prijavabutton.TabIndex = 3;
            this.Prijavabutton.Text = "Prijavi se - Ljekarnik";
            this.Prijavabutton.UseVisualStyleBackColor = false;
            this.Prijavabutton.Click += new System.EventHandler(this.PrijavaButton);
            // 
            // korisnickoIme
            // 
            this.korisnickoIme.BackColor = System.Drawing.Color.BurlyWood;
            this.korisnickoIme.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.korisnickoIme.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(10)));
            this.korisnickoIme.ForeColor = System.Drawing.Color.Transparent;
            this.korisnickoIme.Location = new System.Drawing.Point(153, 277);
            this.korisnickoIme.Name = "korisnickoIme";
            this.korisnickoIme.Size = new System.Drawing.Size(305, 20);
            this.korisnickoIme.TabIndex = 1;
            this.korisnickoIme.Text = "korisničko ime";
            this.korisnickoIme.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.korisnickoIme.TextChanged += new System.EventHandler(this.korisnickoIme_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(95, 352);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(49, 49);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(95, 263);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(49, 49);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Location = new System.Drawing.Point(95, 318);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(367, 1);
            this.panel1.TabIndex = 5;
            // 
            // lozinka
            // 
            this.lozinka.BackColor = System.Drawing.Color.BurlyWood;
            this.lozinka.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lozinka.Font = new System.Drawing.Font("Arial", 10.2F);
            this.lozinka.ForeColor = System.Drawing.Color.Transparent;
            this.lozinka.Location = new System.Drawing.Point(153, 367);
            this.lozinka.Name = "lozinka";
            this.lozinka.Size = new System.Drawing.Size(305, 20);
            this.lozinka.TabIndex = 2;
            this.lozinka.Text = "lozinka";
            this.lozinka.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lozinka.TextChanged += new System.EventHandler(this.lozinka_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Location = new System.Drawing.Point(95, 407);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(367, 1);
            this.panel2.TabIndex = 10;
            // 
            // Prijava2button
            // 
            this.Prijava2button.BackColor = System.Drawing.SystemColors.Menu;
            this.Prijava2button.Font = new System.Drawing.Font("Arial", 10.2F);
            this.Prijava2button.Location = new System.Drawing.Point(95, 549);
            this.Prijava2button.Name = "Prijava2button";
            this.Prijava2button.Size = new System.Drawing.Size(367, 49);
            this.Prijava2button.TabIndex = 4;
            this.Prijava2button.Text = "Prijavi se - Liječnik";
            this.Prijava2button.UseVisualStyleBackColor = false;
            this.Prijava2button.Click += new System.EventHandler(this.Prijava2button_Click);
            // 
            // Prijava
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(555, 627);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lozinka);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Prijava2button);
            this.Controls.Add(this.korisnickoIme);
            this.Controls.Add(this.Prijavabutton);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Prijava";
            this.Text = "Prijava";
            this.Load += new System.EventHandler(this.Prijava_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Prijavabutton;
        private System.Windows.Forms.TextBox korisnickoIme;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox lozinka;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Prijava2button;
    }
}

