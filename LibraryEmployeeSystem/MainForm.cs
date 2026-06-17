using System;
using System.Drawing;
using System.Windows.Forms;

namespace LibraryEmployeeSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.Text = "Система библиотеки - Сотрудник";
            this.Size = new Size(900, 650);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.FromArgb(30, 30, 40);
            this.ForeColor = Color.White;

            // Title
            Label title = new Label
            {
                Text = "БИБЛИОТЕЧНАЯ СИСТЕМА",
                Font = new Font("Segoe UI", 24, FontStyle.Bold),
                ForeColor = Color.FromArgb(0, 255, 200),
                AutoSize = true,
                Location = new Point(250, 20)
            };
            this.Controls.Add(title);

            // Tabs
            TabControl tabControl = new TabControl
            {
                Location = new Point(20, 80),
                Size = new Size(850, 500),
                BackColor = Color.FromArgb(45, 45, 60)
            };

            TabPage booksTab = new TabPage("Книги");
            booksTab.BackColor = Color.FromArgb(35, 35, 50);
            tabControl.TabPages.Add(booksTab);

            TabPage readersTab = new TabPage("Читатели");
            readersTab.BackColor = Color.FromArgb(35, 35, 50);
            tabControl.TabPages.Add(readersTab);

            TabPage issueTab = new TabPage("Выдача книг");
            issueTab.BackColor = Color.FromArgb(35, 35, 50);
            tabControl.TabPages.Add(issueTab);

            this.Controls.Add(tabControl);

            Button btnAddBook = new Button
            {
                Text = "Добавить книгу",
                Location = new Point(50, 150),
                Size = new Size(180, 50),
                BackColor = Color.FromArgb(0, 180, 140),
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 12)
            };
            booksTab.Controls.Add(btnAddBook);

            MessageBox.Show("Приложение запущено! Это демо-версия курсовой работы.", "Добро пожаловать", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}