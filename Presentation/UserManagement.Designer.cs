namespace PlayStation.Presentation
{
    partial class UserManagement
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
            NameInput = new TextBox();
            label2 = new Label();
            PasswordInput = new TextBox();
            label3 = new Label();
            RolesCombo = new ComboBox();
            AddUserBtn = new Button();
            label4 = new Label();
            UsersTableGrid = new DataGridView();
            UpdateUser = new DataGridViewButtonColumn();
            DeleteCellButton = new DataGridViewButtonColumn();
            NextBtn = new Button();
            PreviousBtn = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)UsersTableGrid).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(1080, 62);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(37, 19);
            label1.TabIndex = 0;
            label1.Text = "الاسم";
            // 
            // NameInput
            // 
            NameInput.Location = new Point(820, 97);
            NameInput.Margin = new Padding(4);
            NameInput.Name = "NameInput";
            NameInput.Size = new Size(326, 26);
            NameInput.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(716, 62);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(74, 19);
            label2.TabIndex = 2;
            label2.Text = "الرقم السري";
            // 
            // PasswordInput
            // 
            PasswordInput.Location = new Point(601, 97);
            PasswordInput.Margin = new Padding(4);
            PasswordInput.Name = "PasswordInput";
            PasswordInput.Size = new Size(211, 26);
            PasswordInput.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(498, 62);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(73, 19);
            label3.TabIndex = 4;
            label3.Text = "نوع الحساب";
            // 
            // RolesCombo
            // 
            RolesCombo.FormattingEnabled = true;
            RolesCombo.Items.AddRange(new object[] { "ادمن", "موظف" });
            RolesCombo.Location = new Point(393, 96);
            RolesCombo.Margin = new Padding(4);
            RolesCombo.Name = "RolesCombo";
            RolesCombo.Size = new Size(204, 27);
            RolesCombo.TabIndex = 5;
            // 
            // AddUserBtn
            // 
            AddUserBtn.BackColor = Color.FromArgb(32, 87, 129);
            AddUserBtn.FlatAppearance.BorderSize = 0;
            AddUserBtn.FlatStyle = FlatStyle.Flat;
            AddUserBtn.ForeColor = Color.White;
            AddUserBtn.Location = new Point(106, 97);
            AddUserBtn.Margin = new Padding(4);
            AddUserBtn.Name = "AddUserBtn";
            AddUserBtn.Size = new Size(157, 33);
            AddUserBtn.TabIndex = 6;
            AddUserBtn.Text = "اضافة حساب";
            AddUserBtn.UseVisualStyleBackColor = false;
            AddUserBtn.Click += AddUserBtn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 178);
            label4.ForeColor = Color.White;
            label4.Location = new Point(968, 22);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(160, 29);
            label4.TabIndex = 7;
            label4.Text = "اضافة حساب جديد";
            // 
            // UsersTableGrid
            // 
            UsersTableGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            UsersTableGrid.Columns.AddRange(new DataGridViewColumn[] { UpdateUser, DeleteCellButton });
            UsersTableGrid.Location = new Point(106, 137);
            UsersTableGrid.Margin = new Padding(4);
            UsersTableGrid.Name = "UsersTableGrid";
            UsersTableGrid.Size = new Size(1040, 561);
            UsersTableGrid.TabIndex = 8;
            UsersTableGrid.CellContentClick += UsersTableGrid_CellContentClick;
            // 
            // UpdateUser
            // 
            UpdateUser.HeaderText = "تعديل";
            UpdateUser.Name = "UpdateUser";
            UpdateUser.Text = "تعديل";
            UpdateUser.UseColumnTextForButtonValue = true;
            // 
            // DeleteCellButton
            // 
            DeleteCellButton.HeaderText = "حذف";
            DeleteCellButton.Name = "DeleteCellButton";
            DeleteCellButton.Text = "حذف";
            DeleteCellButton.UseColumnTextForButtonValue = true;
            // 
            // NextBtn
            // 
            NextBtn.BackColor = Color.FromArgb(32, 87, 129);
            NextBtn.FlatAppearance.BorderSize = 0;
            NextBtn.FlatStyle = FlatStyle.Flat;
            NextBtn.ForeColor = Color.White;
            NextBtn.Location = new Point(990, 6);
            NextBtn.Name = "NextBtn";
            NextBtn.Size = new Size(156, 35);
            NextBtn.TabIndex = 9;
            NextBtn.Text = "التالي";
            NextBtn.UseVisualStyleBackColor = false;
            NextBtn.Click += NextBtn_Click;
            // 
            // PreviousBtn
            // 
            PreviousBtn.BackColor = Color.FromArgb(32, 87, 129);
            PreviousBtn.FlatAppearance.BorderSize = 0;
            PreviousBtn.FlatStyle = FlatStyle.Flat;
            PreviousBtn.ForeColor = Color.White;
            PreviousBtn.Location = new Point(106, 9);
            PreviousBtn.Name = "PreviousBtn";
            PreviousBtn.Size = new Size(168, 35);
            PreviousBtn.TabIndex = 10;
            PreviousBtn.Text = "السابق";
            PreviousBtn.UseVisualStyleBackColor = false;
            PreviousBtn.Click += PreviousBtn_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(NextBtn);
            panel1.Controls.Add(PreviousBtn);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 705);
            panel1.Name = "panel1";
            panel1.Size = new Size(1159, 44);
            panel1.TabIndex = 11;
            // 
            // panel2
            // 
            panel2.Controls.Add(label4);
            panel2.Controls.Add(NameInput);
            panel2.Controls.Add(UsersTableGrid);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(AddUserBtn);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(RolesCombo);
            panel2.Controls.Add(PasswordInput);
            panel2.Controls.Add(label3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1159, 705);
            panel2.TabIndex = 12;
            // 
            // UserManagement
            // 
            AutoScaleDimensions = new SizeF(10F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1159, 749);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 178);
            Margin = new Padding(4);
            Name = "UserManagement";
            Text = "ادارة الحسابات";
            ((System.ComponentModel.ISupportInitialize)UsersTableGrid).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox NameInput;
        private Label label2;
        private TextBox PasswordInput;
        private Label label3;
        private ComboBox RolesCombo;
        private Button AddUserBtn;
        private Label label4;
        private DataGridView UsersTableGrid;
        private Button NextBtn;
        private Button PreviousBtn;
        private Panel panel1;
        private Panel panel2;
        private DataGridViewButtonColumn UpdateUser;
        private DataGridViewButtonColumn DeleteCellButton;
    }
}