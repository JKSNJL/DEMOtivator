using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DEMOtivator
{
    public partial class Verification : Form
    {
        //регион, отвечающий за публичные данные 
        #region Connection

        static string _host = "Server=127.0.0.1;Database=MasterFloor;User ID=root;Password=;";
        MySqlConnection _connection = new MySqlConnection(_host);

        #endregion

        public Verification()
        {
            InitializeComponent();
        }
        //метод, при загрузке формы проверяет подключение
        private void VerificationLoad(object sender, EventArgs e)
        {
            try
            {
                _connection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                _connection.Close();
            }
        }
        //кнопка, сверяющая данные для входа
        private void btnEnterClick(object sender, EventArgs e)
        {
            _connection.Open();

            string login = fieldLogin.Text.Trim();
            string password = fieldPassword.Text.Trim();
            string cmdText = $"SELECT COUNT(*) FROM `users` WHERE `login`=@login AND `password`=@password";


            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Пожалуйста, заполните все поля.");
                return;
            }

            MySqlCommand command = new MySqlCommand(cmdText, _connection);
            command.Parameters.AddWithValue("@login", login);
            command.Parameters.AddWithValue("@password", password);

            if (Convert.ToInt32(command.ExecuteScalar()) > 0)
            {
                AccessEntering();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль");
            }

            _connection.Close();
        }
        //метод перехода на другую форму
        private void AccessEntering()
        {
            this.Hide();

            Form main = new MasterFloor();
            main.FormClosed += (s, args) => this.Close();
            main.Show();
        }
        //кнопка, записывающая новые данные
        private void btnRegistrationClick(object sender, EventArgs e)
        {
            _connection.Open();

            string login = fieldLogin.Text.Trim();
            string password = fieldPassword.Text.Trim();
            string cmdText = $"INSERT INTO `users`(`login`, `password`) VALUES ('{login}','{password}')";

            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Пожалуйста, заполните все поля.");
                return;
            }

            MySqlCommand command = new MySqlCommand(cmdText, _connection);
            command.ExecuteNonQuery();

            fieldLogin.Text = "";
            fieldPassword.Text = "";
            tabControl.SelectTab(0);

            _connection.Close();
        }
    }
}