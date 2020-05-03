namespace PIS_Projekt
{
    partial class dodavanjeLječnikaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dodavanjeLječnikaForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dodajButton = new System.Windows.Forms.Button();
            this.azurirajButton = new System.Windows.Forms.Button();
            this.ObrišiButton = new System.Windows.Forms.Button();
            this.OdustaniButton = new System.Windows.Forms.Button();
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
            this.pictureBox1.TabIndex = 52;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(14, 144);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(762, 246);
            this.dataGridView1.TabIndex = 63;
            // 
            // dodajButton
            // 
            this.dodajButton.BackColor = System.Drawing.Color.BurlyWood;
            this.dodajButton.Font = new System.Drawing.Font("Arial", 10.2F);
            this.dodajButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dodajButton.Location = new System.Drawing.Point(14, 458);
            this.dodajButton.Margin = new System.Windows.Forms.Padding(0);
            this.dodajButton.Name = "dodajButton";
            this.dodajButton.Size = new System.Drawing.Size(161, 45);
            this.dodajButton.TabIndex = 67;
            this.dodajButton.Text = "Dodaj liječnika";
            this.dodajButton.UseVisualStyleBackColor = false;
            this.dodajButton.Click += new System.EventHandler(this.dodajButton_Click);
            // 
            // azurirajButton
            // 
            this.azurirajButton.BackColor = System.Drawing.Color.PaleTurquoise;
            this.azurirajButton.Font = new System.Drawing.Font("Arial", 10.2F);
            this.azurirajButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.azurirajButton.Location = new System.Drawing.Point(14, 404);
            this.azurirajButton.Margin = new System.Windows.Forms.Padding(0);
            this.azurirajButton.Name = "azurirajButton";
            this.azurirajButton.Size = new System.Drawing.Size(161, 45);
            this.azurirajButton.TabIndex = 66;
            this.azurirajButton.Text = "Ažuriraj liječnika";
            this.azurirajButton.UseVisualStyleBackColor = false;
            this.azurirajButton.Click += new System.EventHandler(this.azurirajButton_Click);
            // 
            // ObrišiButton
            // 
            this.ObrišiButton.BackColor = System.Drawing.Color.RosyBrown;
            this.ObrišiButton.Font = new System.Drawing.Font("Arial", 10.2F);
            this.ObrišiButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ObrišiButton.Location = new System.Drawing.Point(14, 512);
            this.ObrišiButton.Margin = new System.Windows.Forms.Padding(0);
            this.ObrišiButton.Name = "ObrišiButton";
            this.ObrišiButton.Size = new System.Drawing.Size(161, 45);
            this.ObrišiButton.TabIndex = 64;
            this.ObrišiButton.Text = "Obriši liječnka";
            this.ObrišiButton.UseVisualStyleBackColor = false;
            // 
            // OdustaniButton
            // 
            this.OdustaniButton.BackColor = System.Drawing.SystemColors.Menu;
            this.OdustaniButton.Font = new System.Drawing.Font("Arial", 10.2F);
            this.OdustaniButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.OdustaniButton.Location = new System.Drawing.Point(618, 404);
            this.OdustaniButton.Margin = new System.Windows.Forms.Padding(0);
            this.OdustaniButton.Name = "OdustaniButton";
            this.OdustaniButton.Size = new System.Drawing.Size(161, 45);
            this.OdustaniButton.TabIndex = 65;
            this.OdustaniButton.Text = "Odustani";
            this.OdustaniButton.UseVisualStyleBackColor = false;
            this.OdustaniButton.Click += new System.EventHandler(this.OdustaniButton_Click_1);
            // 
            // dodavanjeLječnikaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(806, 597);
            this.Controls.Add(this.dodajButton);
            this.Controls.Add(this.azurirajButton);
            this.Controls.Add(this.ObrišiButton);
            this.Controls.Add(this.OdustaniButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "dodavanjeLječnikaForm";
            this.Text = "Liječnici";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button dodajButton;
        private System.Windows.Forms.Button azurirajButton;
        private System.Windows.Forms.Button ObrišiButton;
        private System.Windows.Forms.Button OdustaniButton;
    }
}