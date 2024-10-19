using System;
using System.Data;
using System.Windows.Forms;

namespace Transactions
{
    public partial class Form1 : Form
    {
        // Экземпляр класса Database
        Database database = new Database();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Загрузка транзакций при загрузке формы
            LoadTransactions();
        }

        private void buttonAddTransaction_Click(object sender, EventArgs e)
        {
            // Получаем сумму из текстового поля
            double amount;
            string type = comboBoxTransactionType.SelectedItem.ToString(); // Получаем тип транзакции
            string description = textBoxDescription.Text; // Получаем описание

            if (double.TryParse(textBoxAmount.Text, out amount))
            {
                // Вставляем транзакцию в базу данных
                database.AddTransaction(type, amount, description, DateTime.Now.ToString("yyyy-MM-dd"));

                // Обновляем таблицу транзакций
                LoadTransactions();
            }
            else
            {
                MessageBox.Show("Введите корректную сумму.");
            }
        }

        private void buttonDeleteTransaction_Click(object sender, EventArgs e)
        {
            if (dataGridViewTransactions.SelectedRows.Count > 0)
            {
                // Получаем id выбранной строки
                int id = Convert.ToInt32(dataGridViewTransactions.SelectedRows[0].Cells["id"].Value);

                // Вызываем метод удаления записи
                database.DeleteTransaction(id);

                // Обновляем таблицу транзакций
                LoadTransactions();
            }
            else
            {
                MessageBox.Show("Выберите запись для удаления.");
            }
        }

        private void LoadTransactions()
        {
            // Загрузка данных из базы данных и отображение их в DataGridView
            DataTable dataTable = database.GetTransactions();
            dataGridViewTransactions.DataSource = dataTable;
        }
    }
}
