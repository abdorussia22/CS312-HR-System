using HRSystem.Data;
using HRSystem.Models;

namespace HRSystem.Forms
{
    public partial class EmployeesForm : Form
    {
        private int selectedId = 0; // 0 يعني مفيش موظف متحدد

        public EmployeesForm()
        {
            InitializeComponent();
        }

        // يشتغل أول ما الفورم يفتح
        private void EmployeesForm_Load(object sender, EventArgs e)
        {
            DataStore.Load();

            cmbDepartment.Items.AddRange(new object[] { "HR", "IT", "Finance", "Sales", "Marketing" });

            dgvEmployees.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEmployees.MultiSelect = false;
            dgvEmployees.ReadOnly = true;
            dgvEmployees.AllowUserToAddRows = false;
            dgvEmployees.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            RefreshGrid();
        }

        // يحدّث الجدول (ومعاه البحث/الفلتر)
        private void RefreshGrid()
        {
            string q = txtSearch.Text.Trim().ToLower();

            var list = DataStore.Employees
                .Where(emp => emp.FullName.ToLower().Contains(q)
                           || emp.Department.ToLower().Contains(q)
                           || emp.JobTitle.ToLower().Contains(q))
                .ToList();

            dgvEmployees.DataSource = null;
            dgvEmployees.DataSource = list;
        }

        // يتأكد إن البيانات صح (Validation)
        private bool ValidateInput(out decimal salary)
        {
            salary = 0;

            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Please enter the employee name.");
                return false;
            }
            if (cmbDepartment.SelectedItem == null)
            {
                MessageBox.Show("Please select a department.");
                return false;
            }
            if (!txtEmail.Text.Contains("@") || !txtEmail.Text.Contains("."))
            {
                MessageBox.Show("Please enter a valid email.");
                return false;
            }
            if (!decimal.TryParse(txtSalary.Text, out salary) || salary <= 0)
            {
                MessageBox.Show("Salary must be a number greater than 0.");
                return false;
            }
            return true;
        }

        private void ClearFields()
        {
            txtName.Clear();
            txtJobTitle.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
            txtSalary.Clear();
            cmbDepartment.SelectedIndex = -1;
            dtpHireDate.Value = DateTime.Today;
            selectedId = 0;
            dgvEmployees.ClearSelection();
        }

        // زرار Add
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateInput(out decimal salary)) return;

            var emp = new Employee
            {
                Id = DataStore.NextId(),
                FullName = txtName.Text.Trim(),
                Department = cmbDepartment.SelectedItem!.ToString()!,
                JobTitle = txtJobTitle.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                Phone = txtPhone.Text.Trim(),
                Salary = salary,
                HireDate = dtpHireDate.Value.Date
            };

            DataStore.Employees.Add(emp);
            DataStore.Save();
            RefreshGrid();
            ClearFields();
        }

        // زرار Update
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedId == 0)
            {
                MessageBox.Show("Select an employee from the table first.");
                return;
            }
            if (!ValidateInput(out decimal salary)) return;

            var emp = DataStore.Employees.First(x => x.Id == selectedId);
            emp.FullName = txtName.Text.Trim();
            emp.Department = cmbDepartment.SelectedItem!.ToString()!;
            emp.JobTitle = txtJobTitle.Text.Trim();
            emp.Email = txtEmail.Text.Trim();
            emp.Phone = txtPhone.Text.Trim();
            emp.Salary = salary;
            emp.HireDate = dtpHireDate.Value.Date;

            DataStore.Save();
            RefreshGrid();
            ClearFields();
        }

        // زرار Delete
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedId == 0)
            {
                MessageBox.Show("Select an employee from the table first.");
                return;
            }

            var result = MessageBox.Show("Are you sure you want to delete this employee?",
                                         "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result != DialogResult.Yes) return;

            DataStore.Employees.RemoveAll(x => x.Id == selectedId);
            DataStore.Save();
            RefreshGrid();
            ClearFields();
        }

        // زرار Clear
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        // البحث: كل ما تكتب حرف الجدول يتفلتر
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        // لما تضغط على صف في الجدول، البيانات تظهر في الحقول
        private void dgvEmployees_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var emp = (Employee)dgvEmployees.Rows[e.RowIndex].DataBoundItem!;
            selectedId = emp.Id;
            txtName.Text = emp.FullName;
            cmbDepartment.SelectedItem = emp.Department;
            txtJobTitle.Text = emp.JobTitle;
            txtEmail.Text = emp.Email;
            txtPhone.Text = emp.Phone;
            txtSalary.Text = emp.Salary.ToString();
            dtpHireDate.Value = emp.HireDate;
        }

        private void dgvEmployees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}