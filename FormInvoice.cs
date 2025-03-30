using MySql.Data.MySqlClient;

namespace SmartWarehouse_360
{
    public partial class FormInvoice : Form
    {
        MySqlCommand cmd;
        string sql;
        string ConnectionString = Properties.Settings.Default.ConnectionString;

        struct tableInvoisePoz
        {
            public string stid, stNameProd, stArtic, stEdIzm, stSellEd, stKoll, stObshSell, stKat;
        }

        List<tableInvoisePoz> getTable(int id)
        {
            List<tableInvoisePoz> tbInvoicePoz = new List<tableInvoisePoz>();
            tableInvoisePoz tmp;
            tbInvoicePoz.Clear();
            using (MySqlConnection conn = new MySqlConnection(ConnectionString))
            {
                conn.Open();
                MySqlDataReader reader;
                sql = "SELECT Product.Name_product, Product.Article, Product.Edin_zmer,Position_invoice.id_positions_invoice, Position_invoice.Unit_price, " +
                    "Position_invoice.Product_quantity, Position_invoice.Total_cost_position, Product_category.Name_category FROM Product JOIN Position_invoice ON Product.id_product = Position_invoice.id_product " +
                    "JOIN Product_category ON Product.id_categories = Product_category.id_categories WHERE Position_invoice.id_invoice =" + id.ToString();

                cmd = new MySqlCommand(sql, conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    tmp.stid = reader["id_positions_invoice"].ToString();
                    tmp.stNameProd = reader["Name_product"].ToString();
                    tmp.stArtic = reader["Article"].ToString();
                    tmp.stEdIzm = reader["Edin_zmer"].ToString();
                    tmp.stSellEd = reader["Unit_price"].ToString();
                    tmp.stKoll = reader["Product_quantity"].ToString();
                    tmp.stObshSell = reader["Total_cost_position"].ToString();
                    tmp.stKat = reader["Name_category"].ToString();
                    tbInvoicePoz.Add(tmp);
                }
                reader.Close();
                return tbInvoicePoz;
            }
        }
        public void fillTableInvPoz(int id)
        {
            List<tableInvoisePoz> tbInvoicePoz = getTable(id);

            dataGridViewProduct.Rows.Clear();
            dataGridViewProduct.DefaultCellStyle.BackColor = Color.FromArgb(222, 242, 222);
            dataGridViewProduct.RowCount = tbInvoicePoz.Count;
            for (int i = 0; i < tbInvoicePoz.Count; i++)
            {
                dataGridViewProduct.Rows[i].Cells[0].Value = tbInvoicePoz[i].stid;
                dataGridViewProduct.Rows[i].Cells[1].Value = tbInvoicePoz[i].stNameProd;
                dataGridViewProduct.Rows[i].Cells[2].Value = tbInvoicePoz[i].stArtic;
                dataGridViewProduct.Rows[i].Cells[3].Value = tbInvoicePoz[i].stEdIzm;
                dataGridViewProduct.Rows[i].Cells[4].Value = tbInvoicePoz[i].stSellEd;
                dataGridViewProduct.Rows[i].Cells[5].Value = tbInvoicePoz[i].stKoll;
                dataGridViewProduct.Rows[i].Cells[6].Value = tbInvoicePoz[i].stObshSell;
                dataGridViewProduct.Rows[i].Cells[7].Value = tbInvoicePoz[i].stKat;
            }
        }
        struct tableInvoise
        {
            public string stid, stNumberInv;
        }
        List<tableInvoise> getTableInv()
        {
            List<tableInvoise> tbInvoice = new List<tableInvoise>();
            tableInvoise tmp;
            tbInvoice.Clear();
            using (MySqlConnection conn = new MySqlConnection(ConnectionString))
            {
                conn.Open();
                MySqlDataReader reader;
                sql = "SELECT * FROM Invoice";
                cmd = new MySqlCommand(sql, conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    tmp.stid = reader["id_invoice"].ToString();
                    tmp.stNumberInv = reader["Number_invoice"].ToString();
                    tbInvoice.Add(tmp);
                }
                reader.Close();
                return tbInvoice;
            }
        }
        public void fillTableInv()
        {
            List<tableInvoise> tbInvoice = getTableInv();

            dataGridViewInvoice.Rows.Clear();
            dataGridViewInvoice.DefaultCellStyle.BackColor = Color.FromArgb(222, 242, 222);
            dataGridViewInvoice.RowCount = tbInvoice.Count;
            for (int i = 0; i < tbInvoice.Count; i++)
            {
                dataGridViewInvoice.Rows[i].Cells[0].Value = tbInvoice[i].stid;
                dataGridViewInvoice.Rows[i].Cells[1].Value = tbInvoice[i].stNumberInv;
            }
        }

        struct tableInvoiseSearch
        {
            public string stid, stNumberInv;
        }
        List<tableInvoiseSearch> getTableInvSearch()
        {
            List<tableInvoiseSearch> tbInvoice = new List<tableInvoiseSearch>();
            tableInvoiseSearch tmp;
            tbInvoice.Clear();
            using (MySqlConnection conn = new MySqlConnection(ConnectionString))
            {
                conn.Open();
                MySqlDataReader reader;
                sql = "SELECT * FROM Invoice WHERE Number_invoice " + $"LIKE '%{toolStripTextBoxSearch.Text}%'";
                cmd = new MySqlCommand(sql, conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    tmp.stid = reader["id_invoice"].ToString();
                    tmp.stNumberInv = reader["Number_invoice"].ToString();
                    tbInvoice.Add(tmp);
                }
                reader.Close();
                return tbInvoice;
            }
        }
        public void fillTableInvSearch()
        {
            List<tableInvoiseSearch> tbInvoice = getTableInvSearch();

            dataGridViewInvoice.Rows.Clear();
            dataGridViewInvoice.DefaultCellStyle.BackColor = Color.FromArgb(222, 242, 222);
            dataGridViewInvoice.RowCount = tbInvoice.Count;
            for (int i = 0; i < tbInvoice.Count; i++)
            {
                dataGridViewInvoice.Rows[i].Cells[0].Value = tbInvoice[i].stid;
                dataGridViewInvoice.Rows[i].Cells[1].Value = tbInvoice[i].stNumberInv;
            }
        }

        public FormInvoice()
        {
            InitializeComponent();
            toolStripStatusLabel2.Text = DateTime.Now.ToString("dd.MM.yyyy");

            using (MySqlConnection conn = new MySqlConnection(ConnectionString))
            {
                conn.Open();
                fillTableInv();
            }
        }

        private void buttonAddInvoice_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(ConnectionString))
            {
                conn.Open();
                FormAddUpdInvoise formaddUpdInvoise = new FormAddUpdInvoise();
                formaddUpdInvoise.Text = "Добавление накладной";
                formaddUpdInvoise.labelINFOPost.Text = "Добавление новой накладной";
                formaddUpdInvoise.maskedTextBoxDateInv.Text = DateTime.Now.ToString("dd.MM.yyyy");

                try
                {
                    sql = "SELECT Name_postavshika FROM Postavshiki";
                    cmd = new MySqlCommand(sql, conn);
                    MySqlDataReader readerComboPost = cmd.ExecuteReader();
                    formaddUpdInvoise.comboBoxPostav.Items.Clear();
                    while (readerComboPost.Read())
                    {
                        formaddUpdInvoise.comboBoxPostav.Items.Add(readerComboPost["Name_postavshika"].ToString());
                    }
                    readerComboPost.Close();
                    formaddUpdInvoise.comboBoxPostav.Text = "Поставщики";

                    sql = "SELECT Surname, Name, Patronymic FROM Staff";
                    cmd = new MySqlCommand(sql, conn);
                    MySqlDataReader readerComboStaff = cmd.ExecuteReader();
                    formaddUpdInvoise.comboBoxStaff.Items.Clear();
                    while (readerComboStaff.Read())
                    {
                        formaddUpdInvoise.comboBoxStaff.Items.Add(readerComboStaff["Surname"].ToString() + " " + readerComboStaff["Name"].ToString() + " " +
                           readerComboStaff["Patronymic"].ToString());
                    }
                    readerComboStaff.Close();
                    formaddUpdInvoise.comboBoxStaff.Text = "Сотрудники";

                    if (formaddUpdInvoise.ShowDialog() == DialogResult.OK)
                    {

                        DateTime DataMask = DateTime.ParseExact(formaddUpdInvoise.maskedTextBoxDateInv.Text, "dd.MM.yyyy", null);
                        string formattedDate = DataMask.ToString("yyyy-MM-dd");

                        int idPostav, idStaff;
                        sql = "SELECT id_postavshika FROM Postavshiki WHERE Name_postavshika = '" + formaddUpdInvoise.comboBoxPostav.Text + "'";
                        cmd = new MySqlCommand(sql, conn);
                        idPostav = Convert.ToInt32(cmd.ExecuteScalar());

                        sql = "SELECT id_staff FROM Staff WHERE CONCAT(Surname, ' ', Name, ' ', Patronymic) = '" + formaddUpdInvoise.comboBoxStaff.Text + "'";
                        cmd = new MySqlCommand(sql, conn);
                        idStaff = Convert.ToInt32(cmd.ExecuteScalar());
                        sql = "INSERT INTO Invoice (id_invoice, id_staff, id_postavshika, " +
                            "Number_invoice, Total_amount_invoice, Date_invoice, Additional_information)";
                        sql += "VALUES (NULL, " + "'" + idStaff + "'," +"'" + idPostav + "'," +
                        "'" + formaddUpdInvoise.textBoxNumInv.Text + "'," +
                        "'" + formaddUpdInvoise.textBoxObshSumm.Text + "'," +
                        "'" + formattedDate + "'," + "'" + formaddUpdInvoise.textBoxDesc.Text + "')";
                        cmd = new MySqlCommand(sql, conn);
                        cmd.ExecuteNonQuery();
                        fillTableInv();

                        MessageBox.Show("Накладная успешно добавленa!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        int indRow = dataGridViewInvoice.CurrentRow.Index;
                        int idPost = Convert.ToInt32(dataGridViewInvoice.Rows[indRow].Cells[0].Value);

                        sql = "SELECT Invoice.*, Staff.Surname, Staff.Name, Staff.Patronymic, Postavshiki.Name_postavshika " +
                            "FROM Invoice JOIN  Staff ON Invoice.id_staff = Staff.id_staff " +
                            "JOIN Postavshiki ON Invoice.id_postavshika = Postavshiki.id_postavshika " +
                            "WHERE id_invoice = " + idPost;
                        cmd = new MySqlCommand(sql, conn);
                        MySqlDataReader reader;
                        reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            textBoxNumbInv.Text = reader["Number_invoice"].ToString();
                            maskedTextBoxDateInv.Text = reader["Date_invoice"].ToString();
                            textBoxPostav.Text = reader["Name_postavshika"].ToString();
                            textBoxObshSumm.Text = reader["Total_amount_invoice"].ToString();
                            textBoxStaff.Text = reader["Surname"].ToString() + " " + reader["Name"].ToString() + " " + reader["Patronymic"].ToString(); ;
                            textBoxDescr.Text = reader["Additional_information"].ToString();
                        }
                        reader.Close();
                        fillTableInv();
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
        private void buttonUpdInvoice_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(ConnectionString))
            {
                conn.Open();
                try
                {
                    FormAddUpdInvoise formaddUpdInvoise = new FormAddUpdInvoise();
                    formaddUpdInvoise.Text = "Редактирование накладной";
                    formaddUpdInvoise.labelINFOPost.Text = "Редактирование данных накладной №" + textBoxNumbInv.Text;
                    formaddUpdInvoise.maskedTextBoxDateInv.Text = DateTime.Now.ToString("dd.MM.yyyy");


                    if (dataGridViewInvoice.Rows.Count > 0)
                    {
                        // Выводим в comboBoxPostav название поставщиков
                        sql = "SELECT Name_postavshika FROM Postavshiki";
                        cmd = new MySqlCommand(sql, conn);
                        MySqlDataReader readerComboPost = cmd.ExecuteReader();
                        formaddUpdInvoise.comboBoxPostav.Items.Clear();
                        while (readerComboPost.Read())
                        {
                            formaddUpdInvoise.comboBoxPostav.Items.Add(readerComboPost["Name_postavshika"].ToString());
                        }
                        readerComboPost.Close();

                        // Выводим в comboBoxStaff Фамилию, Имя, Отчество сотрудников склада
                        sql = "SELECT Surname, Name, Patronymic FROM Staff";
                        cmd = new MySqlCommand(sql, conn);
                        MySqlDataReader readerComboStaff = cmd.ExecuteReader();
                        formaddUpdInvoise.comboBoxStaff.Items.Clear();
                        while (readerComboStaff.Read())
                        {
                            formaddUpdInvoise.comboBoxStaff.Items.Add(readerComboStaff["Surname"].ToString() + " " + readerComboStaff["Name"].ToString() + " " +
                               readerComboStaff["Patronymic"].ToString());
                        }
                        readerComboStaff.Close();

                        formaddUpdInvoise.textBoxNumInv.Text = textBoxNumbInv.Text;
                        formaddUpdInvoise.comboBoxPostav.Text = textBoxPostav.Text;
                        formaddUpdInvoise.maskedTextBoxDateInv.Text = maskedTextBoxDateInv.Text;
                        formaddUpdInvoise.textBoxObshSumm.Text = textBoxObshSumm.Text;
                        formaddUpdInvoise.comboBoxStaff.Text = textBoxStaff.Text;
                        formaddUpdInvoise.textBoxDesc.Text = textBoxDescr.Text;
                    }
                    else
                    {
                        MessageBox.Show("Отсутсвуют накладные для редактирования!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (formaddUpdInvoise.ShowDialog() == DialogResult.OK)
                    {
                        int indRow = dataGridViewInvoice.CurrentRow.Index;
                        int idNumInv = Convert.ToInt32(dataGridViewInvoice.Rows[indRow].Cells[0].Value);

                        DateTime DataMask = DateTime.ParseExact(formaddUpdInvoise.maskedTextBoxDateInv.Text, "dd.MM.yyyy", null);
                        string formattedDate = DataMask.ToString("yyyy-MM-dd");

                        int idPostav;
                        sql = "SELECT id_postavshika FROM Postavshiki WHERE Name_postavshika = '" + formaddUpdInvoise.comboBoxPostav.Text + "'";
                        cmd = new MySqlCommand(sql, conn);
                        idPostav = Convert.ToInt32(cmd.ExecuteScalar());

                        int idStaff;
                        sql = "SELECT id_staff FROM Staff WHERE CONCAT(Surname, ' ', Name, ' ', Patronymic) = '" + formaddUpdInvoise.comboBoxStaff.Text + "'";
                        cmd = new MySqlCommand(sql, conn);
                        idStaff = Convert.ToInt32(cmd.ExecuteScalar());

                        sql = "UPDATE Invoice SET " +
                            "Number_invoice = '" + formaddUpdInvoise.textBoxNumInv.Text + "', " +
                            "id_postavshika = " + idPostav + ", " +
                            "Date_invoice = '" + formattedDate + "', " +
                            "Total_amount_invoice = '" + formaddUpdInvoise.textBoxObshSumm.Text + "', " +
                            "id_staff = " + idStaff + ", " +
                            "Additional_information = '" + formaddUpdInvoise.textBoxDesc.Text + "' " +
                            "WHERE id_invoice = " + idNumInv;
                        cmd = new MySqlCommand(sql, conn);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Данные накладной успешно изменены!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        int indRowU = dataGridViewInvoice.CurrentRow.Index;
                        int idPost = Convert.ToInt32(dataGridViewInvoice.Rows[indRowU].Cells[0].Value);
                        sql = "SELECT Invoice.*, Staff.Surname, Staff.Name, Staff.Patronymic, Postavshiki.Name_postavshika " +
                            "FROM Invoice JOIN  Staff ON Invoice.id_staff = Staff.id_staff " +
                            "JOIN Postavshiki ON Invoice.id_postavshika = Postavshiki.id_postavshika " +
                            "WHERE id_invoice = " + idPost;
                        cmd = new MySqlCommand(sql, conn);
                        MySqlDataReader reader;
                        reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            textBoxNumbInv.Text = reader["Number_invoice"].ToString();
                            maskedTextBoxDateInv.Text = reader["Date_invoice"].ToString();
                            textBoxPostav.Text = reader["Name_postavshika"].ToString();
                            textBoxObshSumm.Text = reader["Total_amount_invoice"].ToString();
                            textBoxStaff.Text = reader["Surname"].ToString() + " " + reader["Name"].ToString() + " " + reader["Patronymic"].ToString(); ;
                            textBoxDescr.Text = reader["Additional_information"].ToString();
                        }
                        reader.Close();
                        fillTableInv();
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

        private void buttonAddPoz_Click(object sender, EventArgs e)
        {
            
            using (MySqlConnection conn = new MySqlConnection(ConnectionString))
            {
                conn.Open();
                if (dataGridViewInvoice.Rows.Count > 0)
                {
                    FormAddUpdPozInv formAddUpdPozInv = new FormAddUpdPozInv();
                    formAddUpdPozInv.Text = "Добавление позиций накладной";
                    formAddUpdPozInv.labelINFOPoz.Text = "Добавление позиций накладной №" + textBoxNumbInv.Text;
                    try
                    {
                        sql = "SELECT Name_product FROM Product";
                        cmd = new MySqlCommand(sql, conn);
                        MySqlDataReader readerComboProd = cmd.ExecuteReader();
                        while (readerComboProd.Read())
                        {
                            formAddUpdPozInv.comboBoxNameProd.Items.Add(readerComboProd["Name_product"].ToString());
                        }
                        readerComboProd.Close();

                        int indRow = dataGridViewInvoice.CurrentRow.Index; // узнаем текущую строку
                        int idInv = Convert.ToInt32(dataGridViewInvoice.Rows[indRow].Cells[0].Value);

                        if (formAddUpdPozInv.ShowDialog() == DialogResult.OK)
                        {
                            int idProduct;
                            sql = "SELECT id_product FROM Product WHERE Name_product = '" + formAddUpdPozInv.comboBoxNameProd.Text + "'";
                            cmd = new MySqlCommand(sql, conn);
                            idProduct = Convert.ToInt32(cmd.ExecuteScalar());

                            sql = "INSERT INTO Position_invoice (id_positions_invoice,id_product,id_invoice," +
                                "Product_quantity,Unit_price,Total_cost_position)";
                            sql += "VALUES (NULL, " +
                            "'" + idProduct + "'," +
                            "'" + idInv + "'," +
                            "'" + formAddUpdPozInv.textBoxKolProd.Text + "'," +
                            "'" + formAddUpdPozInv.textBoxPriseEd.Text + "'," +
                            "'" + formAddUpdPozInv.textBoxItogSumm.Text + "')";
                            cmd = new MySqlCommand(sql, conn);
                            cmd.ExecuteNonQuery();
                            fillTableInvPoz(idInv);
                            MessageBox.Show("Позиция накладной успешно добавленa!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            if (!FormAddUpdPozInv.save) buttonAddPoz_Click(sender, e);
                            
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
                else
                {
                    MessageBox.Show("Вы не выбрали накладную для добавления позицый!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonUpdPoz_Click(object sender, EventArgs e)
        {
            if (dataGridViewProduct.CurrentRow == null) 
            { MessageBox.Show("Отсутвуют позиции для редактирования", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
            using (MySqlConnection conn = new MySqlConnection(ConnectionString))
            {
                conn.Open();
                try
                {
                    FormAddUpdPozInv formAddUpdPozInv = new FormAddUpdPozInv();
                    formAddUpdPozInv.Text = "Редактирование позиций накладной";
                    formAddUpdPozInv.labelINFOPoz.Text = "Редактирование позиций накладной №" + textBoxNumbInv.Text;
                    formAddUpdPozInv.buttonAddPoz.Visible = false;

                    if (dataGridViewProduct.Rows.Count > 0)
                    {
                        sql = "SELECT Name_product FROM Product";
                        cmd = new MySqlCommand(sql, conn);
                        MySqlDataReader readerComboProd = cmd.ExecuteReader();
                        while (readerComboProd.Read())
                        {
                            formAddUpdPozInv.comboBoxNameProd.Items.Add(readerComboProd["Name_product"].ToString());
                        }
                        readerComboProd.Close();

                        int indRow =  dataGridViewInvoice.CurrentRow.Index; // узнаем текущую строку
                        int idInv = Convert.ToInt32(dataGridViewInvoice.Rows[indRow].Cells[0].Value);

                        int indRows = dataGridViewProduct.CurrentRow.Index;
                        int idPoz = Convert.ToInt32(dataGridViewProduct.Rows[indRows].Cells[0].Value);
                        string nameprod = dataGridViewProduct.Rows[indRows].Cells[1].Value.ToString();
                        string article = dataGridViewProduct.Rows[indRows].Cells[2].Value.ToString();
                        string edizm = dataGridViewProduct.Rows[indRows].Cells[3].Value.ToString();
                        string kolprod = dataGridViewProduct.Rows[indRows].Cells[4].Value.ToString();
                        string itogsumm = dataGridViewProduct.Rows[indRows].Cells[5].Value.ToString().Replace(',', '.'); ;
                        string categoriya = dataGridViewProduct.Rows[indRows].Cells[6].Value.ToString();

                        formAddUpdPozInv.comboBoxNameProd.Text = nameprod;
                        formAddUpdPozInv.textBoxArticle.Text = article;
                        formAddUpdPozInv.textBoxEdIzm.Text = edizm;
                        formAddUpdPozInv.textBoxKolProd.Text = kolprod;
                        formAddUpdPozInv.textBoxItogSumm.Text = itogsumm;
                        formAddUpdPozInv.textBoxCategorii.Text = categoriya;

                        if (formAddUpdPozInv.ShowDialog() == DialogResult.OK)
                        {
                            int idProduct;
                            sql = "SELECT id_product FROM Product WHERE Name_product = '" + formAddUpdPozInv.comboBoxNameProd.Text + "'";
                            cmd = new MySqlCommand(sql, conn);
                            idProduct = Convert.ToInt32(cmd.ExecuteScalar());

                            sql = "UPDATE Position_invoice SET ";
                            sql += "id_product='" + idProduct + "',"
                                +"Product_quantity='" + formAddUpdPozInv.textBoxKolProd.Text + "',"
                                + "Total_cost_position='" + formAddUpdPozInv.textBoxItogSumm.Text + "',"
                                + "Unit_price= '" + formAddUpdPozInv.textBoxPriseEd.Text + "'";
                            sql += "WHERE id_positions_invoice=" + idPoz;
                            cmd = new MySqlCommand(sql, conn);
                            cmd.ExecuteNonQuery();
                            fillTableInvPoz(idPoz);

                            MessageBox.Show("Данные о позиции успешно изменены!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("В наклданой отсутсвуют позиции для редактирования!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void dataGridViewInvoice_SelectionChanged(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(ConnectionString))
            {
                conn.Open();
                int indRow = dataGridViewInvoice.CurrentRow.Index; // узнаем текущую строку
                int idPost = Convert.ToInt32(dataGridViewInvoice.Rows[indRow].Cells[0].Value);

                sql = "SELECT Invoice.*, Staff.Surname, Staff.Name, Staff.Patronymic, Postavshiki.Name_postavshika " +
                    "FROM Invoice JOIN  Staff ON Invoice.id_staff = Staff.id_staff " +
                    "JOIN Postavshiki ON Invoice.id_postavshika = Postavshiki.id_postavshika " +
                    "WHERE id_invoice = " + idPost;
                cmd = new MySqlCommand(sql, conn);
                MySqlDataReader reader;
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    textBoxNumbInv.Text = reader["Number_invoice"].ToString();
                    maskedTextBoxDateInv.Text = reader["Date_invoice"].ToString();
                    textBoxPostav.Text = reader["Name_postavshika"].ToString();
                    textBoxObshSumm.Text = reader["Total_amount_invoice"].ToString();
                    textBoxStaff.Text = reader["Surname"].ToString() + " " + reader["Name"].ToString() + " " + reader["Patronymic"].ToString(); ;
                    textBoxDescr.Text = reader["Additional_information"].ToString();
                }
                fillTableInvPoz(idPost);
            }
        }
        private void buttonDelInvoice_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(ConnectionString))
            {
                conn.Open();
                if (dataGridViewInvoice.Rows.Count > 0)
                {
                    DialogResult dr = MessageBox.Show("Вы уверены, что хотите удалить информацию о накладной?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    if (dr == DialogResult.Yes)
                    {
                        int indRow = dataGridViewInvoice.CurrentRow.Index; // узнаем текущую строку
                        int idInv = Convert.ToInt32(dataGridViewInvoice.Rows[indRow].Cells[0].Value);
                        sql = "DELETE FROM Invoice WHERE id_invoice= '" + idInv.ToString() + "'";
                        cmd = new MySqlCommand(sql, conn);
                        cmd.ExecuteNonQuery();
                        fillTableInv();

                            textBoxNumbInv.Text = "";
                            maskedTextBoxDateInv.Text = "";
                            textBoxPostav.Text = "";
                            textBoxObshSumm.Text = "";
                            textBoxStaff.Text = "";
                            textBoxDescr.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Отсутствуют накладные для удаления!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonDelPoz_Click(object sender, EventArgs e)
        {
            if (dataGridViewProduct.CurrentRow == null)
            { MessageBox.Show("Отсутвуют позиции для удаления", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
            using (MySqlConnection conn = new MySqlConnection(ConnectionString))
            {
                conn.Open();
                try
                {
                    if (dataGridViewProduct.Rows.Count > 0)
                    {
                        DialogResult dr = MessageBox.Show("Вы уверены, что хотите удалить позицию из накладной?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                        if (dr == DialogResult.Yes)
                        {
                            int indRow = dataGridViewProduct.CurrentRow.Index; // узнаем текущую строку
                            int idPozInv = Convert.ToInt32(dataGridViewProduct.Rows[indRow].Cells[0].Value);
                            sql = "DELETE FROM Position_invoice WHERE id_positions_invoice= '" + idPozInv.ToString() + "'";
                            cmd = new MySqlCommand(sql, conn);
                            cmd.ExecuteNonQuery();
                            fillTableInv();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Невыбрана позиция накладной для удаления!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void dataGridViewInvoice_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(ConnectionString))
            {
                conn.Open();
                int indRow = dataGridViewInvoice.CurrentRow.Index; // узнаем текущую строку
                int idPost = Convert.ToInt32(dataGridViewInvoice.Rows[indRow].Cells[0].Value);

                sql = "SELECT Invoice.*, Staff.Surname, Staff.Name, Staff.Patronymic, Postavshiki.Name_postavshika " +
                    "FROM Invoice JOIN  Staff ON Invoice.id_staff = Staff.id_staff " +
                    "JOIN Postavshiki ON Invoice.id_postavshika = Postavshiki.id_postavshika " +
                    "WHERE id_invoice = " + idPost;
                cmd = new MySqlCommand(sql, conn);
                MySqlDataReader reader;
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    textBoxNumbInv.Text = reader["Number_invoice"].ToString();
                    maskedTextBoxDateInv.Text = reader["Date_invoice"].ToString();
                    textBoxPostav.Text = reader["Name_postavshika"].ToString();
                    textBoxObshSumm.Text = reader["Total_amount_invoice"].ToString();
                    textBoxStaff.Text = reader["Surname"].ToString() + " " + reader["Name"].ToString() + " " + reader["Patronymic"].ToString(); ;
                    textBoxDescr.Text = reader["Additional_information"].ToString();
                }
                fillTableInvPoz(idPost);
            }
        }

        private void toolStripTextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            fillTableInvSearch();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}