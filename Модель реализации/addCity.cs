using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Модель_реализации
{
    public partial class addCity : Form
    {
        string sql;
        MySqlCommand cmd;
        MySqlConnection conn;
        MySqlConnectionStringBuilder db = new MySqlConnectionStringBuilder
        {
            Server = "pgsha.ru",
            UserID = "soft0008",
            Password = "b2TAEsRu",
            Database = "soft0008",
            Port = 35006,
            CharacterSet = "utf8"
        };

        public addCity()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "")
                {
                    MessageBox.Show("Введите значения", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    using (MySqlConnection conn = new MySqlConnection(db.ConnectionString))
                    {
                        int getNumCountry()
                        {
                            MySqlDataReader reader;
                            string sql = "SELECT id_страны FROM Страны WHERE Страна = " +
                            "'" + comboBox1.SelectedItem + "'";

                            conn.Open();
                            cmd = new MySqlCommand(sql, conn);
                            reader = cmd.ExecuteReader();
                            reader.Read();
                            int numId = Convert.ToInt32(reader[0]); // номер группы
                            reader.Close();
                            conn.Close();
                            return numId;
                        }

                        string query = "INSERT INTO Города (Город, Страна) VALUES('" + textBox1.Text + "'" + ",'" + getNumCountry().ToString() + "')";

                        conn.Open();
                        cmd = new MySqlCommand(query, conn);
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show("Город добавлен", "", MessageBoxButtons.OK);
                        textBox1.Text = "";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Проблемы с подключением к БД \n\r" + ex.ToString());
            }
        }

        private void AddCity_Load(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(db.ConnectionString))
                {
                    sql = "SELECT Страна FROM Страны";
                    conn.Open();

                    cmd = new MySqlCommand(sql, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    comboBox1.Items.Clear();
                    while (reader.Read())
                    {
                        comboBox1.Items.Add(reader["Страна"].ToString());
                    }
                    reader.Close();
                    comboBox1.Text = "Список стран";
                    conn.Clone();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Проблемы с подключением к БД \n\r" + ex.ToString());
            }
        }

        private void ЗакрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
