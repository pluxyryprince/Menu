using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;

namespace Menu
{
    public partial class AuthorizationUser : Form
    {
        public AuthorizationUser()
        {
            InitializeComponent();
        }
        static public string role;
        private void button3_Click(object sender, EventArgs e)
        {
            string Login = log.Text;
            string Password = pass.Text;
            ConnectDatabase db = new ConnectDatabase();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `visitors` WHERE `login` = @login AND `password` = @password", db.GetConnection());
            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = Login;
            command.Parameters.Add("@password", MySqlDbType.VarChar).Value = Password;
            adapter.SelectCommand = command;
            adapter.Fill(table);
            MySqlDataAdapter users = new MySqlDataAdapter($"Select role From visitors", db.GetConnection());
            role = Convert.ToString(table.Rows[0][5]);
            if (table.Rows.Count > 0)
            {
                ActiveForm.Hide();
                cookStartFormAfterRegistrationOrAuthorization csForm = new cookStartFormAfterRegistrationOrAuthorization();
                csForm.Show();
            }
            else
                MessageBox.Show("No");

            ActiveForm.Hide();
            userAR usstfrm = new userAR();
            usstfrm.Show();
        }
        private void MainForm_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        //переназначение крестика на форме чтобы он закрывал все формы сразу
        //на случай, если в ходе работы приложения было открыто более одной формы
        //если не переназначать эту кнопку, то приложение не сможет полностью закрыться, если было открыто более одной формы, т.к. другие формы останутся висеть в процессах
        {
            Application.Exit();
        }

        private void AuthorizationUser_Load(object sender, EventArgs e)
        {
            this.FormClosing += MainForm_Closing;
        }
    }
}
