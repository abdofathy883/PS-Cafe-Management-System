﻿namespace PlayStation.Presentation
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
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1208, 125);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(label2);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(894, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(314, 125);
            panel3.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(14, 22);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Size = new Size(218, 49);
            label2.TabIndex = 1;
            label2.Tag = "Styled";
            label2.Text = "Abdo Fathy";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(55, 22);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(194, 49);
            label1.TabIndex = 0;
            label1.Tag = "Styled";
            label1.Text = "GameOver";
            // 
            // panel2
            // 
            panel2.Controls.Add(ReportsBtn);
            panel2.Controls.Add(AllDevicesBtn);
            panel2.Controls.Add(UserManagementBtn);
            panel2.Controls.Add(ExpensesBtn);
            panel2.Controls.Add(CafetriaBtn);
            panel2.Controls.Add(DeviceManagementBtn);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 125);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(285, 504);
            panel2.TabIndex = 1;
            // 
            // ReportsBtn
            // 
            ReportsBtn.BackColor = Color.FromArgb(32, 87, 129);
            ReportsBtn.FlatAppearance.BorderSize = 0;
            ReportsBtn.FlatStyle = FlatStyle.Flat;
            ReportsBtn.Font = new Font("Segoe UI", 10F);
            ReportsBtn.ForeColor = Color.White;
            ReportsBtn.Location = new Point(0, 347);
            ReportsBtn.Margin = new Padding(4);
            ReportsBtn.Name = "ReportsBtn";
            ReportsBtn.Padding = new Padding(8, 4, 8, 4);
            ReportsBtn.Size = new Size(281, 60);
            ReportsBtn.TabIndex = 1;
            ReportsBtn.Tag = "Styled";
            ReportsBtn.Text = "التقارير";
            ReportsBtn.UseVisualStyleBackColor = false;
            ReportsBtn.Click += ReportsBtn_Click;
            // 
            // AllDevicesBtn
            // 
            AllDevicesBtn.BackColor = Color.FromArgb(32, 87, 129);
            AllDevicesBtn.FlatAppearance.BorderSize = 0;
            AllDevicesBtn.FlatStyle = FlatStyle.Flat;
            AllDevicesBtn.ForeColor = Color.White;
            AllDevicesBtn.Location = new Point(3, 37);
            AllDevicesBtn.Margin = new Padding(0);
            AllDevicesBtn.Name = "AllDevicesBtn";
            AllDevicesBtn.Size = new Size(279, 52);
            AllDevicesBtn.TabIndex = 4;
            AllDevicesBtn.Text = "الرئيسية";
            AllDevicesBtn.UseVisualStyleBackColor = false;
            AllDevicesBtn.Click += AllDevicesBtn_Click;
            // 
            // UserManagementBtn
            // 
            UserManagementBtn.BackColor = Color.FromArgb(32, 87, 129);
            UserManagementBtn.FlatAppearance.BorderSize = 0;
            UserManagementBtn.FlatStyle = FlatStyle.Flat;
            UserManagementBtn.Font = new Font("Segoe UI", 10F);
            UserManagementBtn.ForeColor = Color.White;
            UserManagementBtn.Location = new Point(0, 283);
            UserManagementBtn.Margin = new Padding(4);
            UserManagementBtn.Name = "UserManagementBtn";
            UserManagementBtn.Padding = new Padding(8, 4, 8, 4);
            UserManagementBtn.Size = new Size(281, 60);
            UserManagementBtn.TabIndex = 0;
            UserManagementBtn.Tag = "Styled";
            UserManagementBtn.Text = "ادارة الحسابات";
            UserManagementBtn.UseVisualStyleBackColor = false;
            UserManagementBtn.Click += UserManagementBtn_Click;
            UserManagementBtn.DragEnter += UserManagementBtn_DragEnter;
            // 
            // ExpensesBtn
            // 
            ExpensesBtn.BackColor = Color.FromArgb(32, 87, 129);
            ExpensesBtn.FlatAppearance.BorderSize = 0;
            ExpensesBtn.FlatStyle = FlatStyle.Flat;
            ExpensesBtn.Font = new Font("Segoe UI", 10F);
            ExpensesBtn.ForeColor = Color.White;
            ExpensesBtn.Location = new Point(0, 219);
            ExpensesBtn.Margin = new Padding(4);
            ExpensesBtn.Name = "ExpensesBtn";
            ExpensesBtn.Padding = new Padding(8, 4, 8, 4);
            ExpensesBtn.Size = new Size(281, 60);
            ExpensesBtn.TabIndex = 3;
            ExpensesBtn.Tag = "Styled";
            ExpensesBtn.Text = "ادارة المصروفات";
            ExpensesBtn.UseVisualStyleBackColor = false;
            ExpensesBtn.Click += ExpensesBtn_Click;
            // 
            // CafetriaBtn
            // 
            CafetriaBtn.BackColor = Color.FromArgb(32, 87, 129);
            CafetriaBtn.FlatAppearance.BorderSize = 0;
            CafetriaBtn.FlatStyle = FlatStyle.Flat;
            CafetriaBtn.Font = new Font("Segoe UI", 10F);
            CafetriaBtn.ForeColor = Color.White;
            CafetriaBtn.Location = new Point(2, 155);
            CafetriaBtn.Margin = new Padding(4);
            CafetriaBtn.Name = "CafetriaBtn";
            CafetriaBtn.Padding = new Padding(8, 4, 8, 4);
            CafetriaBtn.Size = new Size(280, 59);
            CafetriaBtn.TabIndex = 2;
            CafetriaBtn.Tag = "Styled";
            CafetriaBtn.Text = "ادارة الكافيتريا";
            CafetriaBtn.UseVisualStyleBackColor = false;
            CafetriaBtn.Click += CafetriaBtn_Click;
            // 
            // DeviceManagementBtn
            // 
            DeviceManagementBtn.BackColor = Color.FromArgb(32, 87, 129);
            DeviceManagementBtn.FlatAppearance.BorderSize = 0;
            DeviceManagementBtn.FlatStyle = FlatStyle.Flat;
            DeviceManagementBtn.Font = new Font("Segoe UI", 10F);
            DeviceManagementBtn.ForeColor = Color.White;
            DeviceManagementBtn.Location = new Point(1, 91);
            DeviceManagementBtn.Margin = new Padding(4);
            DeviceManagementBtn.Name = "DeviceManagementBtn";
            DeviceManagementBtn.Padding = new Padding(8, 4, 8, 4);
            DeviceManagementBtn.Size = new Size(280, 61);
            DeviceManagementBtn.TabIndex = 1;
            DeviceManagementBtn.Tag = "Styled";
            DeviceManagementBtn.Text = "ادارة الاجهزة";
            DeviceManagementBtn.UseVisualStyleBackColor = false;
            DeviceManagementBtn.Click += DeviceManagementBtn_Click;
            // 
            // MainContainer
            // 
            MainContainer.Dock = DockStyle.Right;
            MainContainer.Location = new Point(306, 125);
            MainContainer.Name = "MainContainer";
            MainContainer.Size = new Size(902, 504);
            MainContainer.TabIndex = 3;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(10F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1208, 629);
            Controls.Add(MainContainer);
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