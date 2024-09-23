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
    public partial class Reg : Form
    {
        SqlConnection connection;

        public Reg(SqlConnection connection)
        {
            this.connection = connection;
            InitializeComponent();
        }

        private void roundBTN2_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();

            this.Hide();

            form.Show();

            this.connection.Close();
        }

        private void roundBTN1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0 && textBox2.Text.Length > 0)
            {
                using (DialogForm dialogForm = new DialogForm())
                {
                    if (dialogForm.ShowDialog() == DialogResult.OK)
                    {
                        int rd = 0;

                        using (SqlCommand command = new SqlCommand("SELECT TOP 1 * FROM ПассажирыВход ORDER BY ID_Пассажира DESC", connection))
                        {
                            SqlDataReader reader = command.ExecuteReader();
                            if (reader.Read())
                            {
                                rd = reader.GetInt32(0) + 1;
                            }
                            reader.Close();
                        }

                        string log = textBox1.Text.ToString();
                        string pas = textBox2.Text.ToString();

                        string[] date = dialogForm.getInfo();
                        string query = $"INSERT INTO [ПассажирыВход] VALUES (@value0, " +
                            $"@value1, " +
                            $"@value2);" +
                            $"INSERT INTO [Пассажиры] VALUES (" +
                            $"@value3, " +
                            $"@value4, " +
                            $"@value5, " +
                            $"@value6, " +
                            $"@value7, " +
                            $"@value8, " +
                            $"@value9, " +
                            $"@value10)";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@value0", rd.ToString());
                            command.Parameters.AddWithValue("@value1", log);
                            command.Parameters.AddWithValue("@value2", pas);
                            command.Parameters.AddWithValue("@value3", rd.ToString());
                            command.Parameters.AddWithValue("@value4", date[0].ToString());
                            command.Parameters.AddWithValue("@value5", date[1].ToString());
                            command.Parameters.AddWithValue("@value6", date[2].ToString());
                            command.Parameters.AddWithValue("@value7", date[3].ToString());
                            command.Parameters.AddWithValue("@value8", date[4].ToString());
                            command.Parameters.AddWithValue("@value9", date[5].ToString());
                            command.Parameters.AddWithValue("@value10", date[6].ToString());
                            command.ExecuteNonQuery();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Такого аккаунта не существует!",
                    "Сообщение",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly
                );
            }
        }
    }
}
