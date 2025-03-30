using MySql.Data.MySqlClient;

namespace SmartWarehouse_360
{
    class CreateBD
    {
        string sql;
        string connectBD = "server=localhost;;username=root;password=;";

        public void CreateDatabaseIfNotExists()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectBD))
                {
                    connection.Open();

                    sql = " CREATE DATABASE IF NOT EXISTS SmartWarehouse_360;" +
                        "USE SmartWarehouse_360;" +

                        "CREATE TABLE IF NOT EXISTS Postavshiki (" +
                        "id_postavshika INT AUTO_INCREMENT PRIMARY KEY," +
                        "Name_postavshika VARCHAR(255) NOT NULL," +
                        "FIO_predstavitel VARCHAR(255)," +
                        "Phone_postavshika VARCHAR(17)," +
                        "Address VARCHAR(255)," +
                        "Actual_address VARCHAR(255)," +
                        "INN VARCHAR(12)," +
                        "BIC VARCHAR(9)," +
                        "Account VARCHAR(20)," +
                        "Email VARCHAR(255)" +
                        ");" +

                        "CREATE TABLE IF NOT EXISTS Product_category (" +
                        "id_categories INT AUTO_INCREMENT PRIMARY KEY," +
                        "Description_category TEXT," +
                        "Name_category VARCHAR(255) NOT NULL" +
                        ");" +

                        "CREATE TABLE IF NOT EXISTS Product (" +
                        "id_product INT AUTO_INCREMENT PRIMARY KEY," +
                        "id_categories INT," +
                        "Name_product VARCHAR(255) NOT NULL," +
                        "Article VARCHAR(50)," +
                        "Edin_zmer VARCHAR(50)," +
                        "Description TEXT," +
                        "Additional_information TEXT," +
                        "FOREIGN KEY (id_categories) REFERENCES Product_category(id_categories)" +
                        ");" +

                        "CREATE TABLE IF NOT EXISTS Staff (" +
                        "id_staff INT AUTO_INCREMENT PRIMARY KEY," +
                        "Name VARCHAR(255) NOT NULL," +
                        "Surname VARCHAR(255) NOT NULL," +
                        "Patronymic VARCHAR(255)," +
                        "Post VARCHAR(255)," +
                        "Phone VARCHAR(17)" +
                        ");" +

                        "CREATE TABLE IF NOT EXISTS Invoice (" +
                        "id_invoice INT AUTO_INCREMENT PRIMARY KEY," +
                        "id_staff INT," +
                        "id_postavshika INT," +
                        "Number_invoice VARCHAR(50) NOT NULL," +
                        "Total_amount_invoice DOUBLE(10, 2)," +
                        "Date_invoice DATE," +
                        "Additional_information TEXT," +
                        "FOREIGN KEY (id_staff) REFERENCES Staff(id_staff)," +
                        "FOREIGN KEY (id_postavshika) REFERENCES Postavshiki(id_postavshika)" +
                        ");" +

                        "CREATE TABLE IF NOT EXISTS Position_invoice (" +
                        "id_positions_invoice INT AUTO_INCREMENT PRIMARY KEY," +
                        "id_product INT," +
                        "id_invoice INT," +
                        "Product_quantity INT," +
                        "Unit_price DOUBLE(10, 2)," +
                        "Total_cost_position DOUBLE(10, 2)," +
                        "FOREIGN KEY (id_product) REFERENCES Product(id_product)," +
                        "FOREIGN KEY (id_invoice) REFERENCES Invoice(id_invoice)" +
                        ");";

                    using (MySqlCommand command = new MySqlCommand(sql, connection))
                    {
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (MySqlException ex)
            {
                if (ex.Number == 1042)
                {
                    MessageBox.Show("Сервер недоступен.\r\n" + "Обратитесь к администратору!", "Ошибка",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                if (ex.Number == 1045)
                {
                    MessageBox.Show("Неверно введен пользователь или пароль!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                MessageBox.Show("Ошибка при создании таблиц: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
