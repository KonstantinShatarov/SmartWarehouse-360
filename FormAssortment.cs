using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using MySql.Data.MySqlClient;
using System.Data;


namespace SmartWarehouse_360
{
    public partial class FormAssortment : Form
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

            string reportTitle = "Отчет по ассортименту на " + DateTime.Now.ToShortDateString();
            Paragraph title = new Paragraph(reportTitle, f);
            title.Alignment = Element.ALIGN_CENTER;
            document.Add(title);

            document.Add(new Paragraph(" "));

            PdfPTable table = new PdfPTable(dataTable.Columns.Count);
            string[] nameStolb = { "Название продукта", "Артикул", "Ед. измерения", "Описание", "Доп. информация" };
            for (int i = 0; i < dataTable.Columns.Count; i++)
            {
                table.AddCell(new Phrase(nameStolb[i], f));
            }

            foreach (DataRow row in dataTable.Rows)
            {
                foreach (DataColumn column in dataTable.Columns)
                {
                    table.AddCell(new Phrase(row[column].ToString(), f));
                }
            }
            document.Add(table);
            document.Close();
        }

        struct tableProd
        {
            public string stId, stName, stArticle, stEd, stDess, stAddit, stKat;
        }
        List<tableProd> getTable()
        {
            List<tableProd> tbAssort = new List<tableProd>();
            tableProd tmp;
            tbAssort.Clear();
            using (MySqlConnection conn = new MySqlConnection(ConnectionString))
            {
                conn.Open();
                MySqlDataReader reader;
                sql = "SELECT Product.*, Product_category.Name_category FROM Product JOIN Product_category ON Product.id_categories = Product_category.id_categories";
                cmd = new MySqlCommand(sql, conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    tmp.stId = reader["id_product"].ToString();
                    tmp.stName = reader["Name_product"].ToString();
                    tmp.stArticle = reader["Article"].ToString();
                    tmp.stEd = reader["Edin_zmer"].ToString();
                    tmp.stKat = reader["Name_category"].ToString();
                    tmp.stDess = reader["Description"].ToString();
                    tmp.stAddit = reader["Additional_information"].ToString();
                    tbAssort.Add(tmp);
                }
                reader.Close();
                return tbAssort;
            }
        }

        public void fillTableProduct()
        {
            List<tableProd> tbAssort = getTable();

            dataGridViewAssort.Rows.Clear();
            dataGridViewAssort.DefaultCellStyle.BackColor = Color.FromArgb(222, 242, 222);
            dataGridViewAssort.RowCount = tbAssort.Count;
            for (int i = 0; i < tbAssort.Count; i++)
            {
                dataGridViewAssort.Rows[i].Cells[0].Value = tbAssort[i].stId;
                dataGridViewAssort.Rows[i].Cells[1].Value = tbAssort[i].stName;
                dataGridViewAssort.Rows[i].Cells[2].Value = tbAssort[i].stArticle;
                dataGridViewAssort.Rows[i].Cells[3].Value = tbAssort[i].stEd;
                dataGridViewAssort.Rows[i].Cells[4].Value = tbAssort[i].stKat;
                dataGridViewAssort.Rows[i].Cells[5].Value = tbAssort[i].stDess;
                dataGridViewAssort.Rows[i].Cells[6].Value = tbAssort[i].stAddit;
            }
        }

        List<tableProd> getTableSearch()
        {
            List<tableProd> tbAssort = new List<tableProd>();
            tableProd tmp;
            tbAssort.Clear();
            using (MySqlConnection conn = new MySqlConnection(ConnectionString))
            {
                conn.Open();
                MySqlDataReader reader;
                sql = "SELECT Product.*, Product_category.Name_category FROM Product JOIN Product_category ON Product.id_categories = Product_category.id_categories WHERE Name_product" + $"LIKE '%{toolStripTextBoxSearch.Text}%'";
                cmd = new MySqlCommand(sql, conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    tmp.stId = reader["id_product"].ToString();
                    tmp.stName = reader["Name_product"].ToString();
                    tmp.stArticle = reader["Article"].ToString();
                    tmp.stEd = reader["Edin_zmer"].ToString();
                    tmp.stKat = reader["Name_category"].ToString();
                    tmp.stDess = reader["Description"].ToString();
                    tmp.stAddit = reader["Additional_information"].ToString();
                    tbAssort.Add(tmp);
                }
                reader.Close();
                return tbAssort;
            }
        }

        public void fillTableProductSearch()
        {
            List<tableProd> tbAssort = getTableSearch();

            dataGridViewAssort.Rows.Clear();
            dataGridViewAssort.DefaultCellStyle.BackColor = Color.FromArgb(222, 242, 222);
            dataGridViewAssort.RowCount = tbAssort.Count;
            for (int i = 0; i < tbAssort.Count; i++)
            {
                dataGridViewAssort.Rows[i].Cells[0].Value = tbAssort[i].stId;
                dataGridViewAssort.Rows[i].Cells[1].Value = tbAssort[i].stName;
                dataGridViewAssort.Rows[i].Cells[2].Value = tbAssort[i].stArticle;
                dataGridViewAssort.Rows[i].Cells[3].Value = tbAssort[i].stEd;
                dataGridViewAssort.Rows[i].Cells[4].Value = tbAssort[i].stKat;
                dataGridViewAssort.Rows[i].Cells[5].Value = tbAssort[i].stDess;
                dataGridViewAssort.Rows[i].Cells[6].Value = tbAssort[i].stAddit;
            }
        }

        public FormAssortment()
        {
            InitializeComponent();
            toolStripStatusLabel2.Text = DateTime.Now.ToString("dd.MM.yyyy");

            using (MySqlConnection conn = new MySqlConnection(ConnectionString))
            {
                conn.Open();
                fillTableProduct();
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (dataGridViewAssort.Rows.Count > 0)
            {
                DataTable dataTable = GetDataFormDatabase("SELECT Name_product, Article, Edin_zmer, Description, Additional_information FROM Product");
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.FileName = "Отчет по товарам на " + DateTime.Now.ToString("dd.MM.yyyy");
                saveFileDialog.Filter = "PDF fiter (*.pdf)|*.pdf";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    ExportToPDF(dataTable, saveFileDialog.FileName);
                }
                MessageBox.Show("Отчет по товарам успешно сохранен!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Отсутствуют товары для импорта!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAddProd_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(ConnectionString))
            {
                conn.Open();
                FormAddProduct formAddProduct = new FormAddProduct();
                formAddProduct.Text = "Добавление товара";
                formAddProduct.labelINFOPoz.Text = "Добавление нового товара";
                try
                {
                    sql = "SELECT Name_category FROM Product_category";
                    cmd = new MySqlCommand(sql, conn);
                    MySqlDataReader readerComboCat = cmd.ExecuteReader();
                    formAddProduct.comboBoxCategorii.Items.Clear();
                    while (readerComboCat.Read())
                    {
                        formAddProduct.comboBoxCategorii.Items.Add(readerComboCat["Name_category"].ToString());
                    }
                    readerComboCat.Close();

                    if (formAddProduct.ShowDialog() == DialogResult.OK)
                    {
                        int idCategory;
                        sql = "SELECT id_categories FROM Product_category WHERE Name_category = '" + formAddProduct.comboBoxCategorii.SelectedItem + "'";
                        cmd = new MySqlCommand(sql, conn);
                        idCategory = Convert.ToInt32(cmd.ExecuteScalar());

                        sql = "INSERT INTO Product (id_product,id_categories,Name_product,Article," +
                            "Edin_zmer,Description,Additional_information)";
                        sql += "VALUES (NULL, " +
                            "'" + idCategory + "'," +
                            "'" + formAddProduct.textBoxNameProd.Text + "'," +
                            "'" + formAddProduct.textBoxArticle.Text + "'," +
                            "'" + formAddProduct.comboBoxEdIzm.Text + "'," +
                            "'" + formAddProduct.textBoxOpisanie.Text + "'," +
                            "'" + formAddProduct.textBoxDesc.Text + "')";
                        cmd = new MySqlCommand(sql, conn);
                        cmd.ExecuteNonQuery();
                        fillTableProduct();

                        MessageBox.Show("Товар успешно добавлен!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (!FormAddProduct.save) buttonAddProd_Click(sender, e);

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

        private void buttonUpdProd_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(ConnectionString))
            {
                conn.Open();
                try
                {
                    FormAddProduct formAddProduct = new FormAddProduct();
                    formAddProduct.Text = "Редактирование информации о товаре";
                    formAddProduct.labelINFOPoz.Text = "Редактирование товара";
                    formAddProduct.buttonAddProd.Visible = false;

                    if (dataGridViewAssort.Rows.Count > 0)
                    {

                        int indRows = dataGridViewAssort.CurrentRow.Index;
                        int idProd = Convert.ToInt32(dataGridViewAssort.Rows[indRows].Cells[0].Value);
                        string nameprod = dataGridViewAssort.Rows[indRows].Cells[1].Value.ToString();
                        string article = dataGridViewAssort.Rows[indRows].Cells[2].Value.ToString();
                        string edizm = dataGridViewAssort.Rows[indRows].Cells[3].Value.ToString();
                        string categoriya = dataGridViewAssort.Rows[indRows].Cells[4].Value.ToString();
                        string opis = dataGridViewAssort.Rows[indRows].Cells[5].Value.ToString();
                        string dop = dataGridViewAssort.Rows[indRows].Cells[5].Value.ToString();

                        formAddProduct.textBoxNameProd.Text = nameprod;
                        formAddProduct.textBoxArticle.Text = article;
                        formAddProduct.comboBoxEdIzm.Text = edizm;
                        formAddProduct.textBoxOpisanie.Text = opis;
                        formAddProduct.textBoxDesc.Text = dop;

                        sql = "SELECT Name_category FROM Product_category";
                        cmd = new MySqlCommand(sql, conn);
                        MySqlDataReader readerComboCat = cmd.ExecuteReader();
                        formAddProduct.comboBoxCategorii.Items.Clear();
                        while (readerComboCat.Read())
                        {
                            formAddProduct.comboBoxCategorii.Items.Add(readerComboCat["Name_category"].ToString());
                        }
                        readerComboCat.Close();
                        formAddProduct.comboBoxCategorii.Text = categoriya;

                        int idCategory;
                        sql = "SELECT id_categories FROM Product_category WHERE Name_category = '" + formAddProduct.comboBoxCategorii.Text + "'";
                        cmd = new MySqlCommand(sql, conn);
                        idCategory = Convert.ToInt32(cmd.ExecuteScalar());

                        if (formAddProduct.ShowDialog() == DialogResult.OK)
                        {
                            sql = "UPDATE Product SET ";
                            sql += "id_categories= '" + idCategory + "',"
                                + "Name_product= '" + formAddProduct.textBoxNameProd.Text + "',"
                                + "Article='" + formAddProduct.textBoxArticle.Text + "',"
                                + "Edin_zmer= '" + formAddProduct.comboBoxEdIzm.Text + "',"
                                + "Description='" + formAddProduct.textBoxOpisanie.Text + "',"
                                + "Additional_information= '" + formAddProduct.textBoxDesc.Text + "'";
                            sql += "WHERE id_product=" + idProd;
                            cmd = new MySqlCommand(sql, conn);
                            cmd.ExecuteNonQuery();
                            fillTableProduct();

                            MessageBox.Show("Данные о товаре успешно изменены!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Отсутсвуют товары для редактирования!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void buttonDelProd_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(ConnectionString))
            {
                conn.Open();
                if (dataGridViewAssort.Rows.Count > 0)
                {
                    DialogResult dr = MessageBox.Show("Вы уверены, что хотите удалить информацию о товаре?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    if (dr == DialogResult.Yes)
                    {
                        int indRow = dataGridViewAssort.CurrentRow.Index; // узнаем текущую строку
                        int idProd = Convert.ToInt32(dataGridViewAssort.Rows[indRow].Cells[0].Value);
                        sql = "DELETE FROM Product WHERE id_product= '" + idProd.ToString() + "'";
                        cmd = new MySqlCommand(sql, conn);
                        cmd.ExecuteNonQuery();
                        fillTableProduct();
                    }
                }
                else
                {
                    MessageBox.Show("Невыбран товар для удаления!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripTextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            fillTableProductSearch();
        }
    }
}
