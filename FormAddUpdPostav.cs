
namespace SmartWarehouse_360
{
    public partial class FormAddUpdPostav : Form
    {
        public FormAddUpdPostav()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxINND.TextLength < 12)
            {
                MessageBox.Show("В поле ИНН не полное значение!\r\nИНН состоит из 12 чисел", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (textBoxBICD.TextLength < 9)
                {
                    MessageBox.Show("В поле БИК не полное значение!\r\nБИК состоит из 9 чисел", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (textBoxAccD.TextLength < 20)
                    {
                        MessageBox.Show("В поле счет не полное значение!\r\nСчет состоит из 20 чисел", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (textBoxName.Text == "" || textBoxFIO.Text == "" || !maskedTextBoxPhoneD.MaskFull || textBoxAccD.Text == "" ||
                            textBoxActAddr.Text == "" || textBoxINND.Text == "" || textBoxAddr.Text=="" || textBoxActAddr.Text == "" || textBoxBICD.Text == ""
                            || textBoxEmailD.Text == "" || textBoxAccD.Text == "")
                        {
                            MessageBox.Show("Вы заполнили не все поля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            DialogResult = DialogResult.OK;
                        }
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void textBoxINND_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void textBoxBICD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void textBoxAccD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar)&&e.KeyChar!=8)
            {
                e.Handled = true;
            }
            
        }

        private void textBoxFIO_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar)) return;
            else
                e.Handled = true;
        }
    }
}
