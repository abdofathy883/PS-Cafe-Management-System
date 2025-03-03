namespace PlayStation.Presentation
{
    partial class LogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
            label1 = new Label();
            NameInput = new TextBox();
            label2 = new Label();
            PasswordInput = new TextBox();
            LogInBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.ForeColor = Color.White;
            label1.Name = "label1";
            // 
            // NameInput
            // 
            resources.ApplyResources(NameInput, "NameInput");
            NameInput.BorderStyle = BorderStyle.FixedSingle;
            NameInput.Name = "NameInput";
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.ForeColor = Color.White;
            label2.Name = "label2";
            // 
            // PasswordInput
            // 
            resources.ApplyResources(PasswordInput, "PasswordInput");
            PasswordInput.Name = "PasswordInput";
            PasswordInput.UseSystemPasswordChar = true;
            // 
            // LogInBtn
            // 
            resources.ApplyResources(LogInBtn, "LogInBtn");
            LogInBtn.BackColor = Color.White;
            LogInBtn.FlatAppearance.BorderSize = 0;
            LogInBtn.Name = "LogInBtn";
            LogInBtn.UseVisualStyleBackColor = false;
            LogInBtn.Click += LogInBtn_Click;
            // 
            // LogIn
            // 
            AcceptButton = LogInBtn;
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(LogInBtn);
            Controls.Add(PasswordInput);
            Controls.Add(label2);
            Controls.Add(NameInput);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "LogIn";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox NameInput;
        private Label label2;
        private TextBox PasswordInput;
        private Button LogInBtn;
    }
}