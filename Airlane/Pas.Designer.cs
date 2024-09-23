namespace Airlane
{
    partial class Pas
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.roundBTN1 = new Airlane.RoundBTN();
            this.roundBTN2 = new Airlane.RoundBTN();
            this.roundBTN3 = new Airlane.RoundBTN();
            this.roundBTN4 = new Airlane.RoundBTN();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(308, 121);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(467, 332);
            this.dataGridView1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ImageLocation = "C:\\Users\\Ivan\\Pictures\\pngwingL2.com.png";
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(1, 426);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(301, 251);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // roundBTN1
            // 
            this.roundBTN1.BackColor = System.Drawing.Color.Red;
            this.roundBTN1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.roundBTN1.ForeColor = System.Drawing.SystemColors.Control;
            this.roundBTN1.Location = new System.Drawing.Point(919, 12);
            this.roundBTN1.Name = "roundBTN1";
            this.roundBTN1.Radius = 30;
            this.roundBTN1.Size = new System.Drawing.Size(144, 38);
            this.roundBTN1.TabIndex = 7;
            this.roundBTN1.Text = "Выйти";
            this.roundBTN1.UseVisualStyleBackColor = false;
            this.roundBTN1.Click += new System.EventHandler(this.roundBTN1_Click);
            // 
            // roundBTN2
            // 
            this.roundBTN2.BackColor = System.Drawing.Color.Red;
            this.roundBTN2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.roundBTN2.ForeColor = System.Drawing.SystemColors.Control;
            this.roundBTN2.Location = new System.Drawing.Point(860, 581);
            this.roundBTN2.Name = "roundBTN2";
            this.roundBTN2.Radius = 30;
            this.roundBTN2.Size = new System.Drawing.Size(174, 51);
            this.roundBTN2.TabIndex = 8;
            this.roundBTN2.Text = "Мои рейсы";
            this.roundBTN2.UseVisualStyleBackColor = false;
            this.roundBTN2.Click += new System.EventHandler(this.roundBTN2_Click);
            // 
            // roundBTN3
            // 
            this.roundBTN3.BackColor = System.Drawing.Color.Red;
            this.roundBTN3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.roundBTN3.ForeColor = System.Drawing.SystemColors.Control;
            this.roundBTN3.Location = new System.Drawing.Point(662, 581);
            this.roundBTN3.Name = "roundBTN3";
            this.roundBTN3.Radius = 30;
            this.roundBTN3.Size = new System.Drawing.Size(174, 51);
            this.roundBTN3.TabIndex = 9;
            this.roundBTN3.Text = "Мои билеты";
            this.roundBTN3.UseVisualStyleBackColor = false;
            this.roundBTN3.Click += new System.EventHandler(this.roundBTN3_Click);
            // 
            // roundBTN4
            // 
            this.roundBTN4.BackColor = System.Drawing.Color.Red;
            this.roundBTN4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.roundBTN4.ForeColor = System.Drawing.SystemColors.Control;
            this.roundBTN4.Location = new System.Drawing.Point(464, 581);
            this.roundBTN4.Name = "roundBTN4";
            this.roundBTN4.Radius = 30;
            this.roundBTN4.Size = new System.Drawing.Size(174, 51);
            this.roundBTN4.TabIndex = 10;
            this.roundBTN4.Text = "Купить билет";
            this.roundBTN4.UseVisualStyleBackColor = false;
            this.roundBTN4.Click += new System.EventHandler(this.roundBTN4_Click);
            // 
            // Pas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 679);
            this.Controls.Add(this.roundBTN4);
            this.Controls.Add(this.roundBTN3);
            this.Controls.Add(this.roundBTN2);
            this.Controls.Add(this.roundBTN1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Pas";
            this.Text = "Pas";
            this.Load += new System.EventHandler(this.Pas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private RoundBTN roundBTN1;
        private RoundBTN roundBTN2;
        private RoundBTN roundBTN3;
        private RoundBTN roundBTN4;
    }
}