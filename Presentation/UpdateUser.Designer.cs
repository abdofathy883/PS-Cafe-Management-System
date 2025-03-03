namespace PlayStation.Presentation
{
    partial class UpdateUser
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
            NewUserNameInput = new TextBox();
            label2 = new Label();
            NewUserPassInput = new TextBox();
            label3 = new Label();
            UserTypeCombo = new ComboBox();
            UpdateUserBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(216, 34);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 0;
            label1.Text = "الاسم الجديد";
            // 
            // NewUserNameInput
            // 
            NewUserNameInput.Location = new Point(166, 62);
            NewUserNameInput.Name = "NewUserNameInput";
            NewUserNameInput.Size = new Size(117, 23);
            NewUserNameInput.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 34);
            label2.Name = "label2";
            label2.Size = new Size(96, 15);
            label2.TabIndex = 2;
            label2.Text = "الرقم السري الجديد";
            // 
            // NewUserPassInput
            // 
            NewUserPassInput.Location = new Point(23, 62);
            NewUserPassInput.Name = "NewUserPassInput";
            NewUserPassInput.Size = new Size(115, 23);
            NewUserPassInput.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(218, 98);
            label3.Name = "label3";
            label3.Size = new Size(65, 15);
            label3.TabIndex = 4;
            label3.Text = "نوع الحساب";
            // 
            // UserTypeCombo
            // 
            UserTypeCombo.FormattingEnabled = true;
            UserTypeCombo.Location = new Point(166, 125);
            UserTypeCombo.Name = "UserTypeCombo";
            UserTypeCombo.Size = new Size(117, 23);
            UserTypeCombo.TabIndex = 5;
            // 
            // UpdateUserBtn
            // 
            UpdateUserBtn.Location = new Point(23, 125);
            UpdateUserBtn.Name = "UpdateUserBtn";
            UpdateUserBtn.Size = new Size(115, 23);
            UpdateUserBtn.TabIndex = 6;
            UpdateUserBtn.Text = "تحديث";
            UpdateUserBtn.UseVisualStyleBackColor = true;
            UpdateUserBtn.Click += UpdateUserBtn_Click;
            // 
            // UpdateUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(305, 167);
            Controls.Add(UpdateUserBtn);
            Controls.Add(UserTypeCombo);
            Controls.Add(label3);
            Controls.Add(NewUserPassInput);
            Controls.Add(label2);
            Controls.Add(NewUserNameInput);
            Controls.Add(label1);
            Name = "UpdateUser";
            Text = "UpdateUser";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox NewUserNameInput;
        private Label label2;
        private TextBox NewUserPassInput;
        private Label label3;
        private ComboBox UserTypeCombo;
        private Button UpdateUserBtn;
    }
}