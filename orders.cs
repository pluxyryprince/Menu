using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Menu
{
    public partial class orders : Form
    {
        public orders()
        {
            InitializeComponent();
        }

        private string connect = "server=127.0.0.1;userid=root;password=root;database=menu_users;port=3306";
        private void orders_Load(object sender, EventArgs e)
        {
            this.FormClosing += MainForm_Closing;
        }
        private void MainForm_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        //переназначение крестика на форме чтобы он закрывал все формы сразу
        //на случай, если в ходе работы приложения было открыто более одной формы
        //если не переназначать эту кнопку, то приложение не сможет полностью закрыться, если было открыто более одной формы, т.к. другие формы останутся висеть в процессах
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection(connect);
                connection.Open();//соединение с бд
                MySqlCommand command = new MySqlCommand($"INSERT INTO `orders` (`id`, `name_user`, `dish`, `drink`, `place`) VALUES (NULL, '{name.Text}', '{dish.Text}', '{drink.Text}', '{place_num.Text}');")
                {
                    Connection = connection//команда для заполнения
                };
                command.ExecuteNonQuery();//выполнение команды
                MessageBox.Show("Заказ сделан! Время готовки - от 15 до 30 минут");
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка при формировании заказа");
            }
        }

        private void dish_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox dish = (ComboBox)sender;
        }

        private void drink_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox drink = (ComboBox)sender;
        }
    }
}
