namespace PlayStation.Presentation
{
    partial class UpdateDevice
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
            NewDeviceNameInput = new TextBox();
            label2 = new Label();
            NewDevicePriceInput = new NumericUpDown();
            UpdateDeviceBtn = new Button();
            NewMultiPriceInput = new NumericUpDown();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)NewDevicePriceInput).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NewMultiPriceInput).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(214, 45);
            label1.Name = "label1";
            label1.Size = new Size(67, 19);
            label1.TabIndex = 0;
            label1.Text = "اسم الجهاز";
            // 
            // NewDeviceNameInput
            // 
            NewDeviceNameInput.Location = new Point(145, 73);
            NewDeviceNameInput.Name = "NewDeviceNameInput";
            NewDeviceNameInput.Size = new Size(136, 23);
            NewDeviceNameInput.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(18, 45);
            label2.Name = "label2";
            label2.Size = new Size(107, 19);
            label2.TabIndex = 2;
            label2.Text = "سعر الساعة سنجل";
            // 
            // NewDevicePriceInput
            // 
            NewDevicePriceInput.Location = new Point(18, 73);
            NewDevicePriceInput.Name = "NewDevicePriceInput";
            NewDevicePriceInput.Size = new Size(107, 23);
            NewDevicePriceInput.TabIndex = 3;
            // 
            // UpdateDeviceBtn
            // 
            UpdateDeviceBtn.BackColor = Color.FromArgb(32, 87, 129);
            UpdateDeviceBtn.FlatAppearance.BorderSize = 0;
            UpdateDeviceBtn.FlatStyle = FlatStyle.Flat;
            UpdateDeviceBtn.Font = new Font("Arial", 12F, FontStyle.Bold);
            UpdateDeviceBtn.ForeColor = Color.White;
            UpdateDeviceBtn.Location = new Point(18, 127);
            UpdateDeviceBtn.Margin = new Padding(0);
            UpdateDeviceBtn.Name = "UpdateDeviceBtn";
            UpdateDeviceBtn.Size = new Size(107, 26);
            UpdateDeviceBtn.TabIndex = 4;
            UpdateDeviceBtn.Text = "تحديث";
            UpdateDeviceBtn.UseVisualStyleBackColor = false;
            UpdateDeviceBtn.Click += UpdateDeviceBtn_Click;
            // 
            // NewMultiPriceInput
            // 
            NewMultiPriceInput.Location = new Point(145, 130);
            NewMultiPriceInput.Name = "NewMultiPriceInput";
            NewMultiPriceInput.Size = new Size(136, 23);
            NewMultiPriceInput.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(175, 104);
            label3.Name = "label3";
            label3.Size = new Size(106, 19);
            label3.TabIndex = 5;
            label3.Text = "سعر الساعة مالتي";
            // 
            // UpdateDevice
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(337, 195);
            Controls.Add(NewMultiPriceInput);
            Controls.Add(label3);
            Controls.Add(UpdateDeviceBtn);
            Controls.Add(NewDevicePriceInput);
            Controls.Add(label2);
            Controls.Add(NewDeviceNameInput);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "UpdateDevice";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "تحديث جهاز";
            ((System.ComponentModel.ISupportInitialize)NewDevicePriceInput).EndInit();
            ((System.ComponentModel.ISupportInitialize)NewMultiPriceInput).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox NewDeviceNameInput;
        private Label label2;
        private NumericUpDown NewDevicePriceInput;
        private Button UpdateDeviceBtn;
        private NumericUpDown numericUpDown1;
        private Label label3;
        private NumericUpDown NewMultiPriceInput;
    }
}