
namespace SmartWarehouse_360
{
    public partial class FormAddUpdCatProd : Form
    {
        public FormAddUpdCatProd()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (textBoxNameCat.Text == "")
            {
                MessageBox.Show("Вы не ввели название категории!","Ошибка",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else { DialogResult = DialogResult.OK; }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
