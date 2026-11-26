namespace HRSystem.Forms
{
    partial class ChartsForm
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
            pnlBar = new Panel();
            pnlPie = new Panel();
            btnRefresh = new Button();
            SuspendLayout();
            // 
            // pnlBar
            // 
            pnlBar.BackColor = Color.White;
            pnlBar.BorderStyle = BorderStyle.FixedSingle;
            pnlBar.Location = new Point(12, 44);
            pnlBar.Name = "pnlBar";
            pnlBar.Size = new Size(460, 400);
            pnlBar.TabIndex = 0;
            pnlBar.Paint += pnlBar_Paint;
            // 
            // pnlPie
            // 
            pnlPie.BackColor = Color.White;
            pnlPie.BorderStyle = BorderStyle.FixedSingle;
            pnlPie.Location = new Point(510, 44);
            pnlPie.Name = "pnlPie";
            pnlPie.Size = new Size(460, 400);
            pnlPie.TabIndex = 1;
            pnlPie.Paint += pnlPie_Paint;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(437, 462);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(94, 29);
            btnRefresh.TabIndex = 2;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // ChartsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 513);
            Controls.Add(btnRefresh);
            Controls.Add(pnlPie);
            Controls.Add(pnlBar);
            Name = "ChartsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Statistics";
            Load += ChartsForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlBar;
        private Panel pnlPie;
        private Button btnRefresh;
    }
}