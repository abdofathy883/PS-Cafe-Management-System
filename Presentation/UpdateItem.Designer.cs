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
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)NewPriceInput).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NewStockInput).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(106, 41);
            label2.Name = "label2";
            label2.Size = new Size(74, 19);
            label2.TabIndex = 2;
            label2.Text = "السعر الجديد";
            // 
            // NewPriceInput
            // 
            NewPriceInput.Location = new Point(50, 68);
            NewPriceInput.Name = "NewPriceInput";
            NewPriceInput.Size = new Size(130, 23);
            NewPriceInput.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(224, 108);
            label3.Name = "label3";
            label3.Size = new Size(89, 19);
            label3.TabIndex = 4;
            label3.Text = "المخزون الجديد";
            // 
            // NewStockInput
            // 
            NewStockInput.Location = new Point(186, 142);
            NewStockInput.Name = "NewStockInput";
            NewStockInput.Size = new Size(127, 23);
            NewStockInput.TabIndex = 5;
            // 
            // UpdateProductBtn
            // 
            UpdateProductBtn.BackColor = Color.FromArgb(32, 87, 129);
            UpdateProductBtn.FlatAppearance.BorderSize = 0;
            UpdateProductBtn.FlatStyle = FlatStyle.Flat;
            UpdateProductBtn.Font = new Font("Arial", 12F, FontStyle.Bold);
            UpdateProductBtn.ForeColor = Color.White;
            UpdateProductBtn.Location = new Point(50, 139);
            UpdateProductBtn.Name = "UpdateProductBtn";
            UpdateProductBtn.Size = new Size(130, 29);
            UpdateProductBtn.TabIndex = 6;
            UpdateProductBtn.Text = "تحديث";
            UpdateProductBtn.UseVisualStyleBackColor = false;
            UpdateProductBtn.Click += UpdateProductBtn_Click;
            // 
            // NewNameInput
            // 
            NewNameInput.Location = new Point(186, 68);
            NewNameInput.Name = "NewNameInput";
            NewNameInput.Size = new Size(127, 23);
            NewNameInput.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(242, 41);
            label1.Name = "label1";
            label1.Size = new Size(71, 19);
            label1.TabIndex = 8;
            label1.Text = "الاسم الجديد";
            // 
            // UpdateItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(382, 226);
            Controls.Add(label1);
            Controls.Add(NewNameInput);
            Controls.Add(UpdateProductBtn);
            Controls.Add(NewStockInput);
            Controls.Add(label3);
            Controls.Add(NewPriceInput);
            Controls.Add(label2);
            MaximizeBox = false;
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
        private Label label1;
    }
}