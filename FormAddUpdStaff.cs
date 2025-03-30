

namespace SmartWarehouse_360
{
    public partial class FormAddUpdStaff : Form
    {
        public FormAddUpdStaff()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text == "" || textBoxPost.Text == "" || textBoxSurname.Text == "" || !maskedTextBoxPhone.MaskFull)
            {
                MessageBox.Show("Заполнены не все поля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else { DialogResult = DialogResult.OK; }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void textBoxSurname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar)) return;
            else
                e.Handled = true;
        }

        private void textBoxName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar)) return;
            else
                e.Handled = true;
        }

        private void textBoxPatronymic_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar)) return;
            else
                e.Handled = true;
        }

        private void textBoxPost_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar)) return;
            else
                e.Handled = true;
        }
    }
}