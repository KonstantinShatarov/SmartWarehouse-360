using MySql.Data.MySqlClient;

namespace SmartWarehouse_360
{
    public partial class FormProductCategories : Form
    {
        MySqlCommand cmd;
        string sql;
        string ConnectionString = Properties.Settings.Default.ConnectionString;

        struct tableCateg
        {
            public string stId, stNameCat, stDiscCat;
        }
        List<tableCateg> getTable()
        {
            List<tableCateg> tbCat = new List<tableCateg>();
            tableCateg tmp;
            tbCat.Clear();
            using (MySqlConnection conn = new MySqlConnection(ConnectionString))
            {
                conn.Open();
                MySqlDataReader reader;
                sql = "SELECT * FROM Product_category";
                cmd = new MySqlCommand(sql, conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    tmp.stId = reader["id_categories"].ToString();
                    tmp.stNameCat = reader["Name_category"].ToString();
                    tmp.stDiscCat = reader["Description_category"].ToString();
                    tbCat.Add(tmp);
                }
                reader.Close();
                return tbCat;
            }
        }

        public void fillTable()
        {
            List<tableCateg> tbCat = getTable();

            dataGridViewCatProd.Rows.Clear();
            dataGridViewCatProd.DefaultCellStyle.BackColor = Color.FromArgb(222, 242, 222);
            dataGridViewCatProd.RowCount = tbCat.Count;
            for (int i = 0; i < tbCat.Count; i++)
            {
                dataGridViewCatProd.Rows[i].Cells[0].Value = tbCat[i].stId;
                dataGridViewCatProd.Rows[i].Cells[1].Value = tbCat[i].stNameCat;
                dataGridViewCatProd.Rows[i].Cells[2].Value = tbCat[i].stDiscCat;
            }
        }

        public FormProductCategories()
        {
            InitializeComponent();
            toolStripStatusLabel2.Text = DateTime.Now.ToString("dd.MM.yyyy");

            using (MySqlConnection conn = new MySqlConnection(ConnectionString))
            {
                conn.Open();
                fillTable();
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void добавитьКатегориюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(ConnectionString))
            {
                conn.Open();
                FormAddUpdCatProd formAddUpdCatProd = new FormAddUpdCatProd();
                formAddUpdCatProd.Text = "Добавить новую категорию товара";
                formAddUpdCatProd.labelINFOKat.Text = "Добавить новую категорию";
                if (formAddUpdCatProd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        sql = "INSERT INTO Product_category (id_categories, Description_category, Name_category)";
                        sql += "VALUES (NULL, " +
                              "'" + formAddUpdCatProd.textBoxDescCat.Text + "'," +
                              "'" + formAddUpdCatProd.textBoxNameCat.Text + "')";
                        cmd = new MySqlCommand(sql, conn);
                        cmd.ExecuteNonQuery();
                        fillTable();
                        MessageBox.Show("Категория успешно добавлена!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
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
            }
        }

        private void редактироватьКатегориюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(ConnectionString))
            {
                conn.Open();
                if (dataGridViewCatProd.Rows.Count > 0)
                {
                    FormAddUpdCatProd formAddUpdCatProd = new FormAddUpdCatProd();
                    int indRow = dataGridViewCatProd.CurrentRow.Index; // узнаем текущую строку
                    int idcat = Convert.ToInt32(dataGridViewCatProd.Rows[indRow].Cells[0].Value);
                    string namecat = dataGridViewCatProd.Rows[indRow].Cells[1].Value.ToString();
                    string desccat = dataGridViewCatProd.Rows[indRow].Cells[2].Value.ToString();

                    formAddUpdCatProd.textBoxDescCat.Text = desccat;
                    formAddUpdCatProd.textBoxNameCat.Text = namecat;

                    formAddUpdCatProd.Text = "Редактировать данные о категории";
                    formAddUpdCatProd.labelINFOKat.Text = "Редактировать данные категории";
                    if (formAddUpdCatProd.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            sql = "UPDATE Product_category SET ";
                            sql += "Description_category='" + formAddUpdCatProd.textBoxDescCat.Text + "'," + "Name_category='" + formAddUpdCatProd.textBoxNameCat.Text + "'";
                            sql += "WHERE id_categories=" + idcat;
                            cmd = new MySqlCommand(sql, conn);
                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Данные категории успешно изменены!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            formAddUpdCatProd.textBoxNameCat.Text = "";
                            formAddUpdCatProd.textBoxDescCat.Text = "";
                            fillTable();
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
                }
                else
                {
                    MessageBox.Show("Вы не выбрали категорию для редактирования!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void удалитьКатегориюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            using (MySqlConnection conn = new MySqlConnection(ConnectionString))
            {
                try
                {
                    conn.Open();
                    if (dataGridViewCatProd.Rows.Count > 0)
                    {
                        DialogResult = MessageBox.Show("Вы уверены, что хотите удалить информацию о категории товара?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                        if (DialogResult == DialogResult.Yes)
                        {
                            int indRow = dataGridViewCatProd.CurrentRow.Index; // узнаем текущую строку
                            int idcat = Convert.ToInt32(dataGridViewCatProd.Rows[indRow].Cells[0].Value);
                            sql = "DELETE FROM Product_category WHERE id_categories= '" + idcat.ToString() + "'";
                            cmd = new MySqlCommand(sql, conn);
                            cmd.ExecuteNonQuery();
                            fillTable();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Вы не выбрали категорию для удаления!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch
                {
                    MessageBox.Show("Вы не можете удалить категорию если в ней есть товары!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
