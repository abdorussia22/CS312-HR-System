namespace HRSystem.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        // يفتح فورم الموظفين
        private void btnEmployees_Click(object sender, EventArgs e)
        {
            var f = new EmployeesForm();
            f.ShowDialog();
        }

        // يفتح فورم الإحصائيات والرسومات
        private void btnStats_Click(object sender, EventArgs e)
        {
            var f = new ChartsForm();
            f.ShowDialog();
        }

        // يقفل البرنامج
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}