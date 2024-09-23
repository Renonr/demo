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
    public partial class Pas : Form
    {
        SqlConnection connection;
        string userID;

        public Pas(SqlConnection connection, string userID)
        {
            this.connection = connection;
            this.userID = userID;
            InitializeComponent();
        }

        private void Pas_Load(object sender, EventArgs e)
        {

        }

        private void roundBTN1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();

            this.Hide();

            form.Show();

            this.connection.Close();
        }

        private void roundBTN3_Click(object sender, EventArgs e)
        {
            Console.WriteLine(userID);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(
                $"SELECT * FROM [Билеты] WHERE [ID_Пассажира] = {userID}", this.connection);
            DataSet dataSet = new DataSet();

            dataAdapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];
        }

        private void roundBTN2_Click(object sender, EventArgs e)
        {
            Console.WriteLine(userID);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(
                $"SELECT * FROM [Рейсы] WHERE [ID_Рейса] IN" +
                $" (SELECT [ID_Рейса] FROM [Билеты] WHERE [ID_Пассажира] = { userID })", this.connection);
            DataSet dataSet = new DataSet();

            dataAdapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];
        }

        private void roundBTN4_Click(object sender, EventArgs e)
        {
            using (DialogFormBuyPas dialogFormPas = new DialogFormBuyPas(connection)) { 
                if (dialogFormPas.ShowDialog() == DialogResult.OK)
                {
                    int rd = 0;

                    using (SqlCommand command = new SqlCommand("SELECT TOP 1 * FROM Билеты ORDER BY ID_Билета DESC", connection))
                    {
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            rd = reader.GetInt32(0) + 1;
                        }
                        reader.Close();
                    }

                    string date = dialogFormPas.getFly();
                    string query = $"INSERT INTO [Билеты] VALUES (@value0, " +
                        $"@value1, " +
                        $"@value2);";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@value0", rd.ToString());
                        command.Parameters.AddWithValue("@value1", userID);
                        command.Parameters.AddWithValue("@value2", date);
                        command.ExecuteNonQuery();
                    }
                }
            }
        }
    }
}
