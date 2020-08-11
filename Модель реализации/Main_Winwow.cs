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
    public partial class Main_Winwow : Form
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

        #region Kod
        public Main_Winwow()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void поискПоЗаявкамToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form4 = new listOfClients();
            form4.Show();
        }

        private void ДобавитьЗаявкуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form2 = new addRequest();
            form2.Show();
        }

        private void СправкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form5 = new Information();
            form5.Show();
        }

        private void КурортыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form3 = new Hotels1();
            form3.Show();
        }

        private void СтраныToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form MyCountry = new Country();
            MyCountry.Show();
        }

        private void ГородаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form MyCities = new Cities();
            MyCities.Show();
        }

        private void ДобавитьСтрануToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form MyAddCountry = new AddCountry();
            MyAddCountry.Show();
        }

        private void ДобавитьГородToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form MyAddCity = new addCity();
            MyAddCity.Show();
        }

        private void ДобавитьКурортToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form MyAddHotel = new addHotel();
            MyAddHotel.Show();
        }
        #endregion

        private void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(db.ConnectionString))
                {
                    conn.Open();
                    MessageBox.Show("Подключение к БД установлено", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Проблемы с подключением к БД \n\r" + ex.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        } //проверка соединения

        private DataTable GetData()
        {
            DataTable dt = new DataTable();
            try
            {
                using (MySqlConnection conn = new MySqlConnection(db.ConnectionString))
                {
                    MessageBox.Show("Пожалуйста подождите, список загружается!", "Напоминание", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //string query = "SELECT * FROM `Заявки` WHERE 1";

                    string query =
                        "SELECT Заявки.id_заявки AS 'ID заявки', Заявки.Фамилия, Заявки.Имя, Заявки.Отчество, " +
                        "Страны.Страна, Города.Город , Отели.Отель, " +
                        "Заявки.Способ_отправки AS 'Способ отправки', Заявки.Дата_отправки  AS 'Дата отправки', Заявки.Количество_дней AS 'Количество дней', Заявки.Оплачен " +
                        "FROM Заявки " +
                        "INNER JOIN Страны ON Заявки.Страна = id_страны " +
                        "INNER JOIN Города ON Заявки.Город = id_города " +
                        "INNER JOIN Отели ON Заявки.Отель = id_Отеля "; 

                    //рабочая версия
                    //string query = 
                    //    "SELECT Заявки.id_заявки AS ID, Заявки.Фамилия, Заявки.Имя, Заявки.Отчество, " +
                    //    "Страны.Страна AS id_страны, Города.Город AS id_города, Отели.Отель AS id_отеля, " +
                    //    "Заявки.Способ_отправки, Заявки.Дата_отправки, Заявки.Количество_дней, Заявки.Оплачен " +
                    //    "FROM Заявки " +
                    //    "INNER JOIN Страны ON Заявки.Страна = id_страны " +
                    //    "INNER JOIN Города ON Заявки.Город = id_города " +
                    //    "INNER JOIN Отели ON Заявки.Отель = id_Отеля "; 

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
        } // для показа таблицы

        private async void Button3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = await Task.Run(() => GetData());
        } //показать таблицу

        private void Button4_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
        } //очистить таблицу

        private void ВыходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult rsl = MessageBox.Show("Вы действительно хотите выйти из программы?", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // если пользователь нажал кнопку да 
            if (rsl == DialogResult.Yes)
            {
                // выходим из приложения 
                Application.Exit();
            }
        } //выход из приложения

        private async void Button5_Click(object sender, EventArgs e) //удаление заявки
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

                        int id_заявки = Convert.ToInt32(dataGridView1.Rows[indRow].Cells[0].Value);

                        string query = "DELETE FROM Заявки WHERE id_заявки = '" + id_заявки.ToString() + "'";
                        cmd = new MySqlCommand(query, conn);
                        cmd.ExecuteNonQuery();
                        conn.Close();

                        dataGridView1.DataSource = await Task.Run(() => GetData());
                        MessageBox.Show("Заявка удалена.\nОбновите список.", "Уведомление", MessageBoxButtons.OK);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Проблемы с подключением к БД \n\r" + ex.ToString());
            }
        }

        private void Main_Winwow_FormClosing(object sender, FormClosingEventArgs e)
        {
            //DialogResult rsl = MessageBox.Show("Вы действительно хотите выйти из программы?", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //if (rsl == DialogResult.Yes)
            //    Application.Exit();

        }
    }
}
