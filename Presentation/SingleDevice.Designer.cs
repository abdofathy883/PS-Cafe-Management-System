namespace PlayStation.Presentation
{
    partial class SingleDevice
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
            panelHead = new Panel();
            Timer = new Label();
            panel1 = new Panel();
            TotalPriceLbl = new Label();
            label2 = new Label();
            DeviceNameLbl = new Label();
            panelFooter = new Panel();
            LeaveBtn = new Button();
            CloseBtn = new Button();
            panelCafe = new Panel();
            OrderGrid = new DataGridView();
            panel2 = new Panel();
            AddItemBtn = new Button();
            ItemsCounter = new NumericUpDown();
            ItemsCombo = new ComboBox();
            label1 = new Label();
            panelDevice = new Panel();
            panel4 = new Panel();
            numericUpDown2 = new NumericUpDown();
            numericUpDown1 = new NumericUpDown();
            panel3 = new Panel();
            EndBtn = new Button();
            StartBtn = new Button();
            panelHead.SuspendLayout();
            panel1.SuspendLayout();
            panelFooter.SuspendLayout();
            panelCafe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)OrderGrid).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ItemsCounter).BeginInit();
            panelDevice.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panelHead
            // 
            panelHead.Controls.Add(Timer);
            panelHead.Controls.Add(panel1);
            panelHead.Controls.Add(DeviceNameLbl);
            panelHead.Dock = DockStyle.Top;
            panelHead.Location = new Point(0, 0);
            panelHead.Name = "panelHead";
            panelHead.Size = new Size(974, 100);
            panelHead.TabIndex = 0;
            // 
            // Timer
            // 
            Timer.AutoSize = true;
            Timer.Location = new Point(696, 40);
            Timer.Name = "Timer";
            Timer.Size = new Size(54, 19);
            Timer.TabIndex = 2;
            Timer.Text = "label4";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(80, 121, 125);
            panel1.Controls.Add(TotalPriceLbl);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(196, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(123, 82);
            panel1.TabIndex = 1;
            // 
            // TotalPriceLbl
            // 
            TotalPriceLbl.AutoSize = true;
            TotalPriceLbl.Location = new Point(37, 40);
            TotalPriceLbl.Name = "TotalPriceLbl";
            TotalPriceLbl.Size = new Size(54, 19);
            TotalPriceLbl.TabIndex = 1;
            TotalPriceLbl.Text = "label3";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 11);
            label2.Name = "label2";
            label2.Size = new Size(89, 19);
            label2.TabIndex = 0;
            label2.Text = "اجمالي الحساب";
            // 
            // DeviceNameLbl
            // 
            DeviceNameLbl.AutoSize = true;
            DeviceNameLbl.Location = new Point(82, 35);
            DeviceNameLbl.Name = "DeviceNameLbl";
            DeviceNameLbl.Size = new Size(54, 19);
            DeviceNameLbl.TabIndex = 0;
            DeviceNameLbl.Text = "label1";
            // 
            // panelFooter
            // 
            panelFooter.Controls.Add(LeaveBtn);
            panelFooter.Controls.Add(CloseBtn);
            panelFooter.Dock = DockStyle.Bottom;
            panelFooter.Location = new Point(0, 432);
            panelFooter.Name = "panelFooter";
            panelFooter.Size = new Size(974, 67);
            panelFooter.TabIndex = 1;
            // 
            // LeaveBtn
            // 
            LeaveBtn.BackColor = Color.Red;
            LeaveBtn.FlatAppearance.BorderSize = 0;
            LeaveBtn.FlatStyle = FlatStyle.Flat;
            LeaveBtn.Location = new Point(144, 16);
            LeaveBtn.Name = "LeaveBtn";
            LeaveBtn.Size = new Size(211, 32);
            LeaveBtn.TabIndex = 1;
            LeaveBtn.Text = "المغادرة";
            LeaveBtn.UseVisualStyleBackColor = false;
            // 
            // CloseBtn
            // 
            CloseBtn.Location = new Point(464, 16);
            CloseBtn.Name = "CloseBtn";
            CloseBtn.Size = new Size(233, 32);
            CloseBtn.TabIndex = 0;
            CloseBtn.Text = "اغلاق";
            CloseBtn.UseVisualStyleBackColor = true;
            // 
            // panelCafe
            // 
            panelCafe.Controls.Add(OrderGrid);
            panelCafe.Controls.Add(panel2);
            panelCafe.Dock = DockStyle.Right;
            panelCafe.Location = new Point(560, 100);
            panelCafe.Name = "panelCafe";
            panelCafe.Size = new Size(414, 332);
            panelCafe.TabIndex = 2;
            // 
            // OrderGrid
            // 
            OrderGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            OrderGrid.Dock = DockStyle.Fill;
            OrderGrid.Location = new Point(0, 114);
            OrderGrid.Name = "OrderGrid";
            OrderGrid.Size = new Size(414, 218);
            OrderGrid.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(AddItemBtn);
            panel2.Controls.Add(ItemsCounter);
            panel2.Controls.Add(ItemsCombo);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(414, 114);
            panel2.TabIndex = 0;
            // 
            // AddItemBtn
            // 
            AddItemBtn.Location = new Point(305, 55);
            AddItemBtn.Name = "AddItemBtn";
            AddItemBtn.Size = new Size(96, 29);
            AddItemBtn.TabIndex = 3;
            AddItemBtn.Text = "اضافة";
            AddItemBtn.UseVisualStyleBackColor = true;
            AddItemBtn.Click += AddItemBtn_Click;
            // 
            // ItemsCounter
            // 
            ItemsCounter.Location = new Point(235, 57);
            ItemsCounter.Name = "ItemsCounter";
            ItemsCounter.Size = new Size(64, 26);
            ItemsCounter.TabIndex = 2;
            // 
            // ItemsCombo
            // 
            ItemsCombo.FormattingEnabled = true;
            ItemsCombo.Location = new Point(78, 57);
            ItemsCombo.Name = "ItemsCombo";
            ItemsCombo.Size = new Size(146, 27);
            ItemsCombo.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(193, 19);
            label1.Name = "label1";
            label1.Size = new Size(55, 19);
            label1.TabIndex = 0;
            label1.Text = "الكافتيريا";
            // 
            // panelDevice
            // 
            panelDevice.Controls.Add(panel4);
            panelDevice.Controls.Add(panel3);
            panelDevice.Dock = DockStyle.Left;
            panelDevice.Location = new Point(0, 100);
            panelDevice.Name = "panelDevice";
            panelDevice.Size = new Size(554, 332);
            panelDevice.TabIndex = 3;
            // 
            // panel4
            // 
            panel4.Controls.Add(numericUpDown2);
            panel4.Controls.Add(numericUpDown1);
            panel4.Location = new Point(82, 137);
            panel4.Name = "panel4";
            panel4.Size = new Size(376, 100);
            panel4.TabIndex = 1;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(103, 70);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(47, 26);
            numericUpDown2.TabIndex = 1;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(91, 36);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(59, 26);
            numericUpDown1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(EndBtn);
            panel3.Controls.Add(StartBtn);
            panel3.Location = new Point(82, 31);
            panel3.Name = "panel3";
            panel3.Size = new Size(376, 100);
            panel3.TabIndex = 0;
            // 
            // EndBtn
            // 
            EndBtn.Location = new Point(103, 16);
            EndBtn.Name = "EndBtn";
            EndBtn.Size = new Size(75, 23);
            EndBtn.TabIndex = 1;
            EndBtn.Text = "End";
            EndBtn.UseVisualStyleBackColor = true;
            // 
            // StartBtn
            // 
            StartBtn.Location = new Point(194, 16);
            StartBtn.Name = "StartBtn";
            StartBtn.Size = new Size(75, 23);
            StartBtn.TabIndex = 0;
            StartBtn.Text = "Start";
            StartBtn.UseVisualStyleBackColor = true;
            // 
            // SingleDevice
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(974, 499);
            Controls.Add(panelDevice);
            Controls.Add(panelCafe);
            Controls.Add(panelFooter);
            Controls.Add(panelHead);
            Name = "SingleDevice";
            Text = "SingleDevice";
            panelHead.ResumeLayout(false);
            panelHead.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelFooter.ResumeLayout(false);
            panelCafe.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)OrderGrid).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ItemsCounter).EndInit();
            panelDevice.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHead;
        private Label DeviceNameLbl;
        private Panel panel1;
        private Label TotalPriceLbl;
        private Label label2;
        private Label Timer;
        private Panel panelFooter;
        private Panel panelCafe;
        private Panel panelDevice;
        private Panel panel2;
        private DataGridView OrderGrid;
        private Button LeaveBtn;
        private Button CloseBtn;
        private Button AddItemBtn;
        private NumericUpDown ItemsCounter;
        private ComboBox ItemsCombo;
        private Label label1;
        private Panel panel4;
        private Panel panel3;
        private Button StartBtn;
        private Button EndBtn;
        private NumericUpDown numericUpDown2;
        private NumericUpDown numericUpDown1;
    }
}