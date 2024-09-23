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
            string query = $"SELECT * FROM [�������������] AS t WHERE t.[�����] = @value1 AND t.[������] = @value2";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@value1", "as");
            command.Parameters.AddWithValue("@value2", "as");

            // ��������� ������ � �������� ���������
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                Assert.AreEqual(2, reader["ID_���������"]);
            }
        }

        [TestMethod]
        public void TestMethod4()
        {
            string query = $"SELECT * FROM [�������������] AS t WHERE t.[ID_���������] = @value1";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@value1", "2");

            // ��������� ������ � �������� ���������
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                Assert.AreEqual("as", reader["�����"]);
            }
        }

        [TestMethod]
        public void TestMethod5()
        {
            string query = $"SELECT TOP 1 * FROM ������ ORDER BY ID_������ DESC";

            SqlCommand command = new SqlCommand(query, connection);

            // ��������� ������ � �������� ���������
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                Assert.AreEqual(4, reader["ID_������"]);
            }
        }

        [TestMethod]
        public void TestMethod6()
        {
            string query = $"SELECT TOP 1 * FROM ������ ORDER BY ID_��������� DESC";

            SqlCommand command = new SqlCommand(query, connection);

            // ��������� ������ � �������� ���������
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                Assert.AreEqual(629, reader["ID_���������"]);
            }
        }

        [TestMethod]
        public void TestMethod7()
        {
            string query = $"SELECT TOP 1 * FROM ������ ORDER BY ID_����� DESC";

            SqlCommand command = new SqlCommand(query, connection);

            // ��������� ������ � �������� ���������
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                Assert.AreEqual(3, reader["ID_�����"]);
            }
        }

        [TestMethod]
        public void TestMethod8()
        {
            string query = $"SELECT TOP 1 * FROM ������ ORDER BY ID_������ ASC";

            SqlCommand command = new SqlCommand(query, connection);

            // ��������� ������ � �������� ���������
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                Assert.AreEqual(1, reader["ID_������"]);
            }
        }

        [TestMethod]
        public void TestMethod9()
        {
            string query = $"SELECT TOP 1 * FROM ������ ORDER BY ID_��������� ASC";

            SqlCommand command = new SqlCommand(query, connection);

            // ��������� ������ � �������� ���������
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                Assert.AreEqual(2, reader["ID_���������"]);
            }
        }

        [TestMethod]
        public void TestMethod_10()
        {
            string query = $"SELECT TOP 1 * FROM ������ ORDER BY ID_����� ASC";

            SqlCommand command = new SqlCommand(query, connection);

            // ��������� ������ � �������� ���������
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                Assert.AreEqual(1, reader["ID_�����"]);
            }
        }
    }
}