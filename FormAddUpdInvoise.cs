
namespace SmartWarehouse_360
{
    public partial class FormAddUpdInvoise : Form
    {
        public FormAddUpdInvoise()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (textBoxNumInv.Text == "" || comboBoxPostav.Text == "" ||
            maskedTextBoxDateInv.Text == "" || textBoxObshSumm.Text == "" || comboBoxStaff.Text == "")
            {
                MessageBox.Show("Вы заполнили не все поля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else { DialogResult = DialogResult.OK; }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void textBoxObshSumm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void textBoxNumInv_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
    }
}
