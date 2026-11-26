namespace HRSystem.Forms
{
    partial class MainForm
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
            lblTitle = new Label();
            btnEmployees = new Button();
            this.btnStats = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(78, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(411, 46);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "HR Management System";
            // 
            // btnEmployees
            // 
            btnEmployees.Location = new Point(158, 77);
            btnEmployees.Name = "btnEmployees";
            btnEmployees.Size = new Size(220, 50);
            btnEmployees.TabIndex = 1;
            btnEmployees.Text = "Employees";
            btnEmployees.UseVisualStyleBackColor = true;
            btnEmployees.Click += btnEmployees_Click;
            // 
            // btnStats
            // 
            this.btnStats.Location = new Point(158, 170);
            this.btnStats.Name = "btnStats";
            this.btnStats.Size = new Size(220, 50);
            this.btnStats.TabIndex = 2;
            this.btnStats.Text = "Statistics";
            this.btnStats.UseVisualStyleBackColor = true;
            this.btnStats.Click += this.btnStats_Click_1;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(158, 265);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(220, 50);
            btnExit.TabIndex = 3;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click_1;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 353);
            Controls.Add(btnExit);
            Controls.Add(this.btnStats);
            Controls.Add(btnEmployees);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HR Management System";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Button btnEmployees;
        private Button button1;
        private Button btnExit;
        private Button button3;
        private Button btnStats;
        private void btnStats_Click_1(object sender, EventArgs e)
        {
            btnStats_Click(sender, e);
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            btnExit_Click(sender, e);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
        }
    }
}