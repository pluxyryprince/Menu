using MySql.Data.MySqlClient;

namespace Menu
{
    class ConnectDatabase
    {

        MySqlConnection connection = new MySqlConnection("server=127.0.0.1;userid=root;password=root;database=menu_users;port=3306");

        public void OpenConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        public void CloseConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }

        public MySqlConnection GetConnection() => connection;
    }
}
