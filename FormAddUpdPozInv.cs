using MySql.Data.MySqlClient;


namespace SmartWarehouse_360
{

    public partial class FormAddUpdPozInv : Form
    {
        MySqlCommand cmd;
        string sql;
        string ConnectionString = Properties.Settings.Default.ConnectionString;
        public static bool save = false;

        public FormAddUpdPozInv()
        {
            InitializeComponent();
        }

        private void buttonAddPoz_Click(object sender, EventArgs e)
        {
            if (comboBoxNameProd.Text == "" || textBoxArticle.Text == "" || textBoxEdIzm.Text == "" ||
                textBoxPriseEd.Text == "" || textBoxKolProd.Text == "" || textBoxCategorii.Text == "")
            {
                MessageBox.Show("Вы заполнили не все поля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                save = false;
                DialogResult = DialogResult.OK;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (comboBoxNameProd.Text == "" || textBoxArticle.Text == "" || textBoxEdIzm.Text == "" ||
                textBoxPriseEd.Text == "" || textBoxKolProd.Text == "" || textBoxCategorii.Text == "")
            {
                MessageBox.Show("Вы заполнили не все поля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                save = true;
                DialogResult = DialogResult.OK;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void textBoxKolProd_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int KolichestvoTovara = Convert.ToInt32(textBoxKolProd.Text);
                double ObshayaStoimostPoz = Convert.ToDouble(textBoxPriseEd.Text);
                textBoxItogSumm.Text = (KolichestvoTovara * ObshayaStoimostPoz).ToString();
            }
            catch { }
        }

        private void comboBoxNameProd_TextChanged(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(ConnectionString))
            {
                conn.Open();
                int idcat = 0;
                MySqlDataReader reader;
                sql = sql = "SELECT Product.Article, Product.Edin_zmer, Product.id_categories, Product_category.Name_category " +
                "FROM Product JOIN Product_category ON Product.id_categories = Product_category.id_categories " +
                "WHERE Product.Name_product = '" + comboBoxNameProd.Text + "'";
                cmd = new MySqlCommand(sql, conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    textBoxArticle.Text = reader["Article"].ToString();
                    textBoxEdIzm.Text = reader["Edin_zmer"].ToString();
                    idcat = Convert.ToInt32(reader["id_categories"]);
                    textBoxCategorii.Text = reader["Name_category"].ToString();
                }
                reader.Close();
            }
        }

        private void textBoxPriseEd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void textBoxKolProd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void textBoxArticle_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
