namespace PIS_Projekt
{
    partial class dodavanjeLjekarnikaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dodavanjeLjekarnikaForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ObrišiButton = new System.Windows.Forms.Button();
            this.OdustaniButton = new System.Windows.Forms.Button();
            this.azurirajButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dodajButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(118, 114);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 57;
            this.pictureBox1.TabStop = false;
            // 
            // ObrišiButton
            // 
            this.ObrišiButton.BackColor = System.Drawing.Color.RosyBrown;
            this.ObrišiButton.Font = new System.Drawing.Font("Arial", 10.2F);
            this.ObrišiButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ObrišiButton.Location = new System.Drawing.Point(12, 513);
            this.ObrišiButton.Margin = new System.Windows.Forms.Padding(0);
            this.ObrišiButton.Name = "ObrišiButton";
            this.ObrišiButton.Size = new System.Drawing.Size(169, 45);
            this.ObrišiButton.TabIndex = 55;
            this.ObrišiButton.Text = "Obriši ljekarnika";
            this.ObrišiButton.UseVisualStyleBackColor = false;
            // 
            // OdustaniButton
            // 
            this.OdustaniButton.BackColor = System.Drawing.SystemColors.Menu;
            this.OdustaniButton.Font = new System.Drawing.Font("Arial", 10.2F);
            this.OdustaniButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.OdustaniButton.Location = new System.Drawing.Point(616, 405);
            this.OdustaniButton.Margin = new System.Windows.Forms.Padding(0);
            this.OdustaniButton.Name = "OdustaniButton";
            this.OdustaniButton.Size = new System.Drawing.Size(161, 45);
            this.OdustaniButton.TabIndex = 56;
            this.OdustaniButton.Text = "Odustani";
            this.OdustaniButton.UseVisualStyleBackColor = false;
            this.OdustaniButton.Click += new System.EventHandler(this.OdustaniButton_Click);
            // 
            // azurirajButton
            // 
            this.azurirajButton.BackColor = System.Drawing.Color.PaleTurquoise;
            this.azurirajButton.Font = new System.Drawing.Font("Arial", 10.2F);
            this.azurirajButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.azurirajButton.Location = new System.Drawing.Point(12, 405);
            this.azurirajButton.Margin = new System.Windows.Forms.Padding(0);
            this.azurirajButton.Name = "azurirajButton";
            this.azurirajButton.Size = new System.Drawing.Size(169, 45);
            this.azurirajButton.TabIndex = 58;
            this.azurirajButton.Text = "Ažuriraj ljekarnika";
            this.azurirajButton.UseVisualStyleBackColor = false;
            this.azurirajButton.Click += new System.EventHandler(this.dodajLjekarnikaButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 155);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(765, 229);
            this.dataGridView1.TabIndex = 59;
            // 
            // dodajButton
            // 
            this.dodajButton.BackColor = System.Drawing.Color.BurlyWood;
            this.dodajButton.Font = new System.Drawing.Font("Arial", 10.2F);
            this.dodajButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dodajButton.Location = new System.Drawing.Point(12, 459);
            this.dodajButton.Margin = new System.Windows.Forms.Padding(0);
            this.dodajButton.Name = "dodajButton";
            this.dodajButton.Size = new System.Drawing.Size(169, 45);
            this.dodajButton.TabIndex = 60;
            this.dodajButton.Text = "Dodaj ljekarnika";
            this.dodajButton.UseVisualStyleBackColor = false;
            this.dodajButton.Click += new System.EventHandler(this.dodajButton_Click);
            // 
            // dodavanjeLjekarnikaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(800, 583);
            this.Controls.Add(this.dodajButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.azurirajButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ObrišiButton);
            this.Controls.Add(this.OdustaniButton);
            this.Name = "dodavanjeLjekarnikaForm";
            this.Text = "Ljekarnici";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button ObrišiButton;
        private System.Windows.Forms.Button OdustaniButton;
        private System.Windows.Forms.Button azurirajButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button dodajButton;
    }
}