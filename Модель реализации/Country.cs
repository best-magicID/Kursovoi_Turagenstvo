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
    public partial class Country : Form
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

        public Country()
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

                    //string query = "SELECT id_страны AS id, Страна FROM `Страны` WHERE 1";

                    string query = "SELECT id_страны AS 'ID страны', Страна FROM Страны";
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


        private async void Button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = await Task.Run(() => GetData());
            button1.Text = "Обновить список стран";
        }

        private async void Button2_Click(object sender, EventArgs e)
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

                        int id_страны = Convert.ToInt32(dataGridView1.Rows[indRow].Cells[0].Value);

                        string query = "DELETE FROM Страны WHERE id_страны = '" + id_страны.ToString() + "'";
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

        private void ЗакрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
