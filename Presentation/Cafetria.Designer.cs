﻿namespace PlayStation.Presentation
{
    partial class Cafetria
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
            ProductNameInput = new TextBox();
            label3 = new Label();
            ProductPriceInput = new NumericUpDown();
            label4 = new Label();
            ProductStockInput = new NumericUpDown();
            AddItemBtn = new Button();
            ProductsGrid = new DataGridView();
            UpdateItemBtn = new DataGridViewButtonColumn();
            NextBtn = new Button();
            PreviousBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)ProductPriceInput).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ProductStockInput).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ProductsGrid).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(791, 34);
            label2.Name = "label2";
            label2.Size = new Size(65, 19);
            label2.TabIndex = 1;
            label2.Text = "اسم المنتج";
            // 
            // ProductNameInput
            // 
            ProductNameInput.Location = new Point(705, 59);
            ProductNameInput.Name = "ProductNameInput";
            ProductNameInput.Size = new Size(151, 23);
            ProductNameInput.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(659, 34);
            label3.Name = "label3";
            label3.Size = new Size(40, 19);
            label3.TabIndex = 3;
            label3.Text = "السعر";
            // 
            // ProductPriceInput
            // 
            ProductPriceInput.BorderStyle = BorderStyle.FixedSingle;
            ProductPriceInput.DecimalPlaces = 2;
            ProductPriceInput.Location = new Point(612, 59);
            ProductPriceInput.Name = "ProductPriceInput";
            ProductPriceInput.Size = new Size(87, 23);
            ProductPriceInput.TabIndex = 4;
            ProductPriceInput.TextAlign = HorizontalAlignment.Right;
            ProductPriceInput.UpDownAlign = LeftRightAlignment.Left;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(551, 34);
            label4.Name = "label4";
            label4.Size = new Size(55, 19);
            label4.TabIndex = 5;
            label4.Text = "المخزون";
            // 
            // ProductStockInput
            // 
            ProductStockInput.Location = new Point(520, 59);
            ProductStockInput.Name = "ProductStockInput";
            ProductStockInput.Size = new Size(86, 23);
            ProductStockInput.TabIndex = 6;
            ProductStockInput.TextAlign = HorizontalAlignment.Right;
            ProductStockInput.UpDownAlign = LeftRightAlignment.Left;
            // 
            // AddItemBtn
            // 
            AddItemBtn.BackColor = Color.FromArgb(32, 87, 129);
            AddItemBtn.FlatAppearance.BorderSize = 0;
            AddItemBtn.FlatStyle = FlatStyle.Flat;
            AddItemBtn.Font = new Font("Arial", 12F, FontStyle.Bold);
            AddItemBtn.ForeColor = Color.White;
            AddItemBtn.Location = new Point(400, 58);
            AddItemBtn.Name = "AddItemBtn";
            AddItemBtn.Size = new Size(114, 28);
            AddItemBtn.TabIndex = 7;
            AddItemBtn.Text = "اضافة";
            AddItemBtn.UseVisualStyleBackColor = false;
            AddItemBtn.Click += AddItemBtn_Click;
            // 
            // ProductsGrid
            // 
            ProductsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ProductsGrid.Columns.AddRange(new DataGridViewColumn[] { UpdateItemBtn });
            ProductsGrid.Location = new Point(261, 98);
            ProductsGrid.Name = "ProductsGrid";
            ProductsGrid.RightToLeft = RightToLeft.Yes;
            ProductsGrid.Size = new Size(595, 396);
            ProductsGrid.TabIndex = 8;
            ProductsGrid.CellContentClick += ProductsGrid_CellContentClick;
            // 
            // UpdateItemBtn
            // 
            UpdateItemBtn.HeaderText = "تعديل";
            UpdateItemBtn.Name = "UpdateItemBtn";
            UpdateItemBtn.Text = "تعديل";
            UpdateItemBtn.UseColumnTextForButtonValue = true;
            UpdateItemBtn.Width = 70;
            // 
            // NextBtn
            // 
            NextBtn.BackColor = Color.FromArgb(32, 87, 129);
            NextBtn.FlatAppearance.BorderSize = 0;
            NextBtn.FlatStyle = FlatStyle.Flat;
            NextBtn.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NextBtn.ForeColor = Color.White;
            NextBtn.Location = new Point(726, 544);
            NextBtn.Name = "NextBtn";
            NextBtn.Size = new Size(130, 33);
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
            PreviousBtn.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PreviousBtn.ForeColor = Color.White;
            PreviousBtn.Location = new Point(261, 544);
            PreviousBtn.Name = "PreviousBtn";
            PreviousBtn.Size = new Size(149, 33);
            PreviousBtn.TabIndex = 0;
            PreviousBtn.Text = "السابق";
            PreviousBtn.UseVisualStyleBackColor = false;
            PreviousBtn.Click += PreviousBtn_Click;
            // 
            // Cafetria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1285, 600);
            Controls.Add(NextBtn);
            Controls.Add(PreviousBtn);
            Controls.Add(ProductsGrid);
            Controls.Add(AddItemBtn);
            Controls.Add(ProductStockInput);
            Controls.Add(label4);
            Controls.Add(ProductPriceInput);
            Controls.Add(label3);
            Controls.Add(ProductNameInput);
            Controls.Add(label2);
            Name = "Cafetria";
            Text = "Cafetria";
            ((System.ComponentModel.ISupportInitialize)ProductPriceInput).EndInit();
            ((System.ComponentModel.ISupportInitialize)ProductStockInput).EndInit();
            ((System.ComponentModel.ISupportInitialize)ProductsGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private TextBox ProductNameInput;
        private Label label3;
        private NumericUpDown ProductPriceInput;
        private Label label4;
        private NumericUpDown ProductStockInput;
        private Button AddItemBtn;
        private DataGridView ProductsGrid;
        private DataGridViewButtonColumn UpdateItemBtn;
        private Panel panel1;
        private Button NextBtn;
        private Button PreviousBtn;
    }
}