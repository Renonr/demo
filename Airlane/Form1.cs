using Airplane;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox2.PasswordChar = '*';
        }


        public void roundBTN1_Click(object sender, EventArgs e)
        {
            string log = textBox1.Text;
            string pas = textBox2.Text;

            if (log == "Admin" && pas == "Admin")
            {
                DataBase dataBase = new DataBase(log, pas);
                dataBase.openConnection();

                Adm adm = new Adm(dataBase.getConnection());
                adm.Show();
                this.Hide();
            }
            else if (log == "Emp" && pas == "Emp")
            {
                DataBase dataBase = new DataBase(log, pas);
                dataBase.openConnection();

                Emp emp = new Emp(dataBase.getConnection());
                emp.Show();
                this.Hide();
            }
            else
            {
                DataBase dataBase = new DataBase();
                dataBase.openConnection();

                string query = $"SELECT * FROM [ПассажирыВход] AS t WHERE t.[Логин] = @value1 AND t.[Пароль] = @value2";

                SqlCommand command = new SqlCommand(query, dataBase.getConnection());
                command.Parameters.AddWithValue("@value1", log);
                command.Parameters.AddWithValue("@value2", pas);

                // Выполняем запрос и получаем результат
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    string userID = reader["ID_Пассажира"].ToString();
                    reader.Close();

                    Pas pass = new Pas(dataBase.getConnection(), userID);
                    pass.Show();
                    this.Hide();
                }
                else
                {
                    dataBase.closeConnection();
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


        private void label4_Click(object sender, EventArgs e)
        {
            DataBase dataBase = new DataBase();
            dataBase.openConnection();
            Reg reg = new Reg(dataBase.getConnection());

            reg.Show();
            this.Hide();
        }
    }
}
