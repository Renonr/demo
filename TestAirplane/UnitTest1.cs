using Airplane;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data.SqlClient;

namespace TestAirplane
{
    [TestClass]
    public class UnitTest1
    {
        private DataBase db = new DataBase();
        SqlConnection connection;
        [TestInitialize]
        public void Setup()
        {
            db.openConnection();
            connection = db.getConnection();
        }

        [TestMethod]
        public void TestMethod1()
        {
            bool response = connection.State.ToString() == "Open" ? true : false;
            Assert.IsTrue(response);
        }

        [TestMethod]
        public void TestMethod2()
        {
            db.closeConnection();
            bool response = connection.State.ToString() == "Open" ? true : false;
            Assert.IsFalse(response);
        }

        [TestMethod]
        public void TestMethod3()
        {
            string query = $"SELECT * FROM [ПассажирыВход] AS t WHERE t.[Логин] = @value1 AND t.[Пароль] = @value2";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@value1", "as");
            command.Parameters.AddWithValue("@value2", "as");

            // Выполняем запрос и получаем результат
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                Assert.AreEqual(2, reader["ID_Пассажира"]);
            }
        }

        [TestMethod]
        public void TestMethod4()
        {
            string query = $"SELECT * FROM [ПассажирыВход] AS t WHERE t.[ID_Пассажира] = @value1";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@value1", "2");

            // Выполняем запрос и получаем результат
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                Assert.AreEqual("as", reader["Логин"]);
            }
        }

        [TestMethod]
        public void TestMethod5()
        {
            string query = $"SELECT TOP 1 * FROM Билеты ORDER BY ID_Билета DESC";

            SqlCommand command = new SqlCommand(query, connection);

            // Выполняем запрос и получаем результат
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                Assert.AreEqual(4, reader["ID_Билета"]);
            }
        }

        [TestMethod]
        public void TestMethod6()
        {
            string query = $"SELECT TOP 1 * FROM Билеты ORDER BY ID_Пассажира DESC";

            SqlCommand command = new SqlCommand(query, connection);

            // Выполняем запрос и получаем результат
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                Assert.AreEqual(629, reader["ID_Пассажира"]);
            }
        }

        [TestMethod]
        public void TestMethod7()
        {
            string query = $"SELECT TOP 1 * FROM Билеты ORDER BY ID_Рейса DESC";

            SqlCommand command = new SqlCommand(query, connection);

            // Выполняем запрос и получаем результат
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                Assert.AreEqual(3, reader["ID_Рейса"]);
            }
        }

        [TestMethod]
        public void TestMethod8()
        {
            string query = $"SELECT TOP 1 * FROM Билеты ORDER BY ID_Билета ASC";

            SqlCommand command = new SqlCommand(query, connection);

            // Выполняем запрос и получаем результат
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                Assert.AreEqual(1, reader["ID_Билета"]);
            }
        }

        [TestMethod]
        public void TestMethod9()
        {
            string query = $"SELECT TOP 1 * FROM Билеты ORDER BY ID_Пассажира ASC";

            SqlCommand command = new SqlCommand(query, connection);

            // Выполняем запрос и получаем результат
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                Assert.AreEqual(2, reader["ID_Пассажира"]);
            }
        }

        [TestMethod]
        public void TestMethod_10()
        {
            string query = $"SELECT TOP 1 * FROM Билеты ORDER BY ID_Рейса ASC";

            SqlCommand command = new SqlCommand(query, connection);

            // Выполняем запрос и получаем результат
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                Assert.AreEqual(1, reader["ID_Рейса"]);
            }
        }
    }
}