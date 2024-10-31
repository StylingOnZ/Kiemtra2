namespace kiemtra2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridViewProducts = new DataGridView();
            ProductImageColumn = new DataGridViewTextBoxColumn();
            ProductNameColumn = new DataGridViewTextBoxColumn();
            ProductPriceColumn = new DataGridViewTextBoxColumn();
            ProductQuantityColumn = new DataGridViewTextBoxColumn();
            button1 = new Button();
            dataGridViewCart = new DataGridView();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            button2 = new Button();
            labelTotalQuantity = new Label();
            labelTotalPrice = new Label();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCart).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewProducts
            // 
            dataGridViewProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProducts.Columns.AddRange(new DataGridViewColumn[] { ProductImageColumn, ProductNameColumn, ProductPriceColumn, ProductQuantityColumn });
            dataGridViewProducts.Location = new Point(161, 3);
            dataGridViewProducts.Name = "dataGridViewProducts";
            dataGridViewProducts.Size = new Size(444, 126);
            dataGridViewProducts.TabIndex = 0;
            dataGridViewProducts.CellContentClick += dataGridView1_CellContentClick;
            // 
            // ProductImageColumn
            // 
            ProductImageColumn.HeaderText = "Ảnh_SP";
            ProductImageColumn.Name = "ProductImageColumn";
            // 
            // ProductNameColumn
            // 
            ProductNameColumn.HeaderText = "Tên_SP";
            ProductNameColumn.Name = "ProductNameColumn";
            // 
            // ProductPriceColumn
            // 
            ProductPriceColumn.HeaderText = "Giá";
            ProductPriceColumn.Name = "ProductPriceColumn";
            // 
            // ProductQuantityColumn
            // 
            ProductQuantityColumn.HeaderText = "Số lượng";
            ProductQuantityColumn.Name = "ProductQuantityColumn";
            // 
            // button1
            // 
            button1.Location = new Point(161, 135);
            button1.Name = "button1";
            button1.Size = new Size(149, 34);
            button1.TabIndex = 1;
            button1.Text = "Thêm vào giỏ hàng";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridViewCart
            // 
            dataGridViewCart.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCart.Columns.AddRange(new DataGridViewColumn[] { Column3, Column4, Column5, Column6 });
            dataGridViewCart.Location = new Point(161, 175);
            dataGridViewCart.Name = "dataGridViewCart";
            dataGridViewCart.Size = new Size(443, 126);
            dataGridViewCart.TabIndex = 2;
            dataGridViewCart.CellContentClick += dataGridView2_CellContentClick;
            // 
            // Column3
            // 
            Column3.HeaderText = "Tên";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Số lượng";
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "Giá";
            Column5.Name = "Column5";
            // 
            // Column6
            // 
            Column6.HeaderText = "Tổng giá";
            Column6.Name = "Column6";
            // 
            // button2
            // 
            button2.Location = new Point(161, 307);
            button2.Name = "button2";
            button2.Size = new Size(169, 34);
            button2.TabIndex = 3;
            button2.Text = "Xóa khỏi giỏ hàng";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // labelTotalQuantity
            // 
            labelTotalQuantity.AutoSize = true;
            labelTotalQuantity.Location = new Point(161, 358);
            labelTotalQuantity.Name = "labelTotalQuantity";
            labelTotalQuantity.Size = new Size(83, 15);
            labelTotalQuantity.TabIndex = 4;
            labelTotalQuantity.Text = "Tổng số lượng";
            labelTotalQuantity.Click += label1_Click;
            // 
            // labelTotalPrice
            // 
            labelTotalPrice.AutoSize = true;
            labelTotalPrice.Location = new Point(429, 358);
            labelTotalPrice.Name = "labelTotalPrice";
            labelTotalPrice.Size = new Size(67, 15);
            labelTotalPrice.TabIndex = 5;
            labelTotalPrice.Text = "Tổng giá trị";
            labelTotalPrice.Click += labelTotalPrice_Click;
            // 
            // button3
            // 
            button3.Location = new Point(161, 395);
            button3.Name = "button3";
            button3.Size = new Size(91, 31);
            button3.TabIndex = 6;
            button3.Text = "Thanh toán";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(labelTotalPrice);
            Controls.Add(labelTotalQuantity);
            Controls.Add(button2);
            Controls.Add(dataGridViewCart);
            Controls.Add(button1);
            Controls.Add(dataGridViewProducts);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCart).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewProducts;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn TênSP;
        private DataGridViewTextBoxColumn Giá;
        private DataGridViewTextBoxColumn Column2;
        private Button button1;
        private DataGridView dataGridViewCart;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private Button button2;
        private Label labelTotalQuantity;
        private Label labelTotalPrice;
        private Button button3;
        private DataGridViewTextBoxColumn ProductImageColumn;
        private DataGridViewTextBoxColumn ProductNameColumn;
        private DataGridViewTextBoxColumn ProductPriceColumn;
        private DataGridViewTextBoxColumn ProductQuantityColumn;
    }
}
