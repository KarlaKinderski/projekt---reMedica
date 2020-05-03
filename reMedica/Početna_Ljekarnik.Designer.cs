namespace PIS_Projekt
{
    partial class pocetnaLjekarnik
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pocetnaLjekarnik));
            this.receptButton = new System.Windows.Forms.Button();
            this.popisPacijenatadataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.datum = new System.Windows.Forms.Label();
            this.vrijeme = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dodajLjekarnikaButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.imeIPrezimetextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.OIBTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.popisPacijenatadataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // receptButton
            // 
            this.receptButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.receptButton.BackColor = System.Drawing.SystemColors.Menu;
            this.receptButton.Font = new System.Drawing.Font("Arial", 10.2F);
            this.receptButton.Location = new System.Drawing.Point(12, 200);
            this.receptButton.Name = "receptButton";
            this.receptButton.Size = new System.Drawing.Size(199, 62);
            this.receptButton.TabIndex = 4;
            this.receptButton.Text = "Pregled recepta";
            this.receptButton.UseVisualStyleBackColor = false;
            this.receptButton.Click += new System.EventHandler(this.ReceptButton_Click);
            // 
            // popisPacijenatadataGridView
            // 
            this.popisPacijenatadataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonShadow;
            this.popisPacijenatadataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.popisPacijenatadataGridView.Location = new System.Drawing.Point(256, 458);
            this.popisPacijenatadataGridView.Name = "popisPacijenatadataGridView";
            this.popisPacijenatadataGridView.RowHeadersWidth = 51;
            this.popisPacijenatadataGridView.RowTemplate.Height = 24;
            this.popisPacijenatadataGridView.Size = new System.Drawing.Size(738, 138);
            this.popisPacijenatadataGridView.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.datum);
            this.groupBox1.Controls.Add(this.vrijeme);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 10.2F);
            this.groupBox1.Location = new System.Drawing.Point(787, 188);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(240, 87);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datum i vrijeme";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // datum
            // 
            this.datum.AutoSize = true;
            this.datum.Font = new System.Drawing.Font("Arial", 10.2F);
            this.datum.Location = new System.Drawing.Point(52, 62);
            this.datum.Name = "datum";
            this.datum.Size = new System.Drawing.Size(56, 19);
            this.datum.TabIndex = 15;
            this.datum.Text = "Datum";
            // 
            // vrijeme
            // 
            this.vrijeme.AutoSize = true;
            this.vrijeme.Font = new System.Drawing.Font("Arial", 10.2F);
            this.vrijeme.Location = new System.Drawing.Point(52, 35);
            this.vrijeme.Name = "vrijeme";
            this.vrijeme.Size = new System.Drawing.Size(63, 19);
            this.vrijeme.TabIndex = 14;
            this.vrijeme.Text = "Vrijeme";
            this.vrijeme.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.BurlyWood;
            this.panel1.Controls.Add(this.dodajLjekarnikaButton);
            this.panel1.Controls.Add(this.receptButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 167);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(222, 528);
            this.panel1.TabIndex = 29;
            // 
            // dodajLjekarnikaButton
            // 
            this.dodajLjekarnikaButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dodajLjekarnikaButton.BackColor = System.Drawing.SystemColors.Menu;
            this.dodajLjekarnikaButton.Font = new System.Drawing.Font("Arial", 10.2F);
            this.dodajLjekarnikaButton.Location = new System.Drawing.Point(12, 276);
            this.dodajLjekarnikaButton.Name = "dodajLjekarnikaButton";
            this.dodajLjekarnikaButton.Size = new System.Drawing.Size(199, 62);
            this.dodajLjekarnikaButton.TabIndex = 6;
            this.dodajLjekarnikaButton.Text = "Ljekarnici";
            this.dodajLjekarnikaButton.UseVisualStyleBackColor = false;
            this.dodajLjekarnikaButton.Click += new System.EventHandler(this.dodajLjekarnikaButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.BurlyWood;
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1039, 167);
            this.panel2.TabIndex = 30;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(853, 48);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(59, 61);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 28;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(51, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(168, 166);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 27;
            this.pictureBox3.TabStop = false;
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
            // imeIPrezimetextBox
            // 
            this.imeIPrezimetextBox.Location = new System.Drawing.Point(255, 414);
            this.imeIPrezimetextBox.Name = "imeIPrezimetextBox";
            this.imeIPrezimetextBox.Size = new System.Drawing.Size(255, 22);
            this.imeIPrezimetextBox.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.2F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(252, 377);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(341, 19);
            this.label2.TabIndex = 35;
            this.label2.Text = "Pretraga peacijenta prema imenu i prezimenu";
            // 
            // OIBTextBox
            // 
            this.OIBTextBox.Location = new System.Drawing.Point(255, 333);
            this.OIBTextBox.Name = "OIBTextBox";
            this.OIBTextBox.Size = new System.Drawing.Size(255, 22);
            this.OIBTextBox.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.2F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(252, 299);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 19);
            this.label1.TabIndex = 33;
            this.label1.Text = "Pretraga peacijenta prema OIB-u";
            // 
            // pocetnaLjekarnik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1039, 695);
            this.Controls.Add(this.imeIPrezimetextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.OIBTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.popisPacijenatadataGridView);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "pocetnaLjekarnik";
            this.Text = "Početna";
            this.Load += new System.EventHandler(this.pocetna_Load);
            ((System.ComponentModel.ISupportInitialize)(this.popisPacijenatadataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button receptButton;
        private System.Windows.Forms.DataGridView popisPacijenatadataGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label datum;
        private System.Windows.Forms.Label vrijeme;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox imeIPrezimetextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox OIBTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button dodajLjekarnikaButton;
    }
}