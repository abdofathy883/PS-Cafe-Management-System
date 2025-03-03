namespace PlayStation.Presentation
{
    partial class UpdateItem
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
            NewPriceInput = new NumericUpDown();
            label3 = new Label();
            NewStockInput = new NumericUpDown();
            UpdateProductBtn = new Button();
            NewNameInput = new TextBox();
            ((System.ComponentModel.ISupportInitialize)NewPriceInput).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NewStockInput).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(150, 29);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 2;
            label2.Text = "السعر";
            // 
            // NewPriceInput
            // 
            NewPriceInput.Location = new Point(127, 56);
            NewPriceInput.Name = "NewPriceInput";
            NewPriceInput.Size = new Size(59, 23);
            NewPriceInput.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(58, 24);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 4;
            label3.Text = "المخزون";
            // 
            // NewStockInput
            // 
            NewStockInput.Location = new Point(46, 56);
            NewStockInput.Name = "NewStockInput";
            NewStockInput.Size = new Size(58, 23);
            NewStockInput.TabIndex = 5;
            // 
            // UpdateProductBtn
            // 
            UpdateProductBtn.Location = new Point(46, 99);
            UpdateProductBtn.Name = "UpdateProductBtn";
            UpdateProductBtn.Size = new Size(140, 29);
            UpdateProductBtn.TabIndex = 6;
            UpdateProductBtn.Text = "تحديث";
            UpdateProductBtn.UseVisualStyleBackColor = true;
            UpdateProductBtn.Click += UpdateProductBtn_Click;
            // 
            // NewNameInput
            // 
            NewNameInput.Location = new Point(212, 56);
            NewNameInput.Name = "NewNameInput";
            NewNameInput.Size = new Size(100, 23);
            NewNameInput.TabIndex = 7;
            // 
            // UpdateItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(417, 244);
            Controls.Add(NewNameInput);
            Controls.Add(UpdateProductBtn);
            Controls.Add(NewStockInput);
            Controls.Add(label3);
            Controls.Add(NewPriceInput);
            Controls.Add(label2);
            Name = "UpdateItem";
            Text = "UpdateItem";
            ((System.ComponentModel.ISupportInitialize)NewPriceInput).EndInit();
            ((System.ComponentModel.ISupportInitialize)NewStockInput).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private NumericUpDown NewPriceInput;
        private Label label3;
        private NumericUpDown NewStockInput;
        private Button UpdateProductBtn;
        private TextBox NewNameInput;
    }
}