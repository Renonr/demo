namespace Airlane
{
    partial class Reg
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.roundBTN1 = new Airlane.RoundBTN();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.roundBTN2 = new Airlane.RoundBTN();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.ImageLocation = "C:\\Users\\Ivan\\Pictures\\pngwingL2.com.png";
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 348);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(303, 256);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(401, 268);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(144, 20);
            this.textBox2.TabIndex = 13;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(401, 204);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(144, 20);
            this.textBox1.TabIndex = 12;
            // 
            // roundBTN1
            // 
            this.roundBTN1.BackColor = System.Drawing.Color.Red;
            this.roundBTN1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.roundBTN1.ForeColor = System.Drawing.SystemColors.Control;
            this.roundBTN1.Location = new System.Drawing.Point(398, 297);
            this.roundBTN1.Name = "roundBTN1";
            this.roundBTN1.Radius = 30;
            this.roundBTN1.Size = new System.Drawing.Size(152, 42);
            this.roundBTN1.TabIndex = 11;
            this.roundBTN1.Text = "Зарегестрироваться";
            this.roundBTN1.UseVisualStyleBackColor = false;
            this.roundBTN1.Click += new System.EventHandler(this.roundBTN1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(426, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Пароль";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(433, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Логин";
            // 
            // roundBTN2
            // 
            this.roundBTN2.BackColor = System.Drawing.Color.Red;
            this.roundBTN2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.roundBTN2.ForeColor = System.Drawing.SystemColors.Control;
            this.roundBTN2.Location = new System.Drawing.Point(398, 345);
            this.roundBTN2.Name = "roundBTN2";
            this.roundBTN2.Radius = 30;
            this.roundBTN2.Size = new System.Drawing.Size(152, 42);
            this.roundBTN2.TabIndex = 14;
            this.roundBTN2.Text = "Отмена";
            this.roundBTN2.UseVisualStyleBackColor = false;
            this.roundBTN2.Click += new System.EventHandler(this.roundBTN2_Click);
            // 
            // Reg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 604);
            this.Controls.Add(this.roundBTN2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.roundBTN1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Reg";
            this.Text = "Reg";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private RoundBTN roundBTN1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private RoundBTN roundBTN2;
    }
}