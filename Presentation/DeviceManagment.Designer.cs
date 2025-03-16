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
            ((System.ComponentModel.ISupportInitialize)DevicesTable).BeginInit();
            ((System.ComponentModel.ISupportInitialize)HourlyRateInput).BeginInit();
            ((System.ComponentModel.ISupportInitialize)HourlyRateMulti).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(1016, 76);
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
            label3.Location = new Point(567, 76);
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
            label4.Location = new Point(785, 76);
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
            button1.Location = new Point(222, 95);
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
            DevicesTable.Location = new Point(13, 153);
            DevicesTable.Margin = new Padding(4);
            DevicesTable.Name = "DevicesTable";
            DevicesTable.Size = new Size(1117, 190);
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
            DeNameInput.Location = new Point(876, 107);
            DeNameInput.Name = "DeNameInput";
            DeNameInput.Size = new Size(222, 26);
            DeNameInput.TabIndex = 9;
            // 
            // HourlyRateInput
            // 
            HourlyRateInput.Location = new Point(557, 104);
            HourlyRateInput.Name = "HourlyRateInput";
            HourlyRateInput.Size = new Size(129, 26);
            HourlyRateInput.TabIndex = 10;
            // 
            // DeTypeCombo
            // 
            DeTypeCombo.FormattingEnabled = true;
            DeTypeCombo.Items.AddRange(new object[] { "PS4", "PS5" });
            DeTypeCombo.Location = new Point(692, 105);
            DeTypeCombo.Name = "DeTypeCombo";
            DeTypeCombo.Size = new Size(178, 27);
            DeTypeCombo.TabIndex = 11;
            // 
            // HourlyRateMulti
            // 
            HourlyRateMulti.Location = new Point(382, 104);
            HourlyRateMulti.Name = "HourlyRateMulti";
            HourlyRateMulti.Size = new Size(129, 26);
            HourlyRateMulti.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(383, 76);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(106, 19);
            label1.TabIndex = 12;
            label1.Text = "سعر الساعة مالتي";
            // 
            // DeviceManagment
            // 
            AutoScaleDimensions = new SizeF(10F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 379);
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
    }
}