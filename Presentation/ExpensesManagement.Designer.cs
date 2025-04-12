namespace PlayStation.Application.Services
{
    partial class ExpensesForm
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
            label2 = new Label();
            ExpensesAmountInput = new NumericUpDown();
            label3 = new Label();
            ExpensesDescInput = new TextBox();
            label4 = new Label();
            ExpensesUser = new ComboBox();
            label5 = new Label();
            ExpensesDateTime = new DateTimePicker();
            AddExpensesBtn = new Button();
            ExpensesGrid = new DataGridView();
            label6 = new Label();
            previousBtn = new Button();
            NextBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)ExpensesAmountInput).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ExpensesGrid).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(930, 65);
            label2.Name = "label2";
            label2.Size = new Size(40, 19);
            label2.TabIndex = 1;
            label2.Text = "المبلغ";
            // 
            // ExpensesAmountInput
            // 
            ExpensesAmountInput.DecimalPlaces = 2;
            ExpensesAmountInput.Location = new Point(906, 93);
            ExpensesAmountInput.Name = "ExpensesAmountInput";
            ExpensesAmountInput.Size = new Size(64, 23);
            ExpensesAmountInput.TabIndex = 2;
            ExpensesAmountInput.TextAlign = HorizontalAlignment.Right;
            ExpensesAmountInput.UpDownAlign = LeftRightAlignment.Left;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(852, 65);
            label3.Name = "label3";
            label3.Size = new Size(48, 19);
            label3.TabIndex = 3;
            label3.Text = "الوصف";
            // 
            // ExpensesDescInput
            // 
            ExpensesDescInput.Location = new Point(738, 93);
            ExpensesDescInput.Name = "ExpensesDescInput";
            ExpensesDescInput.Size = new Size(162, 23);
            ExpensesDescInput.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(675, 67);
            label4.Name = "label4";
            label4.Size = new Size(57, 19);
            label4.TabIndex = 5;
            label4.Text = "المستخدم";
            // 
            // ExpensesUser
            // 
            ExpensesUser.FormattingEnabled = true;
            ExpensesUser.Location = new Point(632, 94);
            ExpensesUser.Name = "ExpensesUser";
            ExpensesUser.Size = new Size(100, 23);
            ExpensesUser.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(578, 66);
            label5.Name = "label5";
            label5.Size = new Size(39, 19);
            label5.TabIndex = 7;
            label5.Text = "الوقت";
            // 
            // ExpensesDateTime
            // 
            ExpensesDateTime.Location = new Point(396, 93);
            ExpensesDateTime.MaxDate = new DateTime(2049, 12, 31, 0, 0, 0, 0);
            ExpensesDateTime.MinDate = new DateTime(2025, 1, 1, 0, 0, 0, 0);
            ExpensesDateTime.Name = "ExpensesDateTime";
            ExpensesDateTime.Size = new Size(230, 23);
            ExpensesDateTime.TabIndex = 8;
            // 
            // AddExpensesBtn
            // 
            AddExpensesBtn.BackColor = Color.FromArgb(32, 87, 129);
            AddExpensesBtn.FlatAppearance.BorderSize = 0;
            AddExpensesBtn.FlatStyle = FlatStyle.Flat;
            AddExpensesBtn.Font = new Font("Arial", 12F, FontStyle.Bold);
            AddExpensesBtn.ForeColor = Color.White;
            AddExpensesBtn.Location = new Point(237, 90);
            AddExpensesBtn.Name = "AddExpensesBtn";
            AddExpensesBtn.Size = new Size(153, 27);
            AddExpensesBtn.TabIndex = 9;
            AddExpensesBtn.Text = "اضافة";
            AddExpensesBtn.UseVisualStyleBackColor = false;
            AddExpensesBtn.Click += AddExpensesBtn_Click;
            // 
            // ExpensesGrid
            // 
            ExpensesGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ExpensesGrid.Location = new Point(237, 129);
            ExpensesGrid.Name = "ExpensesGrid";
            ExpensesGrid.Size = new Size(734, 370);
            ExpensesGrid.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(846, 20);
            label6.Name = "label6";
            label6.Size = new Size(125, 24);
            label6.TabIndex = 11;
            label6.Text = "اضافة مصروفات";
            // 
            // previousBtn
            // 
            previousBtn.BackColor = Color.FromArgb(32, 87, 129);
            previousBtn.FlatAppearance.BorderSize = 0;
            previousBtn.FlatStyle = FlatStyle.Flat;
            previousBtn.Font = new Font("Arial", 12F, FontStyle.Bold);
            previousBtn.ForeColor = Color.White;
            previousBtn.Location = new Point(237, 578);
            previousBtn.Name = "previousBtn";
            previousBtn.Size = new Size(124, 37);
            previousBtn.TabIndex = 1;
            previousBtn.Text = "السابق";
            previousBtn.UseVisualStyleBackColor = false;
            previousBtn.Click += previousBtn_Click;
            // 
            // NextBtn
            // 
            NextBtn.BackColor = Color.FromArgb(32, 87, 129);
            NextBtn.FlatAppearance.BorderSize = 0;
            NextBtn.FlatStyle = FlatStyle.Flat;
            NextBtn.Font = new Font("Arial", 12F, FontStyle.Bold);
            NextBtn.ForeColor = Color.White;
            NextBtn.Location = new Point(840, 578);
            NextBtn.Name = "NextBtn";
            NextBtn.Size = new Size(131, 37);
            NextBtn.TabIndex = 0;
            NextBtn.Text = "التالي";
            NextBtn.UseVisualStyleBackColor = false;
            NextBtn.Click += NextBtn_Click;
            // 
            // ExpensesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1285, 749);
            Controls.Add(previousBtn);
            Controls.Add(NextBtn);
            Controls.Add(label6);
            Controls.Add(ExpensesGrid);
            Controls.Add(AddExpensesBtn);
            Controls.Add(ExpensesDateTime);
            Controls.Add(label5);
            Controls.Add(ExpensesUser);
            Controls.Add(label4);
            Controls.Add(ExpensesDescInput);
            Controls.Add(label3);
            Controls.Add(ExpensesAmountInput);
            Controls.Add(label2);
            Name = "ExpensesForm";
            Text = "المصروفات";
            Load += ExpensesForm_Load;
            ((System.ComponentModel.ISupportInitialize)ExpensesAmountInput).EndInit();
            ((System.ComponentModel.ISupportInitialize)ExpensesGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private NumericUpDown ExpensesAmountInput;
        private Label label3;
        private TextBox ExpensesDescInput;
        private Label label4;
        private ComboBox ExpensesUser;
        private Label label5;
        private DateTimePicker ExpensesDateTime;
        private Button AddExpensesBtn;
        private DataGridView ExpensesGrid;
        private Label label6;
        private Panel panel1;
        private Button NextBtn;
        private Button previousBtn;
    }
}