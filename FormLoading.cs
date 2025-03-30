
namespace SmartWarehouse_360
{
    public partial class FormLoading : Form
    {
        public FormLoading()
        {
            InitializeComponent();
            CreateBD createBD = new CreateBD();
            createBD.CreateDatabaseIfNotExists();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            this.Hide();
            FormDesktop formDesktop = new FormDesktop();
            formDesktop.ShowDialog();
        }
    }
}
