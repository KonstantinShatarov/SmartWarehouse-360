
namespace SmartWarehouse_360
{
    public partial class FormAddProduct : Form
    {
        public static bool save = false;
        public FormAddProduct()
        {
            InitializeComponent();
        }

        private void buttonAddProd_Click(object sender, EventArgs e)
        {
            if (textBoxNameProd.Text == "" || textBoxArticle.Text == "" || comboBoxEdIzm.Text == "" ||
                comboBoxCategorii.Text == "")
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
            if (textBoxNameProd.Text == "" || textBoxArticle.Text == "" || comboBoxEdIzm.Text == "" ||
                comboBoxCategorii.Text == "")
            {
                MessageBox.Show("Вы заполнили не все поля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                save = true;
                DialogResult = DialogResult.OK;
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
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
