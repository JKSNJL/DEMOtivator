using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DEMOtivator
{
    public partial class MasterFloor : Form
    {
        //регион, отвечающий за публичные данные 
        #region Connection 

        static string _host = "server=127.0.0.1;database=masterfloor;user=root;password=";
        MySqlConnection _connection = new MySqlConnection(_host);
        string _tableName;
        DataTable _table;

        #endregion

        public MasterFloor()
        {
            InitializeComponent();
        }
        //метод, при загрузке формы проверяет подключение
        private void MasterFloorLoad(object sender, EventArgs e)
        {
            try
            {
                _connection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка подключения: " + ex.Message);
                Application.Exit();
            }
            finally
            {
                _connection.Close();
                tablePick.SelectedIndex = 0;
            }
        }
        //метод, возвращающий значение адаптера
        private MySqlDataAdapter Connecting(string tableName)
        {
            return new MySqlDataAdapter($"SELECT * FROM `{tableName}`", _connection);
        }
        //метод, отображающий таблицу
        private void ShowTable(string tableName)
        {
            MySqlDataAdapter adapter = Connecting(_tableName);

            DataTable table = new DataTable();
            _table = table;
            adapter.Fill(table);
            adapter.Dispose();

            dbTable.DataSource = table;

            dbTable.AutoResizeColumns();
            dbTable.AutoResizeRows();
        }
        //метод выбора отображения таблицы, активирующийся событием выбора значения
        private void TablePickSelectedIndexChanged(object sender, EventArgs e)
        {
            _tableName = tablePick.GetItemText(tablePick.SelectedItem);
            ShowTable(_tableName);
        }
        //кнопка обновления и редактирования таблицы
        private void ButtonUpdateClick(object sender, EventArgs e)
        {
            _connection.Open();

            MySqlDataAdapter adapter = Connecting(_tableName);

            MySqlCommandBuilder builder = new MySqlCommandBuilder(adapter);
            adapter.SelectCommand.UpdatedRowSource = UpdateRowSource.FirstReturnedRecord;
            adapter.Update(_table);

            ShowTable(_tableName);

            _connection.Close();
        }
        //кнопка удаления записи таблицы
        private void ButtonDeleteClick(object sender, EventArgs e)
        {
            _connection.Open();

            MySqlDataAdapter adapter = Connecting(_tableName);

            try
            {
                var rowIndex = dbTable.SelectedRows[0].Cells[0].Value;
                adapter.DeleteCommand = new MySqlCommand($"DELETE FROM `{_tableName}` WHERE id = {rowIndex}", _connection);
                adapter.DeleteCommand.ExecuteNonQuery();
                adapter.Update(_table);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            ShowTable(_tableName);

            _connection.Close();
        }
    }
}