namespace Airlane
{
    partial class DialogFormBuyPas
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
            this.roundBTN2 = new Airlane.RoundBTN();
            this.roundBTN1 = new Airlane.RoundBTN();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // roundBTN2
            // 
            this.roundBTN2.BackColor = System.Drawing.Color.Red;
            this.roundBTN2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.roundBTN2.ForeColor = System.Drawing.SystemColors.Control;
            this.roundBTN2.Location = new System.Drawing.Point(193, 211);
            this.roundBTN2.Name = "roundBTN2";
            this.roundBTN2.Radius = 30;
            this.roundBTN2.Size = new System.Drawing.Size(109, 42);
            this.roundBTN2.TabIndex = 50;
            this.roundBTN2.Text = "Отмена";
            this.roundBTN2.UseVisualStyleBackColor = false;
            this.roundBTN2.Click += new System.EventHandler(this.roundBTN2_Click);
            // 
            // roundBTN1
            // 
            this.roundBTN1.BackColor = System.Drawing.Color.Red;
            this.roundBTN1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.roundBTN1.ForeColor = System.Drawing.SystemColors.Control;
            this.roundBTN1.Location = new System.Drawing.Point(68, 211);
            this.roundBTN1.Name = "roundBTN1";
            this.roundBTN1.Radius = 30;
            this.roundBTN1.Size = new System.Drawing.Size(109, 42);
            this.roundBTN1.TabIndex = 49;
            this.roundBTN1.Text = "Купить";
            this.roundBTN1.UseVisualStyleBackColor = false;
            this.roundBTN1.Click += new System.EventHandler(this.roundBTN1_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(114, 165);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(144, 21);
            this.comboBox2.TabIndex = 48;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(165, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 20);
            this.label7.TabIndex = 47;
            this.label7.Text = "Рейс";
            // 
            // DialogFormBuyPas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 392);
            this.Controls.Add(this.roundBTN2);
            this.Controls.Add(this.roundBTN1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label7);
            this.Name = "DialogFormBuyPas";
            this.Text = "DialogFormBuyPas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RoundBTN roundBTN2;
        private RoundBTN roundBTN1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label7;
    }
}