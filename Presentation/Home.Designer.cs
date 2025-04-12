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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            panel1 = new Panel();
            panel3 = new Panel();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            ReportsBtn = new Button();
            AllDevicesBtn = new Button();
            UserManagementBtn = new Button();
            ExpensesBtn = new Button();
            CafetriaBtn = new Button();
            DeviceManagementBtn = new Button();
            MainContainer = new Panel();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            resources.ApplyResources(panel1, "panel1");
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(label1);
            panel1.Name = "panel1";
            // 
            // panel3
            // 
            resources.ApplyResources(panel3, "panel3");
            panel3.Controls.Add(label2);
            panel3.Name = "panel3";
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.ForeColor = Color.White;
            label2.Name = "label2";
            label2.Tag = "Styled";
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.ForeColor = Color.White;
            label1.Name = "label1";
            label1.Tag = "Styled";
            // 
            // panel2
            // 
            resources.ApplyResources(panel2, "panel2");
            panel2.Controls.Add(ReportsBtn);
            panel2.Controls.Add(AllDevicesBtn);
            panel2.Controls.Add(UserManagementBtn);
            panel2.Controls.Add(ExpensesBtn);
            panel2.Controls.Add(CafetriaBtn);
            panel2.Controls.Add(DeviceManagementBtn);
            panel2.Name = "panel2";
            // 
            // ReportsBtn
            // 
            resources.ApplyResources(ReportsBtn, "ReportsBtn");
            ReportsBtn.BackColor = Color.FromArgb(32, 87, 129);
            ReportsBtn.FlatAppearance.BorderSize = 0;
            ReportsBtn.ForeColor = Color.White;
            ReportsBtn.Name = "ReportsBtn";
            ReportsBtn.Tag = "Styled";
            ReportsBtn.UseVisualStyleBackColor = false;
            ReportsBtn.Click += ReportsBtn_Click;
            // 
            // AllDevicesBtn
            // 
            resources.ApplyResources(AllDevicesBtn, "AllDevicesBtn");
            AllDevicesBtn.BackColor = Color.FromArgb(32, 87, 129);
            AllDevicesBtn.FlatAppearance.BorderSize = 0;
            AllDevicesBtn.ForeColor = Color.White;
            AllDevicesBtn.Name = "AllDevicesBtn";
            AllDevicesBtn.UseVisualStyleBackColor = false;
            AllDevicesBtn.Click += AllDevicesBtn_Click;
            // 
            // UserManagementBtn
            // 
            resources.ApplyResources(UserManagementBtn, "UserManagementBtn");
            UserManagementBtn.BackColor = Color.FromArgb(32, 87, 129);
            UserManagementBtn.FlatAppearance.BorderSize = 0;
            UserManagementBtn.ForeColor = Color.White;
            UserManagementBtn.Name = "UserManagementBtn";
            UserManagementBtn.Tag = "Styled";
            UserManagementBtn.UseVisualStyleBackColor = false;
            UserManagementBtn.Click += UserManagementBtn_Click;
            UserManagementBtn.DragEnter += UserManagementBtn_DragEnter;
            // 
            // ExpensesBtn
            // 
            resources.ApplyResources(ExpensesBtn, "ExpensesBtn");
            ExpensesBtn.BackColor = Color.FromArgb(32, 87, 129);
            ExpensesBtn.FlatAppearance.BorderSize = 0;
            ExpensesBtn.ForeColor = Color.White;
            ExpensesBtn.Name = "ExpensesBtn";
            ExpensesBtn.Tag = "Styled";
            ExpensesBtn.UseVisualStyleBackColor = false;
            ExpensesBtn.Click += ExpensesBtn_Click;
            // 
            // CafetriaBtn
            // 
            resources.ApplyResources(CafetriaBtn, "CafetriaBtn");
            CafetriaBtn.BackColor = Color.FromArgb(32, 87, 129);
            CafetriaBtn.FlatAppearance.BorderSize = 0;
            CafetriaBtn.ForeColor = Color.White;
            CafetriaBtn.Name = "CafetriaBtn";
            CafetriaBtn.Tag = "Styled";
            CafetriaBtn.UseVisualStyleBackColor = false;
            CafetriaBtn.Click += CafetriaBtn_Click;
            // 
            // DeviceManagementBtn
            // 
            resources.ApplyResources(DeviceManagementBtn, "DeviceManagementBtn");
            DeviceManagementBtn.BackColor = Color.FromArgb(32, 87, 129);
            DeviceManagementBtn.FlatAppearance.BorderSize = 0;
            DeviceManagementBtn.ForeColor = Color.White;
            DeviceManagementBtn.Name = "DeviceManagementBtn";
            DeviceManagementBtn.Tag = "Styled";
            DeviceManagementBtn.UseVisualStyleBackColor = false;
            DeviceManagementBtn.Click += DeviceManagementBtn_Click;
            // 
            // MainContainer
            // 
            resources.ApplyResources(MainContainer, "MainContainer");
            MainContainer.Name = "MainContainer";
            // 
            // Home
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(MainContainer);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Home";
            WindowState = FormWindowState.Maximized;
            Load += Home_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
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
        private Button AllDevicesBtn;
        private Label label3;
        private Panel panel3;
        private Button ReportsBtn;
    }
}