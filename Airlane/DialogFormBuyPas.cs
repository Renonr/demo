using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airlane
{
    public partial class DialogFormBuyPas : Form
    {
        SqlConnection connection = new SqlConnection();

        public DialogFormBuyPas(SqlConnection connection)
        {
            InitializeComponent();
            this.connection = connection;

            string query = "SELECT ID_Рейса FROM [Рейсы]";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                comboBox2.Items.Add(reader.GetValue(0).ToString());
            }
            reader.Close();
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

        public string getFly()
        {
            return comboBox2.Text;
        }
    }
}
