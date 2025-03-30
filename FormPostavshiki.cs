using MySql.Data.MySqlClient;

namespace SmartWarehouse_360
{
    public partial class FormPostavshiki : Form
    {
        MySqlConnection conn;
        MySqlCommand cmd;
        string sql;
        string ConnectionString = Properties.Settings.Default.ConnectionString;

        struct tablePostavshik
        {
            public string idPost, NamePost, FIOPred, PhonePost, Address, ActAddress, INN, BIC, Account, Email;
        }

        List<tablePostavshik> getTable()
        {
            List<tablePostavshik> tbPostav = new List<tablePostavshik>();
            tablePostavshik tmp;
            tbPostav.Clear();
            using (MySqlConnection conn = new MySqlConnection(ConnectionString))
            {
                conn.Open();
                MySqlDataReader reader;
                sql = "SELECT * FROM Postavshiki";
                cmd = new MySqlCommand(sql, conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    tmp.idPost = reader["id_postavshika"].ToString();
                    tmp.NamePost = reader["Name_postavshika"].ToString();
                    tmp.FIOPred = reader["FIO_predstavitel"].ToString();
                    tmp.PhonePost = reader["Phone_postavshika"].ToString();
                    tmp.Address = reader["Address"].ToString();
                    tmp.ActAddress = reader["Actual_address"].ToString();
                    tmp.INN = reader["INN"].ToString();
                    tmp.BIC = reader["BIC"].ToString();
                    tmp.Account = reader["Account"].ToString();
                    tmp.Email = reader["Email"].ToString();

                    tbPostav.Add(tmp);
                }
                reader.Close();
                return tbPostav;
            }
        }

        public void fillTable()
        {
            List<tablePostavshik> tbPostav = getTable();
            dataGridViewNamePost.Rows.Clear();
            dataGridViewNamePost.DefaultCellStyle.BackColor = Color.FromArgb(222, 242, 222);
            dataGridViewNamePost.RowCount = tbPostav.Count;
            for (int i = 0; i < tbPostav.Count; i++)
            {
                dataGridViewNamePost.Rows[i].Cells[0].Value = tbPostav[i].idPost;
                dataGridViewNamePost.Rows[i].Cells[1].Value = tbPostav[i].NamePost;
            }
        }

        List<tablePostavshik> getTableNumPost()
        {
            List<tablePostavshik> tbPostav = new List<tablePostavshik>();
            tablePostavshik tmp;
            tbPostav.Clear();
            using (MySqlConnection conn = new MySqlConnection(ConnectionString))
            {
                conn.Open();
                MySqlDataReader reader;
                sql = "SELECT * FROM Postavshiki WHERE Name_postavshika " + $"LIKE '%{toolStripTextBoxSearch.Text}%'";
                cmd = new MySqlCommand(sql, conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    tmp.idPost = reader["id_postavshika"].ToString();
                    tmp.NamePost = reader["Name_postavshika"].ToString();
                    tmp.FIOPred = reader["FIO_predstavitel"].ToString();
                    tmp.PhonePost = reader["Phone_postavshika"].ToString();
                    tmp.Address = reader["Address"].ToString();
                    tmp.ActAddress = reader["Actual_address"].ToString();
                    tmp.INN = reader["INN"].ToString();
                    tmp.BIC = reader["BIC"].ToString();
                    tmp.Account = reader["Account"].ToString();
                    tmp.Email = reader["Email"].ToString();
                    tbPostav.Add(tmp);
                }
                reader.Close();
                return tbPostav;
            }
        }

        public void fillTableNumPost()
        {
            List<tablePostavshik> tbPostav = getTableNumPost();
            dataGridViewNamePost.Rows.Clear();
            dataGridViewNamePost.DefaultCellStyle.BackColor = Color.FromArgb(222, 242, 222);
            dataGridViewNamePost.RowCount = tbPostav.Count;
            for (int i = 0; i < tbPostav.Count; i++)
            {
                dataGridViewNamePost.Rows[i].Cells[0].Value = tbPostav[i].idPost;
                dataGridViewNamePost.Rows[i].Cells[1].Value = tbPostav[i].NamePost;
            }
        }


        public FormPostavshiki()
        {
            InitializeComponent();
            toolStripStatusLabel2.Text = DateTime.Now.ToString("dd.MM.yyyy");

            fillTable();
        }

        private void buttonAddPost_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(ConnectionString))
                {
                    conn.Open();
                    FormAddUpdPostav formAddUpdPostav = new FormAddUpdPostav();
                    formAddUpdPostav.Text = "Добавление поставщика";
                    formAddUpdPostav.labelINFOPost.Text = "Добавление нового поставщика";
                    if (formAddUpdPostav.ShowDialog() == DialogResult.OK)
                    {

                        sql = "INSERT INTO Postavshiki (id_postavshika, Name_postavshika, FIO_predstavitel, Phone_postavshika, Address, Actual_address, INN, BIC, Account, Email)";
                        sql += "VALUES (NULL, " +
                              "'" + formAddUpdPostav.textBoxName.Text + "'," + // Название поставщика
                              "'" + formAddUpdPostav.textBoxFIO.Text + "'," + // ФИО представителя
                              "'" + formAddUpdPostav.maskedTextBoxPhoneD.Text + "'," + // Телефон поставщика
                              "'" + formAddUpdPostav.textBoxAddr.Text + "'," + // Адрес
                              "'" + formAddUpdPostav.textBoxActAddr.Text + "'," + // Фактический адрес
                              "'" + formAddUpdPostav.textBoxINND.Text + "'," + // ИНН
                              "'" + formAddUpdPostav.textBoxBICD.Text + "'," + // БИК
                              "'" + formAddUpdPostav.textBoxAccD.Text + "'," + // Счет
                              "'" + formAddUpdPostav.textBoxEmailD.Text + "')"; // Email
                        cmd = new MySqlCommand(sql, conn);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Поставщик успешно добавлен!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        fillTable();
                    }
                }
            }
            catch (MySqlException ex)
            {
                if (ex.Number == 1042)
                {
                    MessageBox.Show("Сервер недоступен.\r\n" + "Обратитесь к администратору!", "Ошибка");
                }
                if (ex.Number == 1049)
                {
                    MessageBox.Show("Отсутствует база данных!", "Ошибка");
                }
                if (ex.Number == 1045)
                {
                    MessageBox.Show("Неверно введен пользователь или пароль!", "Ошибка");
                }
            }
        }

        private void buttonUpdPost_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewNamePost.Rows.Count > 0)
                {
                    using (MySqlConnection conn = new MySqlConnection(ConnectionString))
                    {
                        conn.Open();
                        FormAddUpdPostav formAddUpdPostav = new FormAddUpdPostav();

                        int indRow = dataGridViewNamePost.CurrentRow.Index; // узнаем текущую строку
                        int idpost = Convert.ToInt32(dataGridViewNamePost.Rows[indRow].Cells[0].Value);

                        formAddUpdPostav.textBoxName.Text = textBoxNazPost.Text;
                        formAddUpdPostav.textBoxFIO.Text = textBoxFIOPrad.Text;
                        formAddUpdPostav.maskedTextBoxPhoneD.Text = maskedTextBoxPhone.Text;
                        formAddUpdPostav.textBoxAddr.Text = textBoxAddress.Text;
                        formAddUpdPostav.textBoxActAddr.Text = textBoxActAddress.Text;
                        formAddUpdPostav.textBoxINND.Text = textBoxINN.Text;
                        formAddUpdPostav.textBoxBICD.Text = textBoxBIC.Text;
                        formAddUpdPostav.textBoxAccD.Text = textBoxAccount.Text;
                        formAddUpdPostav.textBoxEmailD.Text = textBoxEmail.Text;

                        formAddUpdPostav.Text = "Редактирование поставщика";
                        formAddUpdPostav.labelINFOPost.Text = "Редактирование поставщика " + textBoxNazPost.Text;
                        if (formAddUpdPostav.ShowDialog() == DialogResult.OK)
                        {
                            sql = "UPDATE Postavshiki SET ";
                            sql += "Name_postavshika = '" + formAddUpdPostav.textBoxName.Text + "', ";
                            sql += "FIO_predstavitel = '" + formAddUpdPostav.textBoxFIO.Text + "', ";
                            sql += "Phone_postavshika = '" + formAddUpdPostav.maskedTextBoxPhoneD.Text + "', ";
                            sql += "Address = '" + formAddUpdPostav.textBoxAddr.Text + "', ";
                            sql += "Actual_address = '" + formAddUpdPostav.textBoxActAddr.Text + "', ";
                            sql += "INN = '" + formAddUpdPostav.textBoxINND.Text + "', ";
                            sql += "BIC = '" + formAddUpdPostav.textBoxBICD.Text + "', ";
                            sql += "Account = '" + formAddUpdPostav.textBoxAccD.Text + "', ";
                            sql += "Email = '" + formAddUpdPostav.textBoxEmailD.Text + "' ";
                            sql += "WHERE id_postavshika = " + idpost;
                            cmd = new MySqlCommand(sql, conn);
                            cmd.ExecuteNonQuery();


                            MessageBox.Show("Данные поставщика успешно изменены!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            fillTable();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Вы не выбрали поставщика для редактирования!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (MySqlException ex)
            {
                if (ex.Number == 1042)
                {
                    MessageBox.Show("Сервер недоступен.\r\n" + "Обратитесь к администратору!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (ex.Number == 1049)
                {
                    MessageBox.Show("Отсутствует база данных!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (ex.Number == 1045)
                {
                    MessageBox.Show("Неверно введен пользователь или пароль!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dataGridViewNamePost_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(ConnectionString))
                {
                    conn.Open();
                    int indRow = dataGridViewNamePost.CurrentRow.Index;
                    int idPost = Convert.ToInt32(dataGridViewNamePost.Rows[indRow].Cells[0].Value);
                    sql = "SELECT * FROM Postavshiki WHERE id_postavshika = " + idPost;
                    cmd = new MySqlCommand(sql, conn);
                    MySqlDataReader reader;
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        textBoxNazPost.Text = reader["id_postavshika"].ToString();
                        textBoxNazPost.Text = reader["Name_postavshika"].ToString();
                        textBoxFIOPrad.Text = reader["FIO_predstavitel"].ToString();
                        maskedTextBoxPhone.Text = reader["Phone_postavshika"].ToString();
                        textBoxAddress.Text = reader["Address"].ToString();
                        textBoxActAddress.Text = reader["Actual_address"].ToString();
                        textBoxINN.Text = reader["INN"].ToString();
                        textBoxBIC.Text = reader["BIC"].ToString();
                        textBoxAccount.Text = reader["Account"].ToString();
                        textBoxEmail.Text = reader["Email"].ToString();
                    }
                    reader.Close();
                }
            }
            catch (MySqlException ex)
            {
                if (ex.Number == 1042)
                {
                    MessageBox.Show("Сервер недоступен.\r\n" + "Обратитесь к администратору!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (ex.Number == 1049)
                {
                    MessageBox.Show("Отсутствует база данных!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (ex.Number == 1045)
                {
                    MessageBox.Show("Неверно введен пользователь или пароль!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonDelPoast_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(ConnectionString))
                {
                    conn.Open();
                    if (dataGridViewNamePost.Rows.Count > 0)
                    {
                        DialogResult dr = MessageBox.Show("Вы уверены, что хотите удалить информацию о поставщике?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                        if (dr == DialogResult.Yes)
                        {
                            int indRow = dataGridViewNamePost.CurrentRow.Index;
                            int idPost = Convert.ToInt32(dataGridViewNamePost.Rows[indRow].Cells[0].Value);
                            sql = "DELETE FROM Postavshiki WHERE id_postavshika= '" + idPost.ToString() + "'";
                            cmd = new MySqlCommand(sql, conn);
                            cmd.ExecuteNonQuery();
                        }
                        fillTable();
                    }
                    else
                    {
                        MessageBox.Show("Вы не выбрали поставщика для удаления!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (MySqlException ex)
            {
                if (ex.Number == 1042)
                {
                    MessageBox.Show("Сервер недоступен.\r\n" + "Обратитесь к администратору!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (ex.Number == 1049)
                {
                    MessageBox.Show("Отсутствует база данных!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (ex.Number == 1045)
                {
                    MessageBox.Show("Неверно введен пользователь или пароль!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                MessageBox.Show("Вы не можете удалить поставщика если он совершал поставки!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void dataGridViewNamePost_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(ConnectionString))
                {
                    conn.Open();
                    int indRow = dataGridViewNamePost.CurrentRow.Index;
                    int idPost = Convert.ToInt32(dataGridViewNamePost.Rows[indRow].Cells[0].Value);
                    sql = "SELECT * FROM Postavshiki WHERE id_postavshika = " + idPost;
                    cmd = new MySqlCommand(sql, conn);
                    MySqlDataReader reader;
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        textBoxNazPost.Text = reader["id_postavshika"].ToString();
                        textBoxNazPost.Text = reader["Name_postavshika"].ToString();
                        textBoxFIOPrad.Text = reader["FIO_predstavitel"].ToString();
                        maskedTextBoxPhone.Text = reader["Phone_postavshika"].ToString();
                        textBoxAddress.Text = reader["Address"].ToString();
                        textBoxActAddress.Text = reader["Actual_address"].ToString();
                        textBoxINN.Text = reader["INN"].ToString();
                        textBoxBIC.Text = reader["BIC"].ToString();
                        textBoxAccount.Text = reader["Account"].ToString();
                        textBoxEmail.Text = reader["Email"].ToString();
                    }
                    reader.Close();
                }
            }
            catch (MySqlException ex)
            {
                if (ex.Number == 1042)
                {
                    MessageBox.Show("Сервер недоступен.\r\n" + "Обратитесь к администратору!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (ex.Number == 1049)
                {
                    MessageBox.Show("Отсутствует база данных!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (ex.Number == 1045)
                {
                    MessageBox.Show("Неверно введен пользователь или пароль!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
            fillTableNumPost();
        }

        private void textBoxINN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxBIC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxAccount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }  
    }
}