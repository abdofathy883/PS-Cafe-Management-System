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
            ((System.ComponentModel.ISupportInitialize)NewDevicePriceInput).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(201, 32);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 0;
            label1.Text = "اسم الجهاز";
            // 
            // NewDeviceNameInput
            // 
            NewDeviceNameInput.Location = new Point(123, 60);
            NewDeviceNameInput.Name = "NewDeviceNameInput";
            NewDeviceNameInput.Size = new Size(136, 23);
            NewDeviceNameInput.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 32);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 2;
            label2.Text = "سعر الساعة";
            // 
            // NewDevicePriceInput
            // 
            NewDevicePriceInput.Location = new Point(22, 60);
            NewDevicePriceInput.Name = "NewDevicePriceInput";
            NewDevicePriceInput.Size = new Size(81, 23);
            NewDevicePriceInput.TabIndex = 3;
            // 
            // UpdateDeviceBtn
            // 
            UpdateDeviceBtn.Location = new Point(22, 98);
            UpdateDeviceBtn.Name = "UpdateDeviceBtn";
            UpdateDeviceBtn.Size = new Size(237, 27);
            UpdateDeviceBtn.TabIndex = 4;
            UpdateDeviceBtn.Text = "تحديث";
            UpdateDeviceBtn.UseVisualStyleBackColor = true;
            UpdateDeviceBtn.Click += UpdateDeviceBtn_Click;
            // 
            // UpdateDevice
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(285, 158);
            Controls.Add(UpdateDeviceBtn);
            Controls.Add(NewDevicePriceInput);
            Controls.Add(label2);
            Controls.Add(NewDeviceNameInput);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "UpdateDevice";
            Text = "UpdateDevice";
            ((System.ComponentModel.ISupportInitialize)NewDevicePriceInput).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox NewDeviceNameInput;
        private Label label2;
        private NumericUpDown NewDevicePriceInput;
        private Button UpdateDeviceBtn;
    }
}