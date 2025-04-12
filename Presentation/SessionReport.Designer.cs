namespace PlayStation.Presentation
{
    partial class SessionReport
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
            SessionsReportGrid = new DataGridView();
            DailyReportBtn = new Button();
            WeeklyReportBtn = new Button();
            MonthlyReportBtn = new Button();
            dateTimePicker = new DateTimePicker();
            NextBtn = new Button();
            PreviousBtn = new Button();
            TotalLbl = new Label();
            ((System.ComponentModel.ISupportInitialize)SessionsReportGrid).BeginInit();
            SuspendLayout();
            // 
            // SessionsReportGrid
            // 
            SessionsReportGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            SessionsReportGrid.Location = new Point(153, 99);
            SessionsReportGrid.Name = "SessionsReportGrid";
            SessionsReportGrid.Size = new Size(688, 438);
            SessionsReportGrid.TabIndex = 0;
            // 
            // DailyReportBtn
            // 
            DailyReportBtn.BackColor = Color.FromArgb(32, 87, 129);
            DailyReportBtn.FlatAppearance.BorderSize = 0;
            DailyReportBtn.FlatStyle = FlatStyle.Flat;
            DailyReportBtn.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DailyReportBtn.ForeColor = Color.White;
            DailyReportBtn.Location = new Point(717, 59);
            DailyReportBtn.Name = "DailyReportBtn";
            DailyReportBtn.Size = new Size(124, 33);
            DailyReportBtn.TabIndex = 1;
            DailyReportBtn.Text = "اليوم";
            DailyReportBtn.UseVisualStyleBackColor = false;
            DailyReportBtn.Click += DailyReportBtn_Click;
            // 
            // WeeklyReportBtn
            // 
            WeeklyReportBtn.BackColor = Color.FromArgb(32, 87, 129);
            WeeklyReportBtn.FlatAppearance.BorderSize = 0;
            WeeklyReportBtn.FlatStyle = FlatStyle.Flat;
            WeeklyReportBtn.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            WeeklyReportBtn.ForeColor = Color.White;
            WeeklyReportBtn.Location = new Point(587, 60);
            WeeklyReportBtn.Name = "WeeklyReportBtn";
            WeeklyReportBtn.Size = new Size(124, 33);
            WeeklyReportBtn.TabIndex = 2;
            WeeklyReportBtn.Text = "الاسبوع";
            WeeklyReportBtn.UseVisualStyleBackColor = false;
            WeeklyReportBtn.Click += WeeklyReportBtn_Click;
            // 
            // MonthlyReportBtn
            // 
            MonthlyReportBtn.BackColor = Color.FromArgb(32, 87, 129);
            MonthlyReportBtn.FlatAppearance.BorderSize = 0;
            MonthlyReportBtn.FlatStyle = FlatStyle.Flat;
            MonthlyReportBtn.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MonthlyReportBtn.ForeColor = Color.White;
            MonthlyReportBtn.Location = new Point(447, 60);
            MonthlyReportBtn.Name = "MonthlyReportBtn";
            MonthlyReportBtn.Size = new Size(134, 33);
            MonthlyReportBtn.TabIndex = 3;
            MonthlyReportBtn.Text = "الشهر";
            MonthlyReportBtn.UseVisualStyleBackColor = false;
            MonthlyReportBtn.Click += MonthlyReportBtn_Click;
            // 
            // dateTimePicker
            // 
            dateTimePicker.Location = new Point(153, 63);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(288, 23);
            dateTimePicker.TabIndex = 4;
            // 
            // NextBtn
            // 
            NextBtn.BackColor = Color.FromArgb(32, 87, 129);
            NextBtn.FlatAppearance.BorderSize = 0;
            NextBtn.FlatStyle = FlatStyle.Flat;
            NextBtn.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NextBtn.ForeColor = Color.White;
            NextBtn.Location = new Point(723, 543);
            NextBtn.Name = "NextBtn";
            NextBtn.Size = new Size(118, 33);
            NextBtn.TabIndex = 5;
            NextBtn.Text = "التالي";
            NextBtn.UseVisualStyleBackColor = false;
            NextBtn.Click += NextBtn_Click;
            // 
            // PreviousBtn
            // 
            PreviousBtn.BackColor = Color.FromArgb(32, 87, 129);
            PreviousBtn.FlatAppearance.BorderSize = 0;
            PreviousBtn.FlatStyle = FlatStyle.Flat;
            PreviousBtn.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PreviousBtn.ForeColor = Color.White;
            PreviousBtn.Location = new Point(153, 543);
            PreviousBtn.Name = "PreviousBtn";
            PreviousBtn.Size = new Size(130, 33);
            PreviousBtn.TabIndex = 6;
            PreviousBtn.Text = "السابق";
            PreviousBtn.UseVisualStyleBackColor = false;
            PreviousBtn.Click += PreviousBtn_Click;
            // 
            // TotalLbl
            // 
            TotalLbl.AutoSize = true;
            TotalLbl.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TotalLbl.ForeColor = Color.White;
            TotalLbl.Location = new Point(484, 550);
            TotalLbl.Name = "TotalLbl";
            TotalLbl.Size = new Size(54, 19);
            TotalLbl.TabIndex = 7;
            TotalLbl.Text = "label1";
            // 
            // SessionReport
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1037, 609);
            Controls.Add(TotalLbl);
            Controls.Add(PreviousBtn);
            Controls.Add(NextBtn);
            Controls.Add(dateTimePicker);
            Controls.Add(MonthlyReportBtn);
            Controls.Add(WeeklyReportBtn);
            Controls.Add(DailyReportBtn);
            Controls.Add(SessionsReportGrid);
            Name = "SessionReport";
            Text = "SessionReport";
            ((System.ComponentModel.ISupportInitialize)SessionsReportGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView SessionsReportGrid;
        private Button DailyReportBtn;
        private Button WeeklyReportBtn;
        private Button MonthlyReportBtn;
        private DateTimePicker dateTimePicker;
        private Button NextBtn;
        private Button PreviousBtn;
        private Label TotalLbl;
    }
}