using System.Data;
using iTextSharp.text;
using iTextSharp.text.pdf;
using MySql.Data.MySqlClient;


namespace SmartWarehouse_360
{
    public partial class FormStaff : Form
    {
        MySqlCommand cmd;
        string sql;
        string ConnectionString = Properties.Settings.Default.ConnectionString;

        private DataTable GetDataFormDatabase(string query)
        {
            DataTable dataTable = new DataTable();
            using (MySqlConnection conn = new MySqlConnection(ConnectionString))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }
            return dataTable;
        }

        private void ExportToPDF(DataTable dataTable, string filePath)
        {
            iTextSharp.text.Document document = new iTextSharp.text.Document();
            PdfWriter.GetInstance(document, new FileStream(filePath, FileMode.Create));

            document.Open();
            BaseFont baseFont = BaseFont.CreateFont("C:\\Windows\\Fonts\\arial.ttf", BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
            iTextSharp.text.Font f = new iTextSharp.text.Font(baseFont);

            string reportTitle = "Отчет по сотрудникам на " + DateTime.Now.ToShortDateString();
            Paragraph title = new Paragraph(reportTitle, f);
            title.Alignment = Element.ALIGN_CENTER;
            document.Add(title);

            document.Add(new Paragraph(" "));

            PdfPTable table = new PdfPTable(dataTable.Columns.Count);
            string[] nameStolb = { "Фамилия", "Имя", "Отчество", "Должность", "Телефон" };
            for (int i = 0; i < dataTable.Columns.Count; i++)
            {
                table.AddCell(new Phrase(nameStolb[i], f));
            }

            foreach (DataRow row in dataTable.Rows)
            {
                foreach (DataColumn column in dataTable.Columns)
                {
                    table.AddCell(new Phrase(row[column].ToString(),f));
                }
            }
            document.Add(table);
            document.Close();
        }

        struct tableStaff
        {
            public string stStaff, stSurname, stName, stPatronymic, stPost, stPhone;
        }
        List<tableStaff> getTable()
        {
            List<tableStaff> tbStaff = new List<tableStaff>();
            tableStaff tmp;
            tbStaff.Clear();
            using (MySqlConnection conn = new MySqlConnection(ConnectionString))
            {
                conn.Open();
                MySqlDataReader reader;
                sql = "SELECT * FROM Staff";
                cmd = new MySqlCommand(sql, conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    tmp.stStaff = reader["id_staff"].ToString();
                    tmp.stSurname = reader["Surname"].ToString();
                    tmp.stName = reader["Name"].ToString();
                    tmp.stPatronymic = reader["Patronymic"].ToString();
                    tmp.stPost = reader["Post"].ToString();
                    tmp.stPhone = reader["Phone"].ToString();
                    tbStaff.Add(tmp);
                }
                reader.Close();
                return tbStaff;
            }
        }

        public void fillTable()
        {
            List<tableStaff> tbStaff = getTable();

            dataGridViewStaff.Rows.Clear();
            dataGridViewStaff.DefaultCellStyle.BackColor = Color.FromArgb(222, 242, 222);
            dataGridViewStaff.RowCount = tbStaff.Count;
            for (int i = 0; i < tbStaff.Count; i++)
            {
                dataGridViewStaff.Rows[i].Cells[0].Value = tbStaff[i].stStaff;
                dataGridViewStaff.Rows[i].Cells[1].Value = tbStaff[i].stSurname;
                dataGridViewStaff.Rows[i].Cells[2].Value = tbStaff[i].stName;
                dataGridViewStaff.Rows[i].Cells[3].Value = tbStaff[i].stPatronymic;
                dataGridViewStaff.Rows[i].Cells[4].Value = tbStaff[i].stPost;
                dataGridViewStaff.Rows[i].Cells[5].Value = tbStaff[i].stPhone;
            }
        }

        List<tableStaff> getTableS()
        {
            List<tableStaff> tbStaff = new List<tableStaff>();
            tableStaff tmp;
            tbStaff.Clear();
            using (MySqlConnection conn = new MySqlConnection(ConnectionString))
            {
                conn.Open();
                MySqlDataReader reader;
                sql = "SELECT * FROM Staff WHERE Surname " + $"LIKE '%{toolStripTextBoxSearch.Text}%'";
                cmd = new MySqlCommand(sql, conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    tmp.stStaff = reader["id_staff"].ToString();
                    tmp.stSurname = reader["Surname"].ToString();
                    tmp.stName = reader["Name"].ToString();
                    tmp.stPatronymic = reader["Patronymic"].ToString();
                    tmp.stPost = reader["Post"].ToString();
                    tmp.stPhone = reader["Phone"].ToString();
                    tbStaff.Add(tmp);
                }
                reader.Close();
                return tbStaff;
            }
        }

        public void fillTableS()
        {
            List<tableStaff> tbStaff = getTableS();

            dataGridViewStaff.Rows.Clear();
            dataGridViewStaff.DefaultCellStyle.BackColor = Color.FromArgb(222, 242, 222);
            dataGridViewStaff.RowCount = tbStaff.Count;
            for (int i = 0; i < tbStaff.Count; i++)
            {
                dataGridViewStaff.Rows[i].Cells[0].Value = tbStaff[i].stStaff;
                dataGridViewStaff.Rows[i].Cells[1].Value = tbStaff[i].stSurname;
                dataGridViewStaff.Rows[i].Cells[2].Value = tbStaff[i].stName;
                dataGridViewStaff.Rows[i].Cells[3].Value = tbStaff[i].stPatronymic;
                dataGridViewStaff.Rows[i].Cells[4].Value = tbStaff[i].stPost;
                dataGridViewStaff.Rows[i].Cells[5].Value = tbStaff[i].stPhone;
            }
        }

        public FormStaff()
        {
            InitializeComponent();
            toolStripStatusLabel2.Text = DateTime.Now.ToString("dd.MM.yyyy");
            fillTable();
        }

        private void buttonAddStaff_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(ConnectionString))
            {
                conn.Open();
                FormAddUpdStaff formAddUpdStaff = new FormAddUpdStaff();
                formAddUpdStaff.Text = "Добавить нового сотрудника";
                formAddUpdStaff.labelINFOStaff.Text = "Добавить нового сотрудника";
                if (formAddUpdStaff.ShowDialog() == DialogResult.OK)
                {

                    try
                    {
                        sql = "INSERT INTO Staff (id_staff, Name, Surname, Patronymic, Post, Phone)";
                        sql += "VALUES (NULL, " +
                             "'" + formAddUpdStaff.textBoxName.Text + "'," + // Имя
                             "'" + formAddUpdStaff.textBoxSurname.Text + "'," + // Фамилия
                             "'" + formAddUpdStaff.textBoxPatronymic.Text + "'," + // Отчество
                             "'" + formAddUpdStaff.textBoxPost.Text + "'," + // Должность
                             "'" + formAddUpdStaff.maskedTextBoxPhone.Text + "')"; // Телефон
                        cmd = new MySqlCommand(sql, conn);
                        cmd.ExecuteNonQuery();
                        fillTable();

                        MessageBox.Show("Сотрудник успешно добавлен!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void buttonUpdStaff_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(ConnectionString))
            {
                conn.Open();
                FormAddUpdStaff formAddUpdStaff = new FormAddUpdStaff();
                try
                {
                    if (dataGridViewStaff.Rows.Count > 0)
                    {
                        string phone;
                    int indRow = dataGridViewStaff.CurrentRow.Index; // узнаем текущую строку
                    int idSf = Convert.ToInt32(dataGridViewStaff.Rows[indRow].Cells[0].Value);
                    string surname = dataGridViewStaff.Rows[indRow].Cells[1].Value.ToString();
                    string name = dataGridViewStaff.Rows[indRow].Cells[2].Value.ToString();
                    string patronymic = dataGridViewStaff.Rows[indRow].Cells[3].Value.ToString();
                    string post = dataGridViewStaff.Rows[indRow].Cells[4].Value.ToString();
                    phone = dataGridViewStaff.Rows[indRow].Cells[5].Value.ToString();

                    formAddUpdStaff.textBoxSurname.Text = surname;
                    formAddUpdStaff.textBoxName.Text = name;
                    formAddUpdStaff.textBoxPatronymic.Text = patronymic;
                    formAddUpdStaff.textBoxPost.Text = post;
                    formAddUpdStaff.maskedTextBoxPhone.Text = phone;

                    formAddUpdStaff.Text = "Редактировать данные о сотруднике";
                    formAddUpdStaff.labelINFOStaff.Text = "Редактировать данные сотрудника";
                    if (formAddUpdStaff.ShowDialog() == DialogResult.OK)
                    {
                        sql = "UPDATE Staff SET ";
                        sql += "Surname='" + formAddUpdStaff.textBoxSurname.Text + "'," + "Name='" + formAddUpdStaff.textBoxName.Text + "',";
                        sql += "Patronymic='" + formAddUpdStaff.textBoxPatronymic.Text + "'," + "Post='" + formAddUpdStaff.textBoxPost.Text + "'," + 
                                "Phone='" + formAddUpdStaff.maskedTextBoxPhone.Text + "'";
                        sql += "WHERE id_staff=" + idSf;
                        cmd = new MySqlCommand(sql, conn);
                        cmd.ExecuteNonQuery();
                        fillTable();

                        MessageBox.Show("Данные сотрудника успешно изменены!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    }
                    else
                    {
                        MessageBox.Show("Вы не выбрали сотрудника для редактирования!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        }

        private void buttonDelStaff_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(ConnectionString))
            {
                conn.Open();
                if (dataGridViewStaff.Rows.Count > 0)
                {
                    DialogResult = MessageBox.Show("Вы уверены, что хотите удалить информацию о сотруднике?", "Сообщение", 
                        MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    if (DialogResult == DialogResult.Yes)
                    {
                        int indRow = dataGridViewStaff.CurrentRow.Index; // узнаем текущую строку
                        int idSf = Convert.ToInt32(dataGridViewStaff.Rows[indRow].Cells[0].Value);
                        sql = "DELETE FROM Staff WHERE id_staff= '" + idSf.ToString() + "'";
                        cmd = new MySqlCommand(sql, conn);
                        cmd.ExecuteNonQuery();
                        fillTable();
                    }
                }
                else
                {
                    MessageBox.Show("Вы не выбрали сотрудника для удаления!","Ошибка",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
        }

        private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
            fillTableS();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButtonAxp_Click_1(object sender, EventArgs e)
        {
            DataTable dataTable = GetDataFormDatabase("SELECT Surname, Name, Patronymic, Post, Phone FROM Staff");
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = "Отчет по сотрудникам склада на " + DateTime.Now.ToString("dd.MM.yyyy");
            saveFileDialog.Filter = "PDF fiter (*.pdf)|*.pdf";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                ExportToPDF(dataTable, saveFileDialog.FileName);
            }
            MessageBox.Show("Отчет по сотрудникам склада успешно сохранен!","Сообщение", MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}

