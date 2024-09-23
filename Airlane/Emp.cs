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
    public partial class Emp : Form
    {
        SqlConnection connection;
        string tableNow;

        public Emp(SqlConnection connection)
        {
            this.connection = connection;
            InitializeComponent();
        }

        private void roundBTN4_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();

            this.Hide();

            form.Show();

            this.connection.Close();
        }

        private void roundBTN3_Click(object sender, EventArgs e)
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter(
                "SELECT * FROM [Рейсы]", this.connection);
            DataSet dataSet = new DataSet();

            dataAdapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];

            tableNow = "Рейсы";
        }

        private void roundBTN2_Click(object sender, EventArgs e)
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter(
                "SELECT * FROM [Билеты]", this.connection);
            DataSet dataSet = new DataSet();

            dataAdapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];

            tableNow = "Билеты";
        }

        private void roundBTN5_Click(object sender, EventArgs e)
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter(
                "SELECT * FROM [Пассажиры]", this.connection);
            DataSet dataSet = new DataSet();

            dataAdapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];

            tableNow = "Пассажиры";
        }

        private void roundBTN7_Click(object sender, EventArgs e)
        {
            int upd = dataGridView1.SelectedCells[0].RowIndex;

            SqlCommand command1 = new SqlCommand();
            command1.Connection = this.connection;
            string c = $"INSERT INTO [{tableNow}]  VALUES (";

            foreach (DataGridViewCell cel in dataGridView1.Rows[upd].Cells)
            {
                //if (cel.ColumnIndex == 0)
                //{
                //    continue;
                //}
                c += $"'{ cel.Value}'" + ",";
            }
            c += ");";
            command1.CommandText = c.Remove(c.Length - 3, 1);
            int number = command1.ExecuteNonQuery();

            dataGridView1.EndEdit();
        }

        private void roundBTN8_Click(object sender, EventArgs e)
        {
            int upd = dataGridView1.SelectedCells[0].RowIndex;

            SqlCommand command1 = new SqlCommand();
            command1.Connection = this.connection;
            foreach (DataGridViewCell cel in dataGridView1.Rows[upd].Cells)
            {
                if (cel.ColumnIndex == 0)
                {
                    continue;
                }
                string c = $"UPDATE [{tableNow}] " +
                           $"SET [{cel.OwningColumn.DataPropertyName}]='{cel.Value}'" +
                           $" WHERE [{dataGridView1.Columns[0].DataPropertyName}]={dataGridView1.Rows[upd].Cells[0].Value}";
                command1.CommandText = c;
                int number = command1.ExecuteNonQuery();
            }

            dataGridView1.EndEdit();
        }

        private void roundBTN6_Click(object sender, EventArgs e)
        {
            int delet = dataGridView1.SelectedCells[0].RowIndex;

            SqlCommand command = new SqlCommand
            (
                $"DELETE FROM [{tableNow}] WHERE [{dataGridView1.Columns[0].DataPropertyName}]={dataGridView1.Rows[delet].Cells[0].Value}",
                this.connection
            );
            int number = command.ExecuteNonQuery();

            dataGridView1.Rows.RemoveAt(delet);
            dataGridView1.EndEdit();
        }
    }
}
