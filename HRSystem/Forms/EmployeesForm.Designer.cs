namespace HRSystem.Forms
{
    partial class EmployeesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtName = new TextBox();
            label2 = new Label();
            cmbDepartment = new ComboBox();
            label3 = new Label();
            txtJobTitle = new TextBox();
            label4 = new Label();
            txtEmail = new TextBox();
            label5 = new Label();
            txtPhone = new TextBox();
            label6 = new Label();
            txtSalary = new TextBox();
            label7 = new Label();
            dtpHireDate = new DateTimePicker();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            label8 = new Label();
            txtSearch = new TextBox();
            dgvEmployees = new DataGridView();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvEmployees).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(222, 155);
            label1.Name = "label1";
            label1.Size = new Size(91, 23);
            label1.TabIndex = 0;
            label1.Text = "Full Name:";
            // 
            // txtName
            // 
            txtName.Location = new Point(342, 148);
            txtName.Name = "txtName";
            txtName.Size = new Size(604, 30);
            txtName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(222, 214);
            label2.Name = "label2";
            label2.Size = new Size(106, 23);
            label2.TabIndex = 2;
            label2.Text = "Department:";
            // 
            // cmbDepartment
            // 
            cmbDepartment.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDepartment.FormattingEnabled = true;
            cmbDepartment.Location = new Point(342, 206);
            cmbDepartment.Name = "cmbDepartment";
            cmbDepartment.Size = new Size(604, 31);
            cmbDepartment.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(222, 288);
            label3.Name = "label3";
            label3.Size = new Size(77, 23);
            label3.TabIndex = 4;
            label3.Text = "Job Title:";
            // 
            // txtJobTitle
            // 
            txtJobTitle.Location = new Point(342, 281);
            txtJobTitle.Name = "txtJobTitle";
            txtJobTitle.Size = new Size(604, 30);
            txtJobTitle.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(226, 348);
            label4.Name = "label4";
            label4.Size = new Size(55, 23);
            label4.TabIndex = 6;
            label4.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(342, 341);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(604, 30);
            txtEmail.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(226, 405);
            label5.Name = "label5";
            label5.Size = new Size(63, 23);
            label5.TabIndex = 8;
            label5.Text = "Phone:";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(342, 405);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(604, 30);
            txtPhone.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(226, 462);
            label6.Name = "label6";
            label6.Size = new Size(59, 23);
            label6.TabIndex = 10;
            label6.Text = "Salary:";
            // 
            // txtSalary
            // 
            txtSalary.Location = new Point(342, 462);
            txtSalary.Name = "txtSalary";
            txtSalary.Size = new Size(604, 30);
            txtSalary.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(222, 520);
            label7.Name = "label7";
            label7.Size = new Size(86, 23);
            label7.TabIndex = 12;
            label7.Text = "Hire Date:";
            // 
            // dtpHireDate
            // 
            dtpHireDate.Location = new Point(342, 520);
            dtpHireDate.Name = "dtpHireDate";
            dtpHireDate.Size = new Size(604, 30);
            dtpHireDate.TabIndex = 13;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.SeaGreen;
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(8, 589);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(106, 33);
            btnAdd.TabIndex = 14;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(120, 589);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(106, 33);
            btnUpdate.TabIndex = 15;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.IndianRed;
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(342, 589);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(106, 33);
            btnDelete.TabIndex = 16;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(233, 589);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(106, 33);
            btnClear.TabIndex = 17;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(700, 69);
            label8.Name = "label8";
            label8.Size = new Size(65, 23);
            label8.TabIndex = 18;
            label8.Text = "Search:";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(806, 69);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(140, 30);
            txtSearch.TabIndex = 19;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // dgvEmployees
            // 
            dgvEmployees.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvEmployees.BackgroundColor = Color.White;
            dgvEmployees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmployees.Location = new Point(8, 52);
            dgvEmployees.Name = "dgvEmployees";
            dgvEmployees.RowHeadersWidth = 51;
            dgvEmployees.Size = new Size(208, 278);
            dgvEmployees.TabIndex = 20;
            dgvEmployees.CellClick += dgvEmployees_CellClick;
            dgvEmployees.CellContentClick += dgvEmployees_CellContentClick;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(331, 22);
            label9.Name = "label9";
            label9.Size = new Size(328, 38);
            label9.TabIndex = 21;
            label9.Text = "Employee Management";
            // 
            // EmployeesForm
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(992, 636);
            Controls.Add(label9);
            Controls.Add(dgvEmployees);
            Controls.Add(txtSearch);
            Controls.Add(label8);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(dtpHireDate);
            Controls.Add(label7);
            Controls.Add(txtSalary);
            Controls.Add(label6);
            Controls.Add(txtPhone);
            Controls.Add(label5);
            Controls.Add(txtEmail);
            Controls.Add(label4);
            Controls.Add(txtJobTitle);
            Controls.Add(label3);
            Controls.Add(cmbDepartment);
            Controls.Add(label2);
            Controls.Add(txtName);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "EmployeesForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Employees";
            Load += EmployeesForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEmployees).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtName;
        private Label label2;
        private ComboBox cmbDepartment;
        private Label label3;
        private TextBox txtJobTitle;
        private Label label4;
        private TextBox txtEmail;
        private Label label5;
        private TextBox txtPhone;
        private Label label6;
        private TextBox txtSalary;
        private Label label7;
        private DateTimePicker dtpHireDate;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClear;
        private Label label8;
        private TextBox txtSearch;
        private DataGridView dgvEmployees;
        private Label label9;
    }
}