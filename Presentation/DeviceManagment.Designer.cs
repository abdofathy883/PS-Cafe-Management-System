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
            ((System.ComponentModel.ISupportInitialize)DevicesTable).BeginInit();
            ((System.ComponentModel.ISupportInitialize)HourlyRateInput).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(777, 15);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(67, 19);
            label2.TabIndex = 1;
            label2.Text = "اسم الجهاز";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(552, 14);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(74, 19);
            label3.TabIndex = 2;
            label3.Text = "سعر الساعة";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(777, 81);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(67, 19);
            label4.TabIndex = 3;
            label4.Text = "نوع الجهاز";
            // 
            // button1
            // 
            button1.Location = new Point(497, 104);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(129, 31);
            button1.TabIndex = 7;
            button1.Text = "اضافة جهاز";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // DevicesTable
            // 
            DevicesTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DevicesTable.Columns.AddRange(new DataGridViewColumn[] { UpdateCellButton, DeleteCellButton });
            DevicesTable.Location = new Point(13, 153);
            DevicesTable.Margin = new Padding(4);
            DevicesTable.Name = "DevicesTable";
            DevicesTable.Size = new Size(880, 190);
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
            DeNameInput.Location = new Point(650, 42);
            DeNameInput.Name = "DeNameInput";
            DeNameInput.Size = new Size(194, 26);
            DeNameInput.TabIndex = 9;
            // 
            // HourlyRateInput
            // 
            HourlyRateInput.Location = new Point(497, 42);
            HourlyRateInput.Name = "HourlyRateInput";
            HourlyRateInput.Size = new Size(127, 26);
            HourlyRateInput.TabIndex = 10;
            // 
            // DeTypeCombo
            // 
            DeTypeCombo.FormattingEnabled = true;
            DeTypeCombo.Items.AddRange(new object[] { "PS4", "PS5" });
            DeTypeCombo.Location = new Point(650, 107);
            DeTypeCombo.Name = "DeTypeCombo";
            DeTypeCombo.Size = new Size(194, 27);
            DeTypeCombo.TabIndex = 11;
            // 
            // DeviceManagment
            // 
            AutoScaleDimensions = new SizeF(10F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(906, 354);
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
            Load += DeviceManagment_Load;
            ((System.ComponentModel.ISupportInitialize)DevicesTable).EndInit();
            ((System.ComponentModel.ISupportInitialize)HourlyRateInput).EndInit();
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
    }
}