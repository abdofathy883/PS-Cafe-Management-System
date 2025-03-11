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
            DeleteUser = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)UsersTableGrid).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(894, 135);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(37, 19);
            label1.TabIndex = 0;
            label1.Text = "الاسم";
            // 
            // NameInput
            // 
            NameInput.Location = new Point(605, 158);
            NameInput.Margin = new Padding(4);
            NameInput.Name = "NameInput";
            NameInput.Size = new Size(326, 26);
            NameInput.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(523, 135);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(74, 19);
            label2.TabIndex = 2;
            label2.Text = "الرقم السري";
            // 
            // PasswordInput
            // 
            PasswordInput.Location = new Point(386, 158);
            PasswordInput.Margin = new Padding(4);
            PasswordInput.Name = "PasswordInput";
            PasswordInput.Size = new Size(211, 26);
            PasswordInput.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(309, 133);
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
            RolesCombo.Location = new Point(178, 157);
            RolesCombo.Margin = new Padding(4);
            RolesCombo.Name = "RolesCombo";
            RolesCombo.Size = new Size(204, 27);
            RolesCombo.TabIndex = 5;
            // 
            // AddUserBtn
            // 
            AddUserBtn.Location = new Point(13, 156);
            AddUserBtn.Margin = new Padding(4);
            AddUserBtn.Name = "AddUserBtn";
            AddUserBtn.Size = new Size(157, 30);
            AddUserBtn.TabIndex = 6;
            AddUserBtn.Text = "اضافة حساب";
            AddUserBtn.UseVisualStyleBackColor = true;
            AddUserBtn.Click += AddUserBtn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(828, 105);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(103, 19);
            label4.TabIndex = 7;
            label4.Text = "اضافة حساب جديد";
            // 
            // UsersTableGrid
            // 
            UsersTableGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            UsersTableGrid.Columns.AddRange(new DataGridViewColumn[] { UpdateUser, DeleteUser });
            UsersTableGrid.Location = new Point(13, 203);
            UsersTableGrid.Margin = new Padding(4);
            UsersTableGrid.Name = "UsersTableGrid";
            UsersTableGrid.Size = new Size(918, 220);
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
            // DeleteUser
            // 
            DeleteUser.HeaderText = "حذف";
            DeleteUser.Name = "DeleteUser";
            DeleteUser.Text = "حذف";
            DeleteUser.UseColumnTextForButtonValue = true;
            // 
            // UserManagement
            // 
            AutoScaleDimensions = new SizeF(10F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 438);
            Controls.Add(UsersTableGrid);
            Controls.Add(label4);
            Controls.Add(AddUserBtn);
            Controls.Add(RolesCombo);
            Controls.Add(label3);
            Controls.Add(PasswordInput);
            Controls.Add(label2);
            Controls.Add(NameInput);
            Controls.Add(label1);
            Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 178);
            Margin = new Padding(4);
            Name = "UserManagement";
            Text = "ادارة الحسابات";
            ((System.ComponentModel.ISupportInitialize)UsersTableGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private DataGridViewButtonColumn UpdateUser;
        private DataGridViewButtonColumn DeleteUser;
    }
}