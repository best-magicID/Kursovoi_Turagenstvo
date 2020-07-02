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
    public partial class addHotel : Form
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

        public addHotel()
        {
            InitializeComponent();
        }

        private void AddHotel_Load(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(db.ConnectionString))
                {
                    sql = "SELECT Город FROM Города";
                    conn.Open();

                    cmd = new MySqlCommand(sql, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    comboBox1.Items.Clear();
                    while (reader.Read())
                    {
                        comboBox1.Items.Add(reader["Город"].ToString());
                    }
                    reader.Close();
                    comboBox1.Text = "Выберите город";
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Проблемы с подключением к БД \n\r" + ex.ToString());
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(db.ConnectionString))
                {
                    int getNumCity()
                    {
                        MySqlDataReader reader;
                        string sql = "SELECT id_города FROM Города WHERE Город = " +
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

                    string query = "INSERT INTO Отели (Отель, Город, Описание) VALUES('" + textBox1.Text + "','" + getNumCity().ToString() + "','" + textBox2.Text + "')";

                    conn.Open();
                    cmd = new MySqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Отель добавлен", "", MessageBoxButtons.OK);
                    textBox1.Text = "";
                    textBox2.Text = "";
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
