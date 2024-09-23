using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airlane
{
    public partial class DialogForm : Form
    {
        public DialogForm()
        {
            InitializeComponent();
        }

        private void roundBTN1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void roundBTN2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        public string[] getInfo()
        {
            return new string[] {
                textBox1.Text,
                textBox2.Text,
                textBox4.Text,
                textBox3.Text,
                textBox6.Text,
                textBox5.Text,
                comboBox2.Text
            };
        }
    }
}
