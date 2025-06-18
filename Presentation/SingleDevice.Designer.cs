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
            components = new System.ComponentModel.Container();
            panelHead = new Panel();
            ClientNameInput = new TextBox();
            IsCreditCheckBox = new CheckBox();
            ConfirmPaymentBtn = new Button();
            AmountPaidInput = new NumericUpDown();
            MultiPriceLbl = new Label();
            label7 = new Label();
            SinglePriceLbl = new Label();
            label5 = new Label();
            CafeteriaPriceLbl = new Label();
            label4 = new Label();
            TotalHoursLbl = new Label();
            label3 = new Label();
            TotalPriceLbl = new Label();
            TimerLbl = new Label();
            label2 = new Label();
            DeviceNameLbl = new Label();
            panelCafe = new Panel();
            panel2 = new Panel();
            AddItemBtn = new Button();
            ItemsCounter = new NumericUpDown();
            label1 = new Label();
            ItemsCombo = new ComboBox();
            OrderGrid = new DataGridView();
            DeleteBtb = new DataGridViewButtonColumn();
            panelDevice = new Panel();
            panel3 = new Panel();
            ResetBtn = new Button();
            ChangeSessionTypeBtn = new Button();
            SingleRadio = new RadioButton();
            MultiRadio = new RadioButton();
            dateTimePickerEnd = new DateTimePicker();
            EndBtn = new Button();
            dateTimePicker1 = new DateTimePicker();
            StartBtn = new Button();
            timer = new System.Windows.Forms.Timer(components);
            panelHead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AmountPaidInput).BeginInit();
            panelCafe.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ItemsCounter).BeginInit();
            ((System.ComponentModel.ISupportInitialize)OrderGrid).BeginInit();
            panelDevice.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panelHead
            // 
            panelHead.Controls.Add(ClientNameInput);
            panelHead.Controls.Add(IsCreditCheckBox);
            panelHead.Controls.Add(ConfirmPaymentBtn);
            panelHead.Controls.Add(AmountPaidInput);
            panelHead.Controls.Add(MultiPriceLbl);
            panelHead.Controls.Add(label7);
            panelHead.Controls.Add(SinglePriceLbl);
            panelHead.Controls.Add(label5);
            panelHead.Controls.Add(CafeteriaPriceLbl);
            panelHead.Controls.Add(label4);
            panelHead.Controls.Add(TotalHoursLbl);
            panelHead.Controls.Add(label3);
            panelHead.Controls.Add(TotalPriceLbl);
            panelHead.Controls.Add(TimerLbl);
            panelHead.Controls.Add(label2);
            panelHead.Controls.Add(DeviceNameLbl);
            panelHead.Dock = DockStyle.Top;
            panelHead.Location = new Point(0, 0);
            panelHead.Margin = new Padding(4, 3, 4, 3);
            panelHead.Name = "panelHead";
            panelHead.Size = new Size(1186, 113);
            panelHead.TabIndex = 0;
            // 
            // ClientNameInput
            // 
            ClientNameInput.Location = new Point(964, 22);
            ClientNameInput.Name = "ClientNameInput";
            ClientNameInput.PlaceholderText = "اسم العميل";
            ClientNameInput.RightToLeft = RightToLeft.Yes;
            ClientNameInput.Size = new Size(197, 25);
            ClientNameInput.TabIndex = 14;
            // 
            // IsCreditCheckBox
            // 
            IsCreditCheckBox.AutoSize = true;
            IsCreditCheckBox.Location = new Point(1077, 60);
            IsCreditCheckBox.Name = "IsCreditCheckBox";
            IsCreditCheckBox.RightToLeft = RightToLeft.Yes;
            IsCreditCheckBox.Size = new Size(84, 21);
            IsCreditCheckBox.TabIndex = 13;
            IsCreditCheckBox.Text = "دفع بالاجل";
            IsCreditCheckBox.UseVisualStyleBackColor = true;
            IsCreditCheckBox.CheckedChanged += IsCreditCheckBox_CheckedChanged;
            // 
            // ConfirmPaymentBtn
            // 
            ConfirmPaymentBtn.Location = new Point(884, 53);
            ConfirmPaymentBtn.Name = "ConfirmPaymentBtn";
            ConfirmPaymentBtn.Size = new Size(187, 32);
            ConfirmPaymentBtn.TabIndex = 12;
            ConfirmPaymentBtn.Text = "انهاء";
            ConfirmPaymentBtn.UseVisualStyleBackColor = true;
            ConfirmPaymentBtn.Click += ConfirmPaymentBtn_Click;
            // 
            // AmountPaidInput
            // 
            AmountPaidInput.Location = new Point(884, 22);
            AmountPaidInput.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            AmountPaidInput.Name = "AmountPaidInput";
            AmountPaidInput.Size = new Size(74, 25);
            AmountPaidInput.TabIndex = 11;
            AmountPaidInput.ValueChanged += TotalCostInput_ValueChanged;
            // 
            // MultiPriceLbl
            // 
            MultiPriceLbl.AutoSize = true;
            MultiPriceLbl.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MultiPriceLbl.Location = new Point(202, 58);
            MultiPriceLbl.Name = "MultiPriceLbl";
            MultiPriceLbl.Size = new Size(63, 32);
            MultiPriceLbl.TabIndex = 10;
            MultiPriceLbl.Text = "0.00";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(192, 23);
            label7.Name = "label7";
            label7.Size = new Size(93, 22);
            label7.TabIndex = 9;
            label7.Text = "حساب المالتي";
            // 
            // SinglePriceLbl
            // 
            SinglePriceLbl.AutoSize = true;
            SinglePriceLbl.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SinglePriceLbl.Location = new Point(331, 58);
            SinglePriceLbl.Name = "SinglePriceLbl";
            SinglePriceLbl.Size = new Size(63, 32);
            SinglePriceLbl.TabIndex = 8;
            SinglePriceLbl.Text = "0.00";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(315, 23);
            label5.Name = "label5";
            label5.Size = new Size(97, 22);
            label5.TabIndex = 7;
            label5.Text = "حساب السنجل";
            // 
            // CafeteriaPriceLbl
            // 
            CafeteriaPriceLbl.AutoSize = true;
            CafeteriaPriceLbl.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CafeteriaPriceLbl.Location = new Point(459, 61);
            CafeteriaPriceLbl.Name = "CafeteriaPriceLbl";
            CafeteriaPriceLbl.Size = new Size(59, 29);
            CafeteriaPriceLbl.TabIndex = 6;
            CafeteriaPriceLbl.Text = "0.00";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(435, 23);
            label4.Name = "label4";
            label4.Size = new Size(96, 22);
            label4.TabIndex = 5;
            label4.Text = "حساب الطلبات";
            // 
            // TotalHoursLbl
            // 
            TotalHoursLbl.AutoSize = true;
            TotalHoursLbl.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TotalHoursLbl.Location = new Point(584, 61);
            TotalHoursLbl.Name = "TotalHoursLbl";
            TotalHoursLbl.Size = new Size(59, 29);
            TotalHoursLbl.TabIndex = 4;
            TotalHoursLbl.Text = "0.00";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(568, 23);
            label3.Name = "label3";
            label3.Size = new Size(89, 22);
            label3.TabIndex = 3;
            label3.Text = "عدد الساعات";
            // 
            // TotalPriceLbl
            // 
            TotalPriceLbl.AutoSize = true;
            TotalPriceLbl.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TotalPriceLbl.ForeColor = Color.White;
            TotalPriceLbl.Location = new Point(703, 61);
            TotalPriceLbl.Margin = new Padding(4, 0, 4, 0);
            TotalPriceLbl.Name = "TotalPriceLbl";
            TotalPriceLbl.Size = new Size(59, 29);
            TotalPriceLbl.TabIndex = 1;
            TotalPriceLbl.Text = "0.00";
            // 
            // TimerLbl
            // 
            TimerLbl.AutoSize = true;
            TimerLbl.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TimerLbl.ForeColor = Color.White;
            TimerLbl.Location = new Point(39, 61);
            TimerLbl.Margin = new Padding(4, 0, 4, 0);
            TimerLbl.Name = "TimerLbl";
            TimerLbl.Size = new Size(112, 32);
            TimerLbl.TabIndex = 2;
            TimerLbl.Text = "00:00:00";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(682, 25);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(102, 22);
            label2.TabIndex = 0;
            label2.Text = "اجمالي الحساب";
            // 
            // DeviceNameLbl
            // 
            DeviceNameLbl.AutoSize = true;
            DeviceNameLbl.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DeviceNameLbl.ForeColor = Color.White;
            DeviceNameLbl.Location = new Point(39, 23);
            DeviceNameLbl.Margin = new Padding(4, 0, 4, 0);
            DeviceNameLbl.Name = "DeviceNameLbl";
            DeviceNameLbl.Size = new Size(69, 24);
            DeviceNameLbl.TabIndex = 0;
            DeviceNameLbl.Text = "label1";
            // 
            // panelCafe
            // 
            panelCafe.Controls.Add(panel2);
            panelCafe.Controls.Add(OrderGrid);
            panelCafe.Location = new Point(535, 119);
            panelCafe.Margin = new Padding(4, 3, 4, 3);
            panelCafe.Name = "panelCafe";
            panelCafe.Size = new Size(651, 446);
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
            panel2.Size = new Size(651, 129);
            panel2.TabIndex = 0;
            // 
            // AddItemBtn
            // 
            AddItemBtn.BackColor = Color.FromArgb(32, 87, 129);
            AddItemBtn.FlatAppearance.BorderSize = 0;
            AddItemBtn.FlatStyle = FlatStyle.Flat;
            AddItemBtn.Font = new Font("Arial", 12F, FontStyle.Bold);
            AddItemBtn.ForeColor = Color.White;
            AddItemBtn.Location = new Point(348, 64);
            AddItemBtn.Margin = new Padding(4, 3, 4, 3);
            AddItemBtn.Name = "AddItemBtn";
            AddItemBtn.Size = new Size(110, 28);
            AddItemBtn.TabIndex = 3;
            AddItemBtn.Text = "اضافة";
            AddItemBtn.UseVisualStyleBackColor = false;
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
            label1.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(244, 21);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(62, 22);
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
            OrderGrid.Columns.AddRange(new DataGridViewColumn[] { DeleteBtb });
            OrderGrid.Dock = DockStyle.Bottom;
            OrderGrid.Location = new Point(0, 123);
            OrderGrid.Margin = new Padding(4, 3, 4, 3);
            OrderGrid.Name = "OrderGrid";
            OrderGrid.Size = new Size(651, 323);
            OrderGrid.TabIndex = 1;
            OrderGrid.CellContentClick += OrderGrid_CellContentClick;
            // 
            // DeleteBtb
            // 
            DeleteBtb.HeaderText = "حذف";
            DeleteBtb.Name = "DeleteBtb";
            DeleteBtb.Text = "حذف";
            DeleteBtb.UseColumnTextForButtonValue = true;
            // 
            // panelDevice
            // 
            panelDevice.Controls.Add(panel3);
            panelDevice.Dock = DockStyle.Left;
            panelDevice.Location = new Point(0, 113);
            panelDevice.Margin = new Padding(4, 3, 4, 3);
            panelDevice.Name = "panelDevice";
            panelDevice.Size = new Size(505, 452);
            panelDevice.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.Controls.Add(ResetBtn);
            panel3.Controls.Add(ChangeSessionTypeBtn);
            panel3.Controls.Add(SingleRadio);
            panel3.Controls.Add(MultiRadio);
            panel3.Controls.Add(dateTimePickerEnd);
            panel3.Controls.Add(EndBtn);
            panel3.Controls.Add(dateTimePicker1);
            panel3.Controls.Add(StartBtn);
            panel3.Location = new Point(35, 37);
            panel3.Margin = new Padding(4, 3, 4, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(430, 225);
            panel3.TabIndex = 0;
            // 
            // ResetBtn
            // 
            ResetBtn.FlatAppearance.BorderSize = 0;
            ResetBtn.FlatStyle = FlatStyle.Flat;
            ResetBtn.Location = new Point(5, 183);
            ResetBtn.Name = "ResetBtn";
            ResetBtn.Size = new Size(422, 29);
            ResetBtn.TabIndex = 7;
            ResetBtn.Text = "لعبة جديدة";
            ResetBtn.UseVisualStyleBackColor = true;
            ResetBtn.Click += ResetBtn_Click;
            // 
            // ChangeSessionTypeBtn
            // 
            ChangeSessionTypeBtn.BackColor = Color.FromArgb(32, 87, 129);
            ChangeSessionTypeBtn.FlatAppearance.BorderSize = 0;
            ChangeSessionTypeBtn.FlatStyle = FlatStyle.Flat;
            ChangeSessionTypeBtn.Font = new Font("Arial", 12F, FontStyle.Bold);
            ChangeSessionTypeBtn.ForeColor = Color.White;
            ChangeSessionTypeBtn.Location = new Point(157, 71);
            ChangeSessionTypeBtn.Margin = new Padding(4, 3, 4, 3);
            ChangeSessionTypeBtn.Name = "ChangeSessionTypeBtn";
            ChangeSessionTypeBtn.Size = new Size(119, 31);
            ChangeSessionTypeBtn.TabIndex = 6;
            ChangeSessionTypeBtn.Text = "تغيير";
            ChangeSessionTypeBtn.UseVisualStyleBackColor = false;
            ChangeSessionTypeBtn.Click += ChangeSessionTypeBtn_Click;
            // 
            // SingleRadio
            // 
            SingleRadio.AutoSize = true;
            SingleRadio.Font = new Font("Arial", 12F, FontStyle.Bold);
            SingleRadio.ForeColor = Color.White;
            SingleRadio.Location = new Point(157, 37);
            SingleRadio.Name = "SingleRadio";
            SingleRadio.RightToLeft = RightToLeft.Yes;
            SingleRadio.Size = new Size(56, 23);
            SingleRadio.TabIndex = 5;
            SingleRadio.TabStop = true;
            SingleRadio.Text = "سنجل";
            SingleRadio.UseVisualStyleBackColor = true;
            // 
            // MultiRadio
            // 
            MultiRadio.AutoSize = true;
            MultiRadio.Font = new Font("Arial", 12F, FontStyle.Bold);
            MultiRadio.ForeColor = Color.White;
            MultiRadio.Location = new Point(221, 37);
            MultiRadio.Name = "MultiRadio";
            MultiRadio.RightToLeft = RightToLeft.Yes;
            MultiRadio.Size = new Size(55, 23);
            MultiRadio.TabIndex = 4;
            MultiRadio.TabStop = true;
            MultiRadio.Text = "مالتي";
            MultiRadio.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerEnd
            // 
            dateTimePickerEnd.CustomFormat = "yyyy/MM/dd - hh:mm:tt";
            dateTimePickerEnd.Format = DateTimePickerFormat.Custom;
            dateTimePickerEnd.Location = new Point(5, 152);
            dateTimePickerEnd.Name = "dateTimePickerEnd";
            dateTimePickerEnd.ShowUpDown = true;
            dateTimePickerEnd.Size = new Size(208, 25);
            dateTimePickerEnd.TabIndex = 3;
            dateTimePickerEnd.ValueChanged += dateTimePickerEnd_ValueChanged;
            // 
            // EndBtn
            // 
            EndBtn.BackColor = Color.FromArgb(32, 87, 129);
            EndBtn.FlatAppearance.BorderSize = 0;
            EndBtn.FlatStyle = FlatStyle.Flat;
            EndBtn.Font = new Font("Arial", 12F, FontStyle.Bold);
            EndBtn.ForeColor = Color.White;
            EndBtn.Location = new Point(5, 115);
            EndBtn.Margin = new Padding(4, 3, 4, 3);
            EndBtn.Name = "EndBtn";
            EndBtn.Size = new Size(208, 31);
            EndBtn.TabIndex = 1;
            EndBtn.Text = "نهاية";
            EndBtn.UseVisualStyleBackColor = false;
            EndBtn.Click += EndBtn_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarForeColor = SystemColors.MenuHighlight;
            dateTimePicker1.Checked = false;
            dateTimePicker1.CustomFormat = "yyyy/MM/dd - hh:mm:tt";
            dateTimePicker1.DropDownAlign = LeftRightAlignment.Right;
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(221, 152);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.RightToLeft = RightToLeft.No;
            dateTimePicker1.ShowUpDown = true;
            dateTimePicker1.Size = new Size(206, 25);
            dateTimePicker1.TabIndex = 2;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            dateTimePicker1.KeyPress += dateTimePicker1_KeyPress;
            dateTimePicker1.MouseDown += dateTimePicker1_MouseDown;
            // 
            // StartBtn
            // 
            StartBtn.BackColor = Color.FromArgb(32, 87, 129);
            StartBtn.FlatAppearance.BorderSize = 0;
            StartBtn.FlatStyle = FlatStyle.Flat;
            StartBtn.Font = new Font("Arial", 12F, FontStyle.Bold);
            StartBtn.ForeColor = Color.White;
            StartBtn.Location = new Point(221, 115);
            StartBtn.Margin = new Padding(4, 3, 4, 3);
            StartBtn.Name = "StartBtn";
            StartBtn.Size = new Size(206, 31);
            StartBtn.TabIndex = 0;
            StartBtn.Text = "ابدا";
            StartBtn.UseVisualStyleBackColor = false;
            StartBtn.Click += StartBtn_Click;
            // 
            // timer
            // 
            timer.Interval = 1000;
            timer.Tick += timer_Tick;
            // 
            // SingleDevice
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1186, 565);
            Controls.Add(panelDevice);
            Controls.Add(panelCafe);
            Controls.Add(panelHead);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SingleDevice";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ادارة الجهاز";
            panelHead.ResumeLayout(false);
            panelHead.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)AmountPaidInput).EndInit();
            panelCafe.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ItemsCounter).EndInit();
            ((System.ComponentModel.ISupportInitialize)OrderGrid).EndInit();
            panelDevice.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHead;
        private Label DeviceNameLbl;
        private Label TotalPriceLbl;
        private Label label2;
        private Label TimerLbl;
        private Panel panelCafe;
        private Panel panelDevice;
        private Panel panel2;
        private DataGridView OrderGrid;
        private Button AddItemBtn;
        private NumericUpDown ItemsCounter;
        private ComboBox ItemsCombo;
        private Label label1;
        private Panel panel3;
        private Button StartBtn;
        private Button EndBtn;
        private DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Timer timer;
        private DateTimePicker dateTimePickerEnd;
        private RadioButton SingleRadio;
        private RadioButton MultiRaadio;
        private RadioButton MultiRadio;
        private Button ChangeSessionTypeBtn;
        private DataGridViewButtonColumn DeleteBtb;
        private Button ResetBtn;
        private Label TotalHoursLbl;
        private Label label3;
        private Label CafeteriaPriceLbl;
        private Label label4;
        private Label MultiPriceLbl;
        private Label label7;
        private Label SinglePriceLbl;
        private Label label5;
        private NumericUpDown AmountPaidInput;
        private Button ConfirmPaymentBtn;
        private CheckBox IsCreditCheckBox;
        private TextBox ClientNameInput;
    }
}