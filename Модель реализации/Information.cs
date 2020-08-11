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
    public partial class Information : Form
    {
        public Information()
        {
            InitializeComponent();
            textBox1.Text = "Приложение предназначено для сотрудника туристического агенства. \r\n " +
                "Возможности: \r\n" +
                "1) Добавление новой заявки, её обработка и хранение. \r\n" +
                "2) Добавление отелей, городов и стран.\r\n\r\n" +
                "Разработали: код - Полчихин А.А. и  интерфейс - Шаров М.И.\r\n" +
                "Группа: ПИНб-31\r\n" +
                "2020 год";
        }

        private void ЗакрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
