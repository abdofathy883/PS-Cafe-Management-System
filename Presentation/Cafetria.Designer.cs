namespace PlayStation.Presentation
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
            ((System.ComponentModel.ISupportInitialize)ProductPriceInput).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ProductStockInput).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ProductsGrid).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(273, 14);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 1;
            label2.Text = "اسم المنتج";
            // 
            // ProductNameInput
            // 
            ProductNameInput.Location = new Point(203, 42);
            ProductNameInput.Name = "ProductNameInput";
            ProductNameInput.Size = new Size(129, 23);
            ProductNameInput.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(148, 14);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 3;
            label3.Text = "السعر";
            // 
            // ProductPriceInput
            // 
            ProductPriceInput.BorderStyle = BorderStyle.FixedSingle;
            ProductPriceInput.DecimalPlaces = 2;
            ProductPriceInput.Location = new Point(106, 42);
            ProductPriceInput.Name = "ProductPriceInput";
            ProductPriceInput.Size = new Size(78, 23);
            ProductPriceInput.TabIndex = 4;
            ProductPriceInput.TextAlign = HorizontalAlignment.Right;
            ProductPriceInput.UpDownAlign = LeftRightAlignment.Left;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(43, 14);
            label4.Name = "label4";
            label4.Size = new Size(46, 15);
            label4.TabIndex = 5;
            label4.Text = "المخزون";
            // 
            // ProductStockInput
            // 
            ProductStockInput.Location = new Point(12, 42);
            ProductStockInput.Name = "ProductStockInput";
            ProductStockInput.Size = new Size(77, 23);
            ProductStockInput.TabIndex = 6;
            ProductStockInput.TextAlign = HorizontalAlignment.Right;
            ProductStockInput.UpDownAlign = LeftRightAlignment.Left;
            // 
            // AddItemBtn
            // 
            AddItemBtn.Location = new Point(12, 81);
            AddItemBtn.Name = "AddItemBtn";
            AddItemBtn.Size = new Size(320, 29);
            AddItemBtn.TabIndex = 7;
            AddItemBtn.Text = "اضافة";
            AddItemBtn.UseVisualStyleBackColor = true;
            AddItemBtn.Click += AddItemBtn_Click;
            // 
            // ProductsGrid
            // 
            ProductsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ProductsGrid.Columns.AddRange(new DataGridViewColumn[] { UpdateItemBtn });
            ProductsGrid.Dock = DockStyle.Bottom;
            ProductsGrid.Location = new Point(0, 150);
            ProductsGrid.Name = "ProductsGrid";
            ProductsGrid.RightToLeft = RightToLeft.Yes;
            ProductsGrid.Size = new Size(568, 237);
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
            // Cafetria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(568, 387);
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
    }
}