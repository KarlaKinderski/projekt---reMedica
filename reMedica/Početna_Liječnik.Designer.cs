namespace PIS_Projekt
{
    partial class pocetnaLijecnik
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pocetnaLijecnik));
            this.DodajPacijentaButton = new System.Windows.Forms.Button();
            this.PrepisiButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.datum = new System.Windows.Forms.Label();
            this.vrijeme = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.AzurirajPacijentaButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.statistikaButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dodajLječnikaButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.imeIPrezimetextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.OIBTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dijagnozaITerpaijaButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // DodajPacijentaButton
            // 
            this.DodajPacijentaButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.DodajPacijentaButton.BackColor = System.Drawing.SystemColors.Menu;
            this.DodajPacijentaButton.Font = new System.Drawing.Font("Arial", 10.2F);
            this.DodajPacijentaButton.Location = new System.Drawing.Point(12, 139);
            this.DodajPacijentaButton.Name = "DodajPacijentaButton";
            this.DodajPacijentaButton.Size = new System.Drawing.Size(199, 62);
            this.DodajPacijentaButton.TabIndex = 0;
            this.DodajPacijentaButton.Text = "Dodaj pacijenta";
            this.DodajPacijentaButton.UseVisualStyleBackColor = false;
            this.DodajPacijentaButton.Click += new System.EventHandler(this.DodajPacijentaButton_Click);
            // 
            // PrepisiButton
            // 
            this.PrepisiButton.BackColor = System.Drawing.SystemColors.Menu;
            this.PrepisiButton.Font = new System.Drawing.Font("Arial", 10.2F);
            this.PrepisiButton.Location = new System.Drawing.Point(812, 712);
            this.PrepisiButton.Name = "PrepisiButton";
            this.PrepisiButton.Size = new System.Drawing.Size(203, 45);
            this.PrepisiButton.TabIndex = 1;
            this.PrepisiButton.Text = "Prepiši lijek pacijentu";
            this.PrepisiButton.UseVisualStyleBackColor = false;
            this.PrepisiButton.Click += new System.EventHandler(this.PrepisiButton_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackColor = System.Drawing.SystemColors.Menu;
            this.button3.Font = new System.Drawing.Font("Arial", 10.2F);
            this.button3.Location = new System.Drawing.Point(918, 59);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(109, 31);
            this.button3.TabIndex = 20;
            this.button3.Text = "Odjava";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.datum);
            this.groupBox1.Controls.Add(this.vrijeme);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 10.2F);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(787, 188);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(240, 87);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datum i vrijeme";
            // 
            // datum
            // 
            this.datum.AutoSize = true;
            this.datum.Location = new System.Drawing.Point(52, 62);
            this.datum.Name = "datum";
            this.datum.Size = new System.Drawing.Size(56, 19);
            this.datum.TabIndex = 15;
            this.datum.Text = "Datum";
            // 
            // vrijeme
            // 
            this.vrijeme.AutoSize = true;
            this.vrijeme.Location = new System.Drawing.Point(52, 35);
            this.vrijeme.Name = "vrijeme";
            this.vrijeme.Size = new System.Drawing.Size(63, 19);
            this.vrijeme.TabIndex = 14;
            this.vrijeme.Text = "Vrijeme";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonShadow;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(245, 420);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(770, 195);
            this.dataGridView1.TabIndex = 25;
            // 
            // AzurirajPacijentaButton
            // 
            this.AzurirajPacijentaButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.AzurirajPacijentaButton.BackColor = System.Drawing.SystemColors.Menu;
            this.AzurirajPacijentaButton.Font = new System.Drawing.Font("Arial", 10.2F);
            this.AzurirajPacijentaButton.Location = new System.Drawing.Point(12, 207);
            this.AzurirajPacijentaButton.Name = "AzurirajPacijentaButton";
            this.AzurirajPacijentaButton.Size = new System.Drawing.Size(199, 62);
            this.AzurirajPacijentaButton.TabIndex = 26;
            this.AzurirajPacijentaButton.Text = "Ažuriraj podatke";
            this.AzurirajPacijentaButton.UseVisualStyleBackColor = false;
            this.AzurirajPacijentaButton.Click += new System.EventHandler(this.azuriranjePacijentaFormaButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.panel1.Controls.Add(this.statistikaButton);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.dodajLječnikaButton);
            this.panel1.Controls.Add(this.AzurirajPacijentaButton);
            this.panel1.Controls.Add(this.DodajPacijentaButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 167);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(222, 624);
            this.panel1.TabIndex = 27;
            // 
            // statistikaButton
            // 
            this.statistikaButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.statistikaButton.BackColor = System.Drawing.SystemColors.Menu;
            this.statistikaButton.Font = new System.Drawing.Font("Arial", 10.2F);
            this.statistikaButton.Location = new System.Drawing.Point(12, 411);
            this.statistikaButton.Name = "statistikaButton";
            this.statistikaButton.Size = new System.Drawing.Size(199, 62);
            this.statistikaButton.TabIndex = 29;
            this.statistikaButton.Text = "Statistika";
            this.statistikaButton.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button1.BackColor = System.Drawing.SystemColors.Menu;
            this.button1.Font = new System.Drawing.Font("Arial", 10.2F);
            this.button1.Location = new System.Drawing.Point(12, 343);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(199, 62);
            this.button1.TabIndex = 28;
            this.button1.Text = "Naručivanje na pregled";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dodajLječnikaButton
            // 
            this.dodajLječnikaButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dodajLječnikaButton.BackColor = System.Drawing.SystemColors.Menu;
            this.dodajLječnikaButton.Font = new System.Drawing.Font("Arial", 10.2F);
            this.dodajLječnikaButton.Location = new System.Drawing.Point(12, 275);
            this.dodajLječnikaButton.Name = "dodajLječnikaButton";
            this.dodajLječnikaButton.Size = new System.Drawing.Size(199, 62);
            this.dodajLječnikaButton.TabIndex = 27;
            this.dodajLječnikaButton.Text = "Liječnici";
            this.dodajLječnikaButton.UseVisualStyleBackColor = false;
            this.dodajLječnikaButton.Click += new System.EventHandler(this.dodajLječnikaButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(51, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(168, 166);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumAquamarine;
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1039, 167);
            this.panel2.TabIndex = 28;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(853, 48);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(59, 52);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 28;
            this.pictureBox2.TabStop = false;
            // 
            // imeIPrezimetextBox
            // 
            this.imeIPrezimetextBox.Location = new System.Drawing.Point(245, 365);
            this.imeIPrezimetextBox.Name = "imeIPrezimetextBox";
            this.imeIPrezimetextBox.Size = new System.Drawing.Size(255, 22);
            this.imeIPrezimetextBox.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.2F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(242, 328);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(332, 19);
            this.label2.TabIndex = 31;
            this.label2.Text = "Pretraga pacijenta prema imenu i prezimenu";
            // 
            // OIBTextBox
            // 
            this.OIBTextBox.Location = new System.Drawing.Point(245, 284);
            this.OIBTextBox.Name = "OIBTextBox";
            this.OIBTextBox.Size = new System.Drawing.Size(255, 22);
            this.OIBTextBox.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.2F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(242, 250);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 19);
            this.label1.TabIndex = 29;
            this.label1.Text = "Pretraga pacijenta prema OIB-u";
            // 
            // dijagnozaITerpaijaButton
            // 
            this.dijagnozaITerpaijaButton.BackColor = System.Drawing.SystemColors.Menu;
            this.dijagnozaITerpaijaButton.Font = new System.Drawing.Font("Arial", 10.2F);
            this.dijagnozaITerpaijaButton.Location = new System.Drawing.Point(812, 628);
            this.dijagnozaITerpaijaButton.Name = "dijagnozaITerpaijaButton";
            this.dijagnozaITerpaijaButton.Size = new System.Drawing.Size(203, 69);
            this.dijagnozaITerpaijaButton.TabIndex = 33;
            this.dijagnozaITerpaijaButton.Text = "Prepiši dijagnozu i terapiju pacijentu";
            this.dijagnozaITerpaijaButton.UseVisualStyleBackColor = false;
            this.dijagnozaITerpaijaButton.Click += new System.EventHandler(this.dijagnozaITerpaijaButton_Click);
            // 
            // pocetnaLijecnik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1039, 791);
            this.Controls.Add(this.dijagnozaITerpaijaButton);
            this.Controls.Add(this.imeIPrezimetextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.OIBTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.PrepisiButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "pocetnaLijecnik";
            this.Text = "Početna_Liječnik";
            this.Load += new System.EventHandler(this.Početna_Liječnik_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DodajPacijentaButton;
        private System.Windows.Forms.Button PrepisiButton;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label datum;
        private System.Windows.Forms.Label vrijeme;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button AzurirajPacijentaButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox imeIPrezimetextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox OIBTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button dodajLječnikaButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button dijagnozaITerpaijaButton;
        private System.Windows.Forms.Button statistikaButton;
    }
}