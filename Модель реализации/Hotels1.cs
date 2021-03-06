﻿using MySql.Data.MySqlClient;
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
    public partial class Hotels1 : Form
    {

        MySqlCommand cmd;
        MySqlDataReader reader;
        MySqlConnectionStringBuilder db = new MySqlConnectionStringBuilder
        {
            Server = "pgsha.ru",
            UserID = "soft0008",
            Password = "b2TAEsRu",
            Database = "soft0008",
            Port = 35006,
            CharacterSet = "utf8"
        };

        public Hotels1()
        {
            InitializeComponent();
        }

        private DataTable GetData()
        {
            DataTable dt = new DataTable();
            try
            {
                using (MySqlConnection conn = new MySqlConnection(db.ConnectionString))
                {
                    MessageBox.Show("Пожалуйста подождите, список загружается!", "Напоминание", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //string query = "SELECT * FROM `Отели` WHERE 1";
                    string query =
                        "SELECT Отели.id_отеля AS 'ID отеля', Отели.Отель, Города.Город AS 'Находится в городе:', Отели.Описание " +
                        "FROM Отели " +
                        "INNER JOIN Города ON Отели.Город = id_города";

                    cmd = new MySqlCommand(query, conn);
                    conn.Open();
                    reader = cmd.ExecuteReader();
                    dt.Load(reader);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Проблемы с подключением к БД \n\r" + ex.ToString());
            }
            return dt;
        }


        private async void Button1_ClickAsync(object sender, EventArgs e)
        {
            dataGridView1.DataSource = await Task.Run(() => GetData());
            button1.Text = "Обновить список отелей";
        }


        private async void Button2_ClickAsync(object sender, EventArgs e)
        {
            try
            {
                DialogResult rsl = MessageBox.Show("Вы действительно хотите удалить?", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // если пользователь нажал кнопку да 
                if (rsl == DialogResult.Yes)
                {
                    using (MySqlConnection conn = new MySqlConnection(db.ConnectionString))
                    {
                        conn.Open();
                        int indRow = dataGridView1.CurrentRow.Index; // узнаём текущую строку

                        int id_отеля = Convert.ToInt32(dataGridView1.Rows[indRow].Cells[0].Value);

                        string query = "DELETE FROM Отели WHERE id_отеля = '" + id_отеля.ToString() + "'";
                        cmd = new MySqlCommand(query, conn);
                        cmd.ExecuteNonQuery();
                        conn.Close();

                        dataGridView1.DataSource = await Task.Run(() => GetData());
                        MessageBox.Show("Запись удалена.\nОбновите список.", "Уведомление", MessageBoxButtons.OK);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Проблемы с подключением к БД \n\r" + ex.ToString());
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}
