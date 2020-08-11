namespace Модель_реализации
{
    partial class Main_Winwow
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьЗаявкуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьСтрануToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьГородToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьКурортToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.местаОтдыхаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.страныToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.городаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.курортыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поискПоЗаявкамToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокЗаявокBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.заявкиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.городаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.заявкиBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.списокЗаявокBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.заявкиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.городаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.заявкиBindingSource1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюToolStripMenuItem,
            this.местаОтдыхаToolStripMenuItem,
            this.поискПоЗаявкамToolStripMenuItem,
            this.справкаToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1161, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьЗаявкуToolStripMenuItem,
            this.добавитьСтрануToolStripMenuItem,
            this.добавитьГородToolStripMenuItem,
            this.добавитьКурортToolStripMenuItem});
            this.менюToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.менюToolStripMenuItem.Text = "Меню";
            // 
            // добавитьЗаявкуToolStripMenuItem
            // 
            this.добавитьЗаявкуToolStripMenuItem.Name = "добавитьЗаявкуToolStripMenuItem";
            this.добавитьЗаявкуToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.добавитьЗаявкуToolStripMenuItem.Text = "Добавить заявку";
            this.добавитьЗаявкуToolStripMenuItem.Click += new System.EventHandler(this.ДобавитьЗаявкуToolStripMenuItem_Click);
            // 
            // добавитьСтрануToolStripMenuItem
            // 
            this.добавитьСтрануToolStripMenuItem.Name = "добавитьСтрануToolStripMenuItem";
            this.добавитьСтрануToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.добавитьСтрануToolStripMenuItem.Text = "Добавить страну";
            this.добавитьСтрануToolStripMenuItem.Click += new System.EventHandler(this.ДобавитьСтрануToolStripMenuItem_Click);
            // 
            // добавитьГородToolStripMenuItem
            // 
            this.добавитьГородToolStripMenuItem.Name = "добавитьГородToolStripMenuItem";
            this.добавитьГородToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.добавитьГородToolStripMenuItem.Text = "Добавить город";
            this.добавитьГородToolStripMenuItem.Click += new System.EventHandler(this.ДобавитьГородToolStripMenuItem_Click);
            // 
            // добавитьКурортToolStripMenuItem
            // 
            this.добавитьКурортToolStripMenuItem.Name = "добавитьКурортToolStripMenuItem";
            this.добавитьКурортToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.добавитьКурортToolStripMenuItem.Text = "Добавить отель";
            this.добавитьКурортToolStripMenuItem.Click += new System.EventHandler(this.ДобавитьКурортToolStripMenuItem_Click);
            // 
            // местаОтдыхаToolStripMenuItem
            // 
            this.местаОтдыхаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.страныToolStripMenuItem,
            this.городаToolStripMenuItem,
            this.курортыToolStripMenuItem});
            this.местаОтдыхаToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.местаОтдыхаToolStripMenuItem.Name = "местаОтдыхаToolStripMenuItem";
            this.местаОтдыхаToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.местаОтдыхаToolStripMenuItem.Text = "Списки";
            // 
            // страныToolStripMenuItem
            // 
            this.страныToolStripMenuItem.Name = "страныToolStripMenuItem";
            this.страныToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.страныToolStripMenuItem.Text = "Страны";
            this.страныToolStripMenuItem.Click += new System.EventHandler(this.СтраныToolStripMenuItem_Click);
            // 
            // городаToolStripMenuItem
            // 
            this.городаToolStripMenuItem.Name = "городаToolStripMenuItem";
            this.городаToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.городаToolStripMenuItem.Text = "Города";
            this.городаToolStripMenuItem.Click += new System.EventHandler(this.ГородаToolStripMenuItem_Click);
            // 
            // курортыToolStripMenuItem
            // 
            this.курортыToolStripMenuItem.Name = "курортыToolStripMenuItem";
            this.курортыToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.курортыToolStripMenuItem.Text = "Отели";
            this.курортыToolStripMenuItem.Click += new System.EventHandler(this.КурортыToolStripMenuItem_Click);
            // 
            // поискПоЗаявкамToolStripMenuItem
            // 
            this.поискПоЗаявкамToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.поискПоЗаявкамToolStripMenuItem.Name = "поискПоЗаявкамToolStripMenuItem";
            this.поискПоЗаявкамToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.поискПоЗаявкамToolStripMenuItem.Text = "БД клиентов";
            this.поискПоЗаявкамToolStripMenuItem.Visible = false;
            this.поискПоЗаявкамToolStripMenuItem.Click += new System.EventHandler(this.поискПоЗаявкамToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            this.справкаToolStripMenuItem.Click += new System.EventHandler(this.СправкаToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.выходToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.выходToolStripMenuItem.Visible = false;
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.ВыходToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 111);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dataGridView1.Size = new System.Drawing.Size(1137, 327);
            this.dataGridView1.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Font = new System.Drawing.Font("Century Gothic", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(991, 82);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(158, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Проверка соеденения";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Century Gothic", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(12, 82);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(129, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Показать заявки";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Century Gothic", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(147, 82);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(132, 23);
            this.button4.TabIndex = 8;
            this.button4.Text = "Очистить таблицу";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1161, 51);
            this.panel1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(327, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(504, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Туристическое агентство";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(423, 82);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Изменить заявку";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Century Gothic", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(285, 82);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(132, 23);
            this.button5.TabIndex = 11;
            this.button5.Text = "Удалить заявку\r\n";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // Main_Winwow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1161, 450);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main_Winwow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Туристическое агентство";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_Winwow_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.списокЗаявокBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.заявкиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.городаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.заявкиBindingSource1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem поискПоЗаявкамToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource списокЗаявокBindingSource;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьСтрануToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьГородToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьКурортToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьЗаявкуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem местаОтдыхаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem страныToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem городаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem курортыToolStripMenuItem;
        private System.Windows.Forms.BindingSource заявкиBindingSource;
        private System.Windows.Forms.BindingSource городаBindingSource;
        private System.Windows.Forms.BindingSource заявкиBindingSource1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button5;
    }
}

