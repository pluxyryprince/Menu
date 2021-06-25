using System;
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;

namespace Menu
{
    public partial class UserRegistration : Form
    {
        public UserRegistration()
        {
            InitializeComponent();
        }

        private void UserRegistration_Load(object sender, EventArgs e)
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
            ConnectDatabase db = new ConnectDatabase();
     
            MySqlCommand command = new MySqlCommand("INSERT INTO `visitors` (`id`, `name`, `surname`, `thirdname`, `login`, `password`) VALUES (NULL, @name, @surname, @thirdname, @login, @password)", db.GetConnection());
            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = login.Text;
            command.Parameters.Add("@password", MySqlDbType.VarChar).Value = password.Text;
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = NName.Text;
            command.Parameters.Add("@surname", MySqlDbType.VarChar).Value = Surname.Text;
            command.Parameters.Add("@thirdname", MySqlDbType.VarChar).Value = Thirdname.Text;

            db.OpenConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Учетная запись успешно создана!");
            }
            else
            {
                MessageBox.Show("Ошибка при создании учетной записи");
            }
            db.CloseConnection();

            ActiveForm.Hide();
            userAR user = new userAR();
            user.Show();
        }
    }
}
