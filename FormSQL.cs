using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PharmacyDataBase
{
    public partial class FormSQL : Form
    {
        public FormSQL()
        {
            InitializeComponent();
        }

        private static FormSQL f;

        public static FormSQL fs
        {
            get
            {
                if (f == null || f.IsDisposed) f = new FormSQL();
                return f;
            }
        }

        public void ShowForm()
        {
            Show();
            Activate();
        }

        //объявляем метод, на вход подаем строку запроса, а возвращаем объект DataTable
        DataTable FillDataGridView(string sqlSelect)
        {
            SqlConnection connection = new SqlConnection(Properties.Settings.Default.PharmacyConnectionString);
            //Создаем объект command для SQL команды
            SqlCommand command = connection.CreateCommand();
            //Заносим текст SQL запроса через параметр sqlSelect
            command.CommandText = sqlSelect;
            //Создаем объект adapter класса SqlDataAdapter
            SqlDataAdapter adapter = new SqlDataAdapter();
            //Задаем адаптеру нужную команду, в данном случае команду Select
            adapter.SelectCommand = command;
            //Создаем объект table для последующего отображения результата запроса
             DataTable table = new DataTable();
            //заполним набор данных результатом запроса
            adapter.Fill(table);
            return table;
        }

        private void radioButtonEmployee_CheckedChanged(object sender, EventArgs e)
        {
           dataGridViewSelect.DataSource = FillDataGridView("SELECT * FROM Сотрудник");
        }

        private void radioButtonItems_CheckedChanged(object sender, EventArgs e)
        {
            dataGridViewSelect.DataSource = FillDataGridView(@"SELECT ID_Товара, Название, 
            CAST(Цена AS decimal(16,2)) AS [Текущая цена], CAST(Цена*1.5 AS decimal(16,2)) AS [Повышение цены на 50%] FROM Товар");
        }

        private void radioButtonOrders_CheckedChanged(object sender, EventArgs e)
        {
            dataGridViewSelect.DataSource = FillDataGridView(@"SELECT ID_Заказа, Сотрудник.ID_сотрудника, 
            Фамилия+' '+Имя+' '+Отчество AS ФИО FROM Заказ, Сотрудник WHERE Заказ.ID_сотрудника = Сотрудник.ID_сотрудника");
        }

        private void buttonF_Select_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxEmployee.Text))
            {
                MessageBox.Show("Обязательно укажите фамилию необходимого сотрудника.\nДопустим ввод первых символов.", 
                "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (checkBoxMore.Checked && String.IsNullOrEmpty(textBoxMore.Text))
            {
                MessageBox.Show("Не указана прибыль в условии", "Внимание!",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                checkBoxMore.Checked = false;
                return;
            }
            string sqlSelect = "";
            if (radioButtonDet_Orders.Checked)
                sqlSelect = @"SELECT w.ID_Сотрудника, Фамилия, Имя, Отчество, s.ID_Заказа,
                CAST(Sum(Количество*Цена) AS decimal(16,2)) AS Прибыль FROM Сотрудник w,
                Заказ s, Товары_в_заказе ds, Товары d WHERE Фамилия LIKE @last_name AND w.ID_Сотрудника = s.ID_Сотрудника AND 
                s.ID_Заказа = ds.ID_Заказа AND ds.ID_Товара = d.ID_Товара GROUP BY w.ID_Сотрудника, Фамилия, Имя, Отчество, s.ID_Заказа";
            else
                sqlSelect = @"SELECT Сотрудник.ID_Сотрудника, Фамилия, Имя, Отчество, 
                CAST(Sum(Количество*Цена) AS decimal(16,2)) AS Прибыль FROM Сотрудник INNER JOIN 
                Заказ ON Сотрудник.ID_Сотрудника=Заказ.ID_Сотрудника INNER JOIN Товары_в_заказе ON Заказ.ID_Заказа=Товары_в_заказе.ID_Заказа 
                INNER JOIN Товары ON Товары_в_заказе.ID_товара=Товары.ID_товара AND Фамилия LIKE @last_name
                GROUP BY Сотрудник.ID_Сотрудника, Фамилия, Имя, Отчество";

            if (checkBoxMore.Checked)
                sqlSelect += " HAVING Sum(Количество*Цена*(1-Скидка)) >@amount";
            if (checkBoxOrder.Checked)
                sqlSelect += " ORDER BY Sum(Количество*Цена*(1-Скидка)) desc";
            SqlConnection connection = new SqlConnection(Properties.Settings.Default.PharmacyConnectionString);
            SqlCommand command = connection.CreateCommand();
            command.CommandText = sqlSelect;
            command.Parameters.AddWithValue("@last_name", textBoxEmployee.Text + "%");
            if (checkBoxMore.Checked)
                try
                {
                    command.Parameters.Add("@amount", SqlDbType.Money).Value = Double.Parse(textBoxMore.Text);
                }
                catch
                {
                    MessageBox.Show("Прибыль в условии должна быть задана числом!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                   
                    checkBoxMore.Checked = false;
                    return;
                }
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridViewFSelect.DataSource = table;
            if (table.Rows.Count == 0) MessageBox.Show("Нет значений!", "Информация!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonSubquery_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxNumber.Text))
            {
                MessageBox.Show("Обязательно укажите номер необходимой продажи!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string sqlSelect = "";

            if (radioButtonCorrelated.Checked)
                sqlSelect = @"SELECT Товары_в_заказе.ID_Заказа, Товары_в_заказе.ID_Товара, (SELECT Название+'. Тип - '+Тип FROM Товары WHERE ID_Товара = Товары_в_заказе.ID_Товара) AS Товар,
                CAST(Количество*Цена*(1-Скидка) AS decimal(16,2)) AS Стоимость, (SELECT Фамилия+' '+Имя+' '+Отчество FROM Сотрудник WHERE ID_Сотрудника 
                IN (SELECT ID_Сотрудника FROM Заказ WHERE ID_Заказа=Товары_в_заказе.ID_Заказа)) AS Оформил_сотрудник FROM Товары_в_заказе WHERE ID_Заказа = @number";
            else
            if (radioButtonNoCorrelated.Checked)
                sqlSelect = @"SELECT * FROM Товары_в_заказе WHERE ID_Заказа = @number AND Цена > (SELECT AVG(Цена) FROM Товары_в_заказе)";
            else
            {
                MessageBox.Show("Не выбрали вид подзапроса!", "Ошибка!",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SqlConnection connection = new
           SqlConnection(Properties.Settings.Default.PharmacyConnectionString);
            SqlCommand command = connection.CreateCommand();
            command.CommandText = sqlSelect;
            try
            {
                command.Parameters.Add("@number", SqlDbType.Int).Value = int.Parse(textBoxNumber.Text);
            }
            catch
            {
                MessageBox.Show("Номер продажи в условии должен быть задан числом!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
            }
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridViewSubquery.DataSource = table;
            if (table.Rows.Count == 0) MessageBox.Show("Нет значений!", "Информация!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
