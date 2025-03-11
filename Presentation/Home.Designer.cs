namespace PlayStation.Presentation
{
    partial class Home
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
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            ExpensesBtn = new Button();
            CafetriaBtn = new Button();
            DeviceManagementBtn = new Button();
            UserManagementBtn = new Button();
            EmployeePanel = new Panel();
            MainContainer = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            EmployeePanel.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(893, 95);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Right;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(796, 0);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Padding = new Padding(0, 20, 0, 0);
            label2.Size = new Size(97, 39);
            label2.TabIndex = 1;
            label2.Tag = "Styled";
            label2.Text = "Abdo Fathy";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 23);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(89, 19);
            label1.TabIndex = 0;
            label1.Tag = "Styled";
            label1.Text = "GameOver";
            // 
            // panel2
            // 
            panel2.Controls.Add(ExpensesBtn);
            panel2.Controls.Add(CafetriaBtn);
            panel2.Controls.Add(DeviceManagementBtn);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 95);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(189, 418);
            panel2.TabIndex = 1;
            // 
            // ExpensesBtn
            // 
            ExpensesBtn.BackColor = Color.FromArgb(66, 133, 244);
            ExpensesBtn.FlatAppearance.BorderSize = 0;
            ExpensesBtn.FlatStyle = FlatStyle.Flat;
            ExpensesBtn.Font = new Font("Segoe UI", 10F);
            ExpensesBtn.ForeColor = Color.White;
            ExpensesBtn.Location = new Point(1, 130);
            ExpensesBtn.Margin = new Padding(4);
            ExpensesBtn.Name = "ExpensesBtn";
            ExpensesBtn.Padding = new Padding(8, 4, 8, 4);
            ExpensesBtn.Size = new Size(186, 43);
            ExpensesBtn.TabIndex = 3;
            ExpensesBtn.Tag = "Styled";
            ExpensesBtn.Text = "ادارة المصروفات";
            ExpensesBtn.UseVisualStyleBackColor = false;
            ExpensesBtn.Click += ExpensesBtn_Click;
            // 
            // CafetriaBtn
            // 
            CafetriaBtn.BackColor = Color.FromArgb(66, 133, 244);
            CafetriaBtn.FlatAppearance.BorderSize = 0;
            CafetriaBtn.FlatStyle = FlatStyle.Flat;
            CafetriaBtn.Font = new Font("Segoe UI", 10F);
            CafetriaBtn.ForeColor = Color.White;
            CafetriaBtn.Location = new Point(1, 87);
            CafetriaBtn.Margin = new Padding(4);
            CafetriaBtn.Name = "CafetriaBtn";
            CafetriaBtn.Padding = new Padding(8, 4, 8, 4);
            CafetriaBtn.Size = new Size(186, 43);
            CafetriaBtn.TabIndex = 2;
            CafetriaBtn.Tag = "Styled";
            CafetriaBtn.Text = "ادارة الكافيتريا";
            CafetriaBtn.UseVisualStyleBackColor = false;
            CafetriaBtn.Click += CafetriaBtn_Click;
            // 
            // DeviceManagementBtn
            // 
            DeviceManagementBtn.BackColor = Color.FromArgb(66, 133, 244);
            DeviceManagementBtn.FlatAppearance.BorderSize = 0;
            DeviceManagementBtn.FlatStyle = FlatStyle.Flat;
            DeviceManagementBtn.Font = new Font("Segoe UI", 10F);
            DeviceManagementBtn.ForeColor = Color.White;
            DeviceManagementBtn.Location = new Point(1, 44);
            DeviceManagementBtn.Margin = new Padding(4);
            DeviceManagementBtn.Name = "DeviceManagementBtn";
            DeviceManagementBtn.Padding = new Padding(8, 4, 8, 4);
            DeviceManagementBtn.Size = new Size(186, 43);
            DeviceManagementBtn.TabIndex = 1;
            DeviceManagementBtn.Tag = "Styled";
            DeviceManagementBtn.Text = "ادارة الاجهزة";
            DeviceManagementBtn.UseVisualStyleBackColor = false;
            DeviceManagementBtn.Click += DeviceManagementBtn_Click;
            // 
            // UserManagementBtn
            // 
            UserManagementBtn.BackColor = Color.FromArgb(66, 133, 244);
            UserManagementBtn.FlatAppearance.BorderSize = 0;
            UserManagementBtn.FlatStyle = FlatStyle.Flat;
            UserManagementBtn.Font = new Font("Segoe UI", 10F);
            UserManagementBtn.ForeColor = Color.White;
            UserManagementBtn.Location = new Point(0, 4);
            UserManagementBtn.Margin = new Padding(4);
            UserManagementBtn.Name = "UserManagementBtn";
            UserManagementBtn.Padding = new Padding(8, 4, 8, 4);
            UserManagementBtn.Size = new Size(186, 43);
            UserManagementBtn.TabIndex = 0;
            UserManagementBtn.Tag = "Styled";
            UserManagementBtn.Text = "ادارة الحسابات";
            UserManagementBtn.UseVisualStyleBackColor = false;
            UserManagementBtn.Click += UserManagementBtn_Click;
            UserManagementBtn.DragEnter += UserManagementBtn_DragEnter;
            // 
            // EmployeePanel
            // 
            EmployeePanel.Controls.Add(UserManagementBtn);
            EmployeePanel.Location = new Point(2, 307);
            EmployeePanel.Margin = new Padding(4);
            EmployeePanel.Name = "EmployeePanel";
            EmployeePanel.Size = new Size(189, 193);
            EmployeePanel.TabIndex = 2;
            // 
            // MainContainer
            // 
            MainContainer.Dock = DockStyle.Right;
            MainContainer.Location = new Point(195, 95);
            MainContainer.Name = "MainContainer";
            MainContainer.Size = new Size(698, 418);
            MainContainer.TabIndex = 3;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(10F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(893, 513);
            Controls.Add(MainContainer);
            Controls.Add(EmployeePanel);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 178);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "الرئيسية";
            WindowState = FormWindowState.Maximized;
            Load += Home_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            EmployeePanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Panel EmployeePanel;
        private Button UserManagementBtn;
        private Button DeviceManagementBtn;
        private Label label2;
        private Button CafetriaBtn;
        private Button ExpensesBtn;
        private Panel MainContainer;
    }
}