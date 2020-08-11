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
    public partial class addRequest : Form
    {
        string sql1, sql2, sql3;
        MySqlCommand cmd1, cmd2, cmd3;
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

        private void Button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "**.**.****";
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e) // список городов
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(db.ConnectionString))
                {
                    int getNumCountry()
                    {
                        MySqlDataReader reader;
                        string sql = "SELECT id_страны FROM Страны WHERE Страна = " +
                        "'" + comboBox1.SelectedItem + "'";

                        conn.Open();
                        cmd1 = new MySqlCommand(sql, conn);
                        reader = cmd1.ExecuteReader();
                        reader.Read();
                        int numId = Convert.ToInt32(reader[0]); // номер группы
                        reader.Close();
                        conn.Close();
                        return numId;
                    }

                    sql2 = "SELECT Город FROM Города WHERE Страна = '" + getNumCountry().ToString() + "'";
                    conn.Open();
                    cmd2 = new MySqlCommand(sql2, conn);
                    MySqlDataReader reader2 = cmd2.ExecuteReader();
                    comboBox2.Items.Clear();
                    while (reader2.Read())
                    {
                        comboBox2.Items.Add(reader2["Город"].ToString());
                    }
                    reader2.Close();
                    comboBox2.Text = "Выберите город";
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Проблемы с подключением к БД \n\r" + ex.ToString());
            }
        }

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e) //выбор города
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(db.ConnectionString))
                {
                    int getNumCity()
                    {
                        MySqlDataReader reader;
                        string sql = "SELECT id_города FROM Города WHERE Город = " +
                        "'" + comboBox2.SelectedItem + "'";

                        conn.Open();
                        cmd1 = new MySqlCommand(sql, conn);
                        reader = cmd1.ExecuteReader();
                        reader.Read();
                        int numId = Convert.ToInt32(reader[0]); // номер группы
                        reader.Close();
                        conn.Close();
                        return numId;
                    }

                    sql3 = "SELECT Отель FROM Отели WHERE Город = '" + getNumCity().ToString() + "'";
                    conn.Open();
                    cmd3 = new MySqlCommand(sql3, conn);
                    MySqlDataReader reader3 = cmd3.ExecuteReader();
                    comboBox3.Items.Clear();
                    while (reader3.Read())
                    {
                        comboBox3.Items.Add(reader3["Отель"].ToString());
                    }
                    reader3.Close();
                    comboBox3.Text = "Выберите отель";
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Проблемы с подключением к БД \n\r" + ex.ToString());
            }
        }

        public addRequest()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) // Добавление заявки
        {
            try
            {

                if (textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || comboBox1.Text == "" || comboBox2.Text == "" || comboBox3.Text == "Выберите отель" || comboBox3.Text == "")
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
                            cmd1 = new MySqlCommand(sql, conn);
                            reader = cmd1.ExecuteReader();
                            reader.Read();
                            int numId = Convert.ToInt32(reader[0]); // номер группы
                            reader.Close();
                            conn.Close();
                            return numId;
                        }

                        int getNumCity()
                        {
                            MySqlDataReader reader;
                            string sql = "SELECT id_города FROM Города WHERE Город = " +
                            "'" + comboBox2.SelectedItem + "'";

                            conn.Open();
                            cmd1 = new MySqlCommand(sql, conn);
                            reader = cmd1.ExecuteReader();
                            reader.Read();
                            int numId = Convert.ToInt32(reader[0]); // номер группы
                            reader.Close();
                            conn.Close();
                            return numId;
                        }

                        int getNumHotel()
                        {
                            MySqlDataReader reader;
                            string sql = "SELECT id_отеля FROM Отели WHERE Отель = " +
                            "'" + comboBox3.SelectedItem + "'";

                            conn.Open();
                            cmd1 = new MySqlCommand(sql, conn);
                            reader = cmd1.ExecuteReader();
                            reader.Read();
                            int numId = Convert.ToInt32(reader[0]); // номер группы
                            reader.Close();
                            conn.Close();
                            return numId;
                        }

                        //string query = "INSERT INTO Заявки (Фамилия, Имя, Отчество, Страна, Город, Отель) VALUES(" +
                        //string query = "INSERT INTO Заявки (Фамилия, Имя, Отчество, Страна, Город, Отель, Способ_отправки, Количество_дней, Оплачен) VALUES(" +
                        string query = "INSERT INTO Заявки (Фамилия, Имя, Отчество, Страна, Город, Отель, Способ_отправки, Дата_отправки, Количество_дней, Оплачен) VALUES(" +
                            "'" + textBox2.Text + "'," +    //фамилия
                            "'" + textBox3.Text + "'," +    //имя
                            "'" + textBox4.Text + "'," +    //отчество
                            "'" + getNumCountry().ToString() + "'," + //страна
                            "'" + getNumCity().ToString() + "'," +   //город
                            "'" + getNumHotel().ToString() + "'," +  //отель
                            "'" + comboBox4.Text + "'," +   // Способ отправки
                            "'" + textBox5.Text + "'," +    //Дата отправки
                                                            //"'" + dateTimePicker1.ToString() + "'," +
                            "'" + Convert.ToString(comboBox5.Text) + "'," +   // кол-во
                            "'" + comboBox6.Text + "')";   // Способ отправки;

                        conn.Open();
                        cmd1 = new MySqlCommand(query, conn);
                        cmd1.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show("Заявка добавлена", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBox2.Text = "";
                        textBox3.Text = "";
                        textBox4.Text = "";
                    }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Проблемы с подключением к БД \n\r" + ex.ToString());
            }
        }

        private void ЗакрытьToolStripMenuItem_Click(object sender, EventArgs e) //закрытие формы
        {
            Close();
        }

        private void Form2_Load(object sender, EventArgs e) //запуск формы
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(db.ConnectionString))
                {
                    sql1 = "SELECT Страна FROM Страны";
                    conn.Open();
                    cmd1 = new MySqlCommand(sql1, conn);
                    MySqlDataReader reader1 = cmd1.ExecuteReader();
                    comboBox1.Items.Clear();
                    while (reader1.Read())
                    {
                        comboBox1.Items.Add(reader1["Страна"].ToString());
                    }
                    reader1.Close();
                    comboBox1.Text = "Выберите страну";
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Проблемы с подключением к БД \n\r" + ex.ToString());
            }
        }
    }
}
