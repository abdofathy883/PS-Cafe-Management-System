using System.Windows.Forms;

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
            panelCafe = new Panel();
            panel2 = new Panel();
            AddItemBtn = new Button();
            ItemsCounter = new NumericUpDown();
            label1 = new Label();
            ItemsCombo = new ComboBox();
            OrderGrid = new DataGridView();
            panelFooter = new Panel();
            LeaveBtn = new Button();
            CloseBtn = new Button();
            panelDevice = new Panel();
            panel4 = new Panel();
            dateTimePicker1 = new DateTimePicker();
            numericUpDown2 = new NumericUpDown();
            numericUpDown1 = new NumericUpDown();
            panel3 = new Panel();
            EndBtn = new Button();
            StartBtn = new Button();
            panelHead.SuspendLayout();
            panel1.SuspendLayout();
            panelCafe.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ItemsCounter).BeginInit();
            ((System.ComponentModel.ISupportInitialize)OrderGrid).BeginInit();
            panelFooter.SuspendLayout();
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
            panelHead.Margin = new Padding(4, 3, 4, 3);
            panelHead.Name = "panelHead";
            panelHead.Size = new Size(1186, 113);
            panelHead.TabIndex = 0;
            // 
            // Timer
            // 
            Timer.AutoSize = true;
            Timer.Location = new Point(81, 75);
            Timer.Margin = new Padding(4, 0, 4, 0);
            Timer.Name = "Timer";
            Timer.Size = new Size(58, 17);
            Timer.TabIndex = 2;
            Timer.Text = "00:00:00";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(80, 121, 125);
            panel1.Controls.Add(TotalPriceLbl);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(1033, 12);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(140, 93);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // TotalPriceLbl
            // 
            TotalPriceLbl.AutoSize = true;
            TotalPriceLbl.Location = new Point(42, 45);
            TotalPriceLbl.Margin = new Padding(4, 0, 4, 0);
            TotalPriceLbl.Name = "TotalPriceLbl";
            TotalPriceLbl.Size = new Size(33, 17);
            TotalPriceLbl.TabIndex = 1;
            TotalPriceLbl.Text = "0.00";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 13);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(90, 17);
            label2.TabIndex = 0;
            label2.Text = "اجمالي الحساب";
            // 
            // DeviceNameLbl
            // 
            DeviceNameLbl.AutoSize = true;
            DeviceNameLbl.Location = new Point(94, 40);
            DeviceNameLbl.Margin = new Padding(4, 0, 4, 0);
            DeviceNameLbl.Name = "DeviceNameLbl";
            DeviceNameLbl.Size = new Size(45, 17);
            DeviceNameLbl.TabIndex = 0;
            DeviceNameLbl.Text = "label1";
            // 
            // panelCafe
            // 
            panelCafe.Controls.Add(panel2);
            panelCafe.Controls.Add(OrderGrid);
            panelCafe.Location = new Point(569, 119);
            panelCafe.Margin = new Padding(4, 3, 4, 3);
            panelCafe.Name = "panelCafe";
            panelCafe.Size = new Size(543, 359);
            panelCafe.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(AddItemBtn);
            panel2.Controls.Add(ItemsCounter);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(ItemsCombo);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(543, 129);
            panel2.TabIndex = 0;
            panel2.Paint += panel2_Paint;
            // 
            // AddItemBtn
            // 
            AddItemBtn.Location = new Point(348, 60);
            AddItemBtn.Margin = new Padding(4, 3, 4, 3);
            AddItemBtn.Name = "AddItemBtn";
            AddItemBtn.Size = new Size(110, 33);
            AddItemBtn.TabIndex = 3;
            AddItemBtn.Text = "اضافة";
            AddItemBtn.UseVisualStyleBackColor = true;
            AddItemBtn.Click += AddItemBtn_Click;
            // 
            // ItemsCounter
            // 
            ItemsCounter.Location = new Point(268, 65);
            ItemsCounter.Margin = new Padding(4, 3, 4, 3);
            ItemsCounter.Name = "ItemsCounter";
            ItemsCounter.Size = new Size(73, 25);
            ItemsCounter.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.IndianRed;
            label1.Location = new Point(219, 24);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(66, 17);
            label1.TabIndex = 0;
            label1.Text = "الكافتيريا";
            // 
            // ItemsCombo
            // 
            ItemsCombo.FormattingEnabled = true;
            ItemsCombo.Location = new Point(89, 65);
            ItemsCombo.Margin = new Padding(4, 3, 4, 3);
            ItemsCombo.Name = "ItemsCombo";
            ItemsCombo.Size = new Size(166, 25);
            ItemsCombo.TabIndex = 1;
            // 
            // OrderGrid
            // 
            OrderGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            OrderGrid.Dock = DockStyle.Bottom;
            OrderGrid.Location = new Point(0, 135);
            OrderGrid.Margin = new Padding(4, 3, 4, 3);
            OrderGrid.Name = "OrderGrid";
            OrderGrid.Size = new Size(543, 224);
            OrderGrid.TabIndex = 1;
            OrderGrid.CellContentClick += OrderGrid_CellContentClick;
            // 
            // panelFooter
            // 
            panelFooter.Controls.Add(LeaveBtn);
            panelFooter.Controls.Add(CloseBtn);
            panelFooter.Dock = DockStyle.Bottom;
            panelFooter.Location = new Point(0, 489);
            panelFooter.Margin = new Padding(4, 3, 4, 3);
            panelFooter.Name = "panelFooter";
            panelFooter.Size = new Size(1186, 76);
            panelFooter.TabIndex = 1;
            // 
            // LeaveBtn
            // 
            LeaveBtn.BackColor = Color.Red;
            LeaveBtn.FlatAppearance.BorderSize = 0;
            LeaveBtn.FlatStyle = FlatStyle.Flat;
            LeaveBtn.Location = new Point(164, 18);
            LeaveBtn.Margin = new Padding(4, 3, 4, 3);
            LeaveBtn.Name = "LeaveBtn";
            LeaveBtn.Size = new Size(242, 37);
            LeaveBtn.TabIndex = 1;
            LeaveBtn.Text = "المغادرة";
            LeaveBtn.UseVisualStyleBackColor = false;
            // 
            // CloseBtn
            // 
            CloseBtn.Location = new Point(530, 18);
            CloseBtn.Margin = new Padding(4, 3, 4, 3);
            CloseBtn.Name = "CloseBtn";
            CloseBtn.Size = new Size(266, 37);
            CloseBtn.TabIndex = 0;
            CloseBtn.Text = "اغلاق";
            CloseBtn.UseVisualStyleBackColor = true;
            // 
            // panelDevice
            // 
            panelDevice.Controls.Add(panel4);
            panelDevice.Controls.Add(panel3);
            panelDevice.Dock = DockStyle.Left;
            panelDevice.Location = new Point(0, 113);
            panelDevice.Margin = new Padding(4, 3, 4, 3);
            panelDevice.Name = "panelDevice";
            panelDevice.Size = new Size(505, 376);
            panelDevice.TabIndex = 3;
            // 
            // panel4
            // 
            panel4.Controls.Add(dateTimePicker1);
            panel4.Controls.Add(numericUpDown2);
            panel4.Controls.Add(numericUpDown1);
            panel4.Location = new Point(35, 156);
            panel4.Margin = new Padding(4, 3, 4, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(430, 113);
            panel4.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(13, 10);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.ShowCheckBox = true;
            dateTimePicker1.ShowUpDown = true;
            dateTimePicker1.CustomFormat = "yyyy-MM-dd hh:mm tt";
            dateTimePicker1.Size = new Size(385, 25);
            dateTimePicker1.TabIndex = 2;
            dateTimePicker1.UseWaitCursor = true;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(104, 79);
            numericUpDown2.Margin = new Padding(4, 3, 4, 3);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(68, 25);
            numericUpDown2.TabIndex = 1;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(104, 41);
            numericUpDown1.Margin = new Padding(4, 3, 4, 3);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(68, 25);
            numericUpDown1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(EndBtn);
            panel3.Controls.Add(StartBtn);
            panel3.Location = new Point(35, 37);
            panel3.Margin = new Padding(4, 3, 4, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(430, 113);
            panel3.TabIndex = 0;
            // 
            // EndBtn
            // 
            EndBtn.Location = new Point(118, 18);
            EndBtn.Margin = new Padding(4, 3, 4, 3);
            EndBtn.Name = "EndBtn";
            EndBtn.Size = new Size(86, 26);
            EndBtn.TabIndex = 1;
            EndBtn.Text = "End";
            EndBtn.UseVisualStyleBackColor = true;
            EndBtn.Click += EndBtn_Click;
            // 
            // StartBtn
            // 
            StartBtn.Location = new Point(222, 18);
            StartBtn.Margin = new Padding(4, 3, 4, 3);
            StartBtn.Name = "StartBtn";
            StartBtn.Size = new Size(86, 26);
            StartBtn.TabIndex = 0;
            StartBtn.Text = "Start";
            StartBtn.UseVisualStyleBackColor = true;
            StartBtn.Click += StartBtn_Click;
            // 
            // SingleDevice
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1186, 565);
            Controls.Add(panelDevice);
            Controls.Add(panelCafe);
            Controls.Add(panelFooter);
            Controls.Add(panelHead);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "SingleDevice";
            Text = "SingleDevice";
            Load += SingleDevice_Load;
            panelHead.ResumeLayout(false);
            panelHead.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelCafe.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ItemsCounter).EndInit();
            ((System.ComponentModel.ISupportInitialize)OrderGrid).EndInit();
            panelFooter.ResumeLayout(false);
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
        private DateTimePicker dateTimePicker1;
    }
}