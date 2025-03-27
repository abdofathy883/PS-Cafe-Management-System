namespace PlayStation.Presentation
{
    partial class DeviceManagment
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
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            DevicesTable = new DataGridView();
            UpdateCellButton = new DataGridViewButtonColumn();
            DeleteCellButton = new DataGridViewButtonColumn();
            DeNameInput = new TextBox();
            HourlyRateInput = new NumericUpDown();
            DeTypeCombo = new ComboBox();
            HourlyRateMulti = new NumericUpDown();
            label1 = new Label();
            panel1 = new Panel();
            NextBtn = new Button();
            PreviousBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)DevicesTable).BeginInit();
            ((System.ComponentModel.ISupportInitialize)HourlyRateInput).BeginInit();
            ((System.ComponentModel.ISupportInitialize)HourlyRateMulti).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(1138, 24);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(67, 19);
            label2.TabIndex = 1;
            label2.Text = "اسم الجهاز";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(677, 25);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(107, 19);
            label3.TabIndex = 2;
            label3.Text = "سعر الساعة سنجل";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(895, 24);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(67, 19);
            label4.TabIndex = 3;
            label4.Text = "نوع الجهاز";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(32, 87, 129);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(372, 48);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(153, 41);
            button1.TabIndex = 7;
            button1.Text = "اضافة جهاز";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // DevicesTable
            // 
            DevicesTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DevicesTable.Columns.AddRange(new DataGridViewColumn[] { UpdateCellButton, DeleteCellButton });
            DevicesTable.Location = new Point(81, 102);
            DevicesTable.Margin = new Padding(4);
            DevicesTable.Name = "DevicesTable";
            DevicesTable.Size = new Size(1191, 560);
            DevicesTable.TabIndex = 8;
            DevicesTable.CellContentClick += DevicesTable_CellContentClick;
            // 
            // UpdateCellButton
            // 
            UpdateCellButton.HeaderText = "تحديث";
            UpdateCellButton.Name = "UpdateCellButton";
            UpdateCellButton.Text = "تحديث";
            UpdateCellButton.UseColumnTextForButtonValue = true;
            // 
            // DeleteCellButton
            // 
            DeleteCellButton.HeaderText = "حذف";
            DeleteCellButton.Name = "DeleteCellButton";
            DeleteCellButton.Text = "حذف";
            DeleteCellButton.UseColumnTextForButtonValue = true;
            // 
            // DeNameInput
            // 
            DeNameInput.Location = new Point(986, 55);
            DeNameInput.Name = "DeNameInput";
            DeNameInput.Size = new Size(234, 26);
            DeNameInput.TabIndex = 9;
            // 
            // HourlyRateInput
            // 
            HourlyRateInput.Location = new Point(667, 53);
            HourlyRateInput.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            HourlyRateInput.Name = "HourlyRateInput";
            HourlyRateInput.Size = new Size(129, 26);
            HourlyRateInput.TabIndex = 10;
            // 
            // DeTypeCombo
            // 
            DeTypeCombo.FormattingEnabled = true;
            DeTypeCombo.Items.AddRange(new object[] { "PS4", "PS5" });
            DeTypeCombo.Location = new Point(802, 53);
            DeTypeCombo.Name = "DeTypeCombo";
            DeTypeCombo.Size = new Size(178, 27);
            DeTypeCombo.TabIndex = 11;
            // 
            // HourlyRateMulti
            // 
            HourlyRateMulti.Location = new Point(532, 53);
            HourlyRateMulti.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            HourlyRateMulti.Name = "HourlyRateMulti";
            HourlyRateMulti.Size = new Size(129, 26);
            HourlyRateMulti.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(533, 25);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(106, 19);
            label1.TabIndex = 12;
            label1.Text = "سعر الساعة مالتي";
            // 
            // panel1
            // 
            panel1.Controls.Add(NextBtn);
            panel1.Controls.Add(PreviousBtn);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 694);
            panel1.Name = "panel1";
            panel1.Size = new Size(1285, 55);
            panel1.TabIndex = 14;
            // 
            // NextBtn
            // 
            NextBtn.BackColor = Color.FromArgb(32, 87, 129);
            NextBtn.FlatAppearance.BorderSize = 0;
            NextBtn.FlatStyle = FlatStyle.Flat;
            NextBtn.ForeColor = Color.White;
            NextBtn.Location = new Point(1120, 3);
            NextBtn.Name = "NextBtn";
            NextBtn.Size = new Size(100, 40);
            NextBtn.TabIndex = 1;
            NextBtn.Text = "التالي";
            NextBtn.UseVisualStyleBackColor = false;
            NextBtn.Click += NextBtn_Click;
            // 
            // PreviousBtn
            // 
            PreviousBtn.BackColor = Color.FromArgb(32, 87, 129);
            PreviousBtn.FlatAppearance.BorderSize = 0;
            PreviousBtn.FlatStyle = FlatStyle.Flat;
            PreviousBtn.ForeColor = Color.White;
            PreviousBtn.Location = new Point(163, 3);
            PreviousBtn.Name = "PreviousBtn";
            PreviousBtn.Size = new Size(100, 40);
            PreviousBtn.TabIndex = 0;
            PreviousBtn.Text = "السابق";
            PreviousBtn.UseVisualStyleBackColor = false;
            PreviousBtn.Click += PreviousBtn_Click;
            // 
            // DeviceManagment
            // 
            AutoScaleDimensions = new SizeF(10F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1285, 749);
            Controls.Add(panel1);
            Controls.Add(HourlyRateMulti);
            Controls.Add(label1);
            Controls.Add(DeTypeCombo);
            Controls.Add(HourlyRateInput);
            Controls.Add(DeNameInput);
            Controls.Add(DevicesTable);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 178);
            Margin = new Padding(4);
            Name = "DeviceManagment";
            Text = "ادارة الاجهزة";
            ((System.ComponentModel.ISupportInitialize)DevicesTable).EndInit();
            ((System.ComponentModel.ISupportInitialize)HourlyRateInput).EndInit();
            ((System.ComponentModel.ISupportInitialize)HourlyRateMulti).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
        private DataGridView DevicesTable;
        private TextBox DeNameInput;
        private NumericUpDown HourlyRateInput;
        private ComboBox DeTypeCombo;
        private DataGridViewButtonColumn UpdateCellButton;
        private DataGridViewButtonColumn DeleteCellButton;
        private NumericUpDown numericUpDown1;
        private Label label1;
        private NumericUpDown HourlyRateMulti;
        private Panel panel1;
        private Button NextBtn;
        private Button PreviousBtn;
    }
}