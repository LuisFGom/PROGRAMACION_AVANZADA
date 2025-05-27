namespace CapaDePresentacion
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;  // Label para el título
        private System.Windows.Forms.ListBox lstProducts;  // ListBox donde se mostrarán los productos
        private System.Windows.Forms.TextBox txtNewProduct;  // TextBox para ingresar productos
        private System.Windows.Forms.Button btnAddProduct;  // Button para agregar producto

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lstProducts = new System.Windows.Forms.ListBox();
            this.txtNewProduct = new System.Windows.Forms.TextBox();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(67, 49);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(176, 29);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "PRODUCTOS";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lstProducts
            // 
            this.lstProducts.BackColor = System.Drawing.SystemColors.HighlightText;
            this.lstProducts.FormattingEnabled = true;
            this.lstProducts.ItemHeight = 16;
            this.lstProducts.Location = new System.Drawing.Point(12, 100);
            this.lstProducts.Name = "lstProducts";
            this.lstProducts.Size = new System.Drawing.Size(240, 180);
            this.lstProducts.TabIndex = 1;
            // 
            // txtNewProduct
            // 
            this.txtNewProduct.Location = new System.Drawing.Point(12, 300);
            this.txtNewProduct.Name = "txtNewProduct";
            this.txtNewProduct.Size = new System.Drawing.Size(240, 22);
            this.txtNewProduct.TabIndex = 2;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(12, 330);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(240, 30);
            this.btnAddProduct.TabIndex = 3;
            this.btnAddProduct.Text = "Agregar Producto";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(284, 381);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.txtNewProduct);
            this.Controls.Add(this.lstProducts);
            this.Controls.Add(this.lblTitle);
            this.Name = "Form1";
            this.Text = "Gestión de Productos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}


