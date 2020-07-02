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
    public partial class Form1 : Form
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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void поискПоЗаявкамToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form4 = new Form4();
            form4.Show();
        }

        private void ДобавитьЗаявкуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form2 = new Form2();
            form2.Show();
        }

        private void СправкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form5 = new Form5();
            form5.Show();
        }

        private void КурортыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form3 = new Form3();
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
                    MessageBox.Show("Подключение к БД установлено");
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Проблемы с подключением к БД \n\r" + ex.ToString());
            }
        } //проверка соединения

        private DataTable GetData()
        {
            DataTable dt = new DataTable();
            try
            {
                using (MySqlConnection conn = new MySqlConnection(db.ConnectionString))
                {
                    //string query = "SELECT * FROM `Заявки` WHERE 1";
                    string query = "SELECT `id_заявки`, `Фамилия`, `Имя`, `Отчество`, `Страны.Страна`, `Город`, `Отель`, `Способ_отправки`, `Дата_отправки`, `Количество_дней`, `Оплачен` FROM `Заявки`, Страны, Города, Отели WHERE 1";
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
        } //метод для показания 

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
    }
}
