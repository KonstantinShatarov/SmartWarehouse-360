

namespace SmartWarehouse_360
{
    public partial class FormDesktop : Form
    {
        public FormDesktop()
        {
            InitializeComponent();
            toolStripStatusLabel2.Text = DateTime.Now.ToString("dd.MM.yyyy");
        }

        private void buttonInvoice_Click(object sender, EventArgs e)
        {
            FormInvoice formInvoice = new FormInvoice();
            formInvoice.ShowDialog();
        }

        private void накладныеToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FormInvoice formInvoice = new FormInvoice();
            formInvoice.ShowDialog();
        }

        private void buttonPostav_Click(object sender, EventArgs e)
        {
            FormPostavshiki formPostavshiki = new FormPostavshiki();
            formPostavshiki.ShowDialog();
        }

        private void поставщикиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPostavshiki formPostavshiki = new FormPostavshiki();
            formPostavshiki.ShowDialog();
        }

        private void buttonAssort_Click(object sender, EventArgs e)
        {
            FormAssortment formAssortment = new FormAssortment();
            formAssortment.ShowDialog();
        }

        private void ассортиментToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAssortment formAssortment = new FormAssortment();
            formAssortment.ShowDialog();
        }

        private void buttonStaff_Click(object sender, EventArgs e)
        {
            FormStaff formStaff = new FormStaff();
            formStaff.ShowDialog();
        }

        private void сотрудникиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormStaff formStaff = new FormStaff();
            formStaff.ShowDialog();
        }

        private void категорииТоваровToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProductCategories formProductCategories = new FormProductCategories();
            formProductCategories.ShowDialog();
        }

        private void FormDesktop_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}