namespace Northwind.WebFormsUI
{
  partial class MainForm
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
      this.dgwProducts = new System.Windows.Forms.DataGridView();
      this.grbSearchByCategory = new System.Windows.Forms.GroupBox();
      this.cmbxCategory = new System.Windows.Forms.ComboBox();
      this.lblCategory = new System.Windows.Forms.Label();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.txtProductName = new System.Windows.Forms.TextBox();
      this.lblProductName = new System.Windows.Forms.Label();
      this.grbAddNew = new System.Windows.Forms.GroupBox();
      this.btnAddProduct = new System.Windows.Forms.Button();
      this.txtQuantityPerUnit = new System.Windows.Forms.TextBox();
      this.txtUnitsInStock = new System.Windows.Forms.TextBox();
      this.txtUnitPrice = new System.Windows.Forms.TextBox();
      this.cmbxCategories = new System.Windows.Forms.ComboBox();
      this.lblQuantityPerUnit = new System.Windows.Forms.Label();
      this.lblUnitsInStock = new System.Windows.Forms.Label();
      this.lblUnitPrice = new System.Windows.Forms.Label();
      this.lblCategoryId = new System.Windows.Forms.Label();
      this.txtProduct_Name = new System.Windows.Forms.TextBox();
      this.lblProductNameAdd = new System.Windows.Forms.Label();
      this.grbUpdate = new System.Windows.Forms.GroupBox();
      this.btnUpdate = new System.Windows.Forms.Button();
      this.txtUpdateQuantityPerUnit = new System.Windows.Forms.TextBox();
      this.txtUpdateUnitsInStock = new System.Windows.Forms.TextBox();
      this.txtUpdateUnitPrice = new System.Windows.Forms.TextBox();
      this.cmbxUpdateCategory = new System.Windows.Forms.ComboBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.txtUpdateProductName = new System.Windows.Forms.TextBox();
      this.label5 = new System.Windows.Forms.Label();
      this.btnRemove = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.dgwProducts)).BeginInit();
      this.grbSearchByCategory.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.grbAddNew.SuspendLayout();
      this.grbUpdate.SuspendLayout();
      this.SuspendLayout();
      // 
      // dgwProducts
      // 
      this.dgwProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgwProducts.Location = new System.Drawing.Point(9, 235);
      this.dgwProducts.Name = "dgwProducts";
      this.dgwProducts.RowHeadersWidth = 51;
      this.dgwProducts.Size = new System.Drawing.Size(650, 195);
      this.dgwProducts.TabIndex = 0;
      this.dgwProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwProducts_CellClick);
      // 
      // grbSearchByCategory
      // 
      this.grbSearchByCategory.Controls.Add(this.cmbxCategory);
      this.grbSearchByCategory.Controls.Add(this.lblCategory);
      this.grbSearchByCategory.Location = new System.Drawing.Point(12, 12);
      this.grbSearchByCategory.Name = "grbSearchByCategory";
      this.grbSearchByCategory.Size = new System.Drawing.Size(647, 100);
      this.grbSearchByCategory.TabIndex = 1;
      this.grbSearchByCategory.TabStop = false;
      this.grbSearchByCategory.Text = "Search By Category";
      // 
      // cmbxCategory
      // 
      this.cmbxCategory.FormattingEnabled = true;
      this.cmbxCategory.Location = new System.Drawing.Point(97, 39);
      this.cmbxCategory.Name = "cmbxCategory";
      this.cmbxCategory.Size = new System.Drawing.Size(206, 21);
      this.cmbxCategory.TabIndex = 4;
      this.cmbxCategory.SelectedIndexChanged += new System.EventHandler(this.cmbxCategory_SelectedIndexChanged);
      // 
      // lblCategory
      // 
      this.lblCategory.AutoSize = true;
      this.lblCategory.Location = new System.Drawing.Point(16, 42);
      this.lblCategory.Name = "lblCategory";
      this.lblCategory.Size = new System.Drawing.Size(49, 13);
      this.lblCategory.TabIndex = 3;
      this.lblCategory.Text = "Category";
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.txtProductName);
      this.groupBox2.Controls.Add(this.lblProductName);
      this.groupBox2.Location = new System.Drawing.Point(12, 128);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(647, 100);
      this.groupBox2.TabIndex = 2;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Search By Product Name";
      // 
      // txtProductName
      // 
      this.txtProductName.Location = new System.Drawing.Point(97, 42);
      this.txtProductName.Name = "txtProductName";
      this.txtProductName.Size = new System.Drawing.Size(206, 20);
      this.txtProductName.TabIndex = 6;
      this.txtProductName.TextChanged += new System.EventHandler(this.txtProductName_TextChanged);
      // 
      // lblProductName
      // 
      this.lblProductName.AutoSize = true;
      this.lblProductName.Location = new System.Drawing.Point(16, 45);
      this.lblProductName.Name = "lblProductName";
      this.lblProductName.Size = new System.Drawing.Size(75, 13);
      this.lblProductName.TabIndex = 5;
      this.lblProductName.Text = "Product Name";
      // 
      // grbAddNew
      // 
      this.grbAddNew.Controls.Add(this.btnAddProduct);
      this.grbAddNew.Controls.Add(this.txtQuantityPerUnit);
      this.grbAddNew.Controls.Add(this.txtUnitsInStock);
      this.grbAddNew.Controls.Add(this.txtUnitPrice);
      this.grbAddNew.Controls.Add(this.cmbxCategories);
      this.grbAddNew.Controls.Add(this.lblQuantityPerUnit);
      this.grbAddNew.Controls.Add(this.lblUnitsInStock);
      this.grbAddNew.Controls.Add(this.lblUnitPrice);
      this.grbAddNew.Controls.Add(this.lblCategoryId);
      this.grbAddNew.Controls.Add(this.txtProduct_Name);
      this.grbAddNew.Controls.Add(this.lblProductNameAdd);
      this.grbAddNew.Location = new System.Drawing.Point(9, 494);
      this.grbAddNew.Name = "grbAddNew";
      this.grbAddNew.Size = new System.Drawing.Size(326, 281);
      this.grbAddNew.TabIndex = 7;
      this.grbAddNew.TabStop = false;
      this.grbAddNew.Text = "Add New";
      // 
      // btnAddProduct
      // 
      this.btnAddProduct.Location = new System.Drawing.Point(108, 245);
      this.btnAddProduct.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.btnAddProduct.Name = "btnAddProduct";
      this.btnAddProduct.Size = new System.Drawing.Size(185, 21);
      this.btnAddProduct.TabIndex = 8;
      this.btnAddProduct.Text = "Add";
      this.btnAddProduct.UseVisualStyleBackColor = true;
      this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
      // 
      // txtQuantityPerUnit
      // 
      this.txtQuantityPerUnit.Location = new System.Drawing.Point(108, 206);
      this.txtQuantityPerUnit.Name = "txtQuantityPerUnit";
      this.txtQuantityPerUnit.Size = new System.Drawing.Size(186, 20);
      this.txtQuantityPerUnit.TabIndex = 14;
      // 
      // txtUnitsInStock
      // 
      this.txtUnitsInStock.Location = new System.Drawing.Point(108, 160);
      this.txtUnitsInStock.Name = "txtUnitsInStock";
      this.txtUnitsInStock.Size = new System.Drawing.Size(186, 20);
      this.txtUnitsInStock.TabIndex = 13;
      // 
      // txtUnitPrice
      // 
      this.txtUnitPrice.Location = new System.Drawing.Point(108, 119);
      this.txtUnitPrice.Name = "txtUnitPrice";
      this.txtUnitPrice.Size = new System.Drawing.Size(186, 20);
      this.txtUnitPrice.TabIndex = 12;
      // 
      // cmbxCategories
      // 
      this.cmbxCategories.FormattingEnabled = true;
      this.cmbxCategories.Location = new System.Drawing.Point(109, 76);
      this.cmbxCategories.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.cmbxCategories.Name = "cmbxCategories";
      this.cmbxCategories.Size = new System.Drawing.Size(186, 21);
      this.cmbxCategories.TabIndex = 11;
      // 
      // lblQuantityPerUnit
      // 
      this.lblQuantityPerUnit.AutoSize = true;
      this.lblQuantityPerUnit.Location = new System.Drawing.Point(14, 211);
      this.lblQuantityPerUnit.Name = "lblQuantityPerUnit";
      this.lblQuantityPerUnit.Size = new System.Drawing.Size(87, 13);
      this.lblQuantityPerUnit.TabIndex = 10;
      this.lblQuantityPerUnit.Text = "Quantity Per Unit";
      // 
      // lblUnitsInStock
      // 
      this.lblUnitsInStock.AutoSize = true;
      this.lblUnitsInStock.Location = new System.Drawing.Point(14, 165);
      this.lblUnitsInStock.Name = "lblUnitsInStock";
      this.lblUnitsInStock.Size = new System.Drawing.Size(74, 13);
      this.lblUnitsInStock.TabIndex = 9;
      this.lblUnitsInStock.Text = "Units In Stock";
      // 
      // lblUnitPrice
      // 
      this.lblUnitPrice.AutoSize = true;
      this.lblUnitPrice.Location = new System.Drawing.Point(14, 121);
      this.lblUnitPrice.Name = "lblUnitPrice";
      this.lblUnitPrice.Size = new System.Drawing.Size(53, 13);
      this.lblUnitPrice.TabIndex = 8;
      this.lblUnitPrice.Text = "Unit Price";
      // 
      // lblCategoryId
      // 
      this.lblCategoryId.AutoSize = true;
      this.lblCategoryId.Location = new System.Drawing.Point(14, 78);
      this.lblCategoryId.Name = "lblCategoryId";
      this.lblCategoryId.Size = new System.Drawing.Size(49, 13);
      this.lblCategoryId.TabIndex = 7;
      this.lblCategoryId.Text = "Category";
      // 
      // txtProduct_Name
      // 
      this.txtProduct_Name.Location = new System.Drawing.Point(109, 34);
      this.txtProduct_Name.Name = "txtProduct_Name";
      this.txtProduct_Name.Size = new System.Drawing.Size(186, 20);
      this.txtProduct_Name.TabIndex = 6;
      // 
      // lblProductNameAdd
      // 
      this.lblProductNameAdd.AutoSize = true;
      this.lblProductNameAdd.Location = new System.Drawing.Point(14, 34);
      this.lblProductNameAdd.Name = "lblProductNameAdd";
      this.lblProductNameAdd.Size = new System.Drawing.Size(75, 13);
      this.lblProductNameAdd.TabIndex = 5;
      this.lblProductNameAdd.Text = "Product Name";
      // 
      // grbUpdate
      // 
      this.grbUpdate.Controls.Add(this.btnUpdate);
      this.grbUpdate.Controls.Add(this.txtUpdateQuantityPerUnit);
      this.grbUpdate.Controls.Add(this.txtUpdateUnitsInStock);
      this.grbUpdate.Controls.Add(this.txtUpdateUnitPrice);
      this.grbUpdate.Controls.Add(this.cmbxUpdateCategory);
      this.grbUpdate.Controls.Add(this.label1);
      this.grbUpdate.Controls.Add(this.label2);
      this.grbUpdate.Controls.Add(this.label3);
      this.grbUpdate.Controls.Add(this.label4);
      this.grbUpdate.Controls.Add(this.txtUpdateProductName);
      this.grbUpdate.Controls.Add(this.label5);
      this.grbUpdate.Location = new System.Drawing.Point(341, 494);
      this.grbUpdate.Name = "grbUpdate";
      this.grbUpdate.Size = new System.Drawing.Size(326, 281);
      this.grbUpdate.TabIndex = 15;
      this.grbUpdate.TabStop = false;
      this.grbUpdate.Text = "Update Product";
      // 
      // btnUpdate
      // 
      this.btnUpdate.Location = new System.Drawing.Point(108, 245);
      this.btnUpdate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.btnUpdate.Name = "btnUpdate";
      this.btnUpdate.Size = new System.Drawing.Size(185, 21);
      this.btnUpdate.TabIndex = 8;
      this.btnUpdate.Text = "Update";
      this.btnUpdate.UseVisualStyleBackColor = true;
      this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
      // 
      // txtUpdateQuantityPerUnit
      // 
      this.txtUpdateQuantityPerUnit.Location = new System.Drawing.Point(108, 206);
      this.txtUpdateQuantityPerUnit.Name = "txtUpdateQuantityPerUnit";
      this.txtUpdateQuantityPerUnit.Size = new System.Drawing.Size(186, 20);
      this.txtUpdateQuantityPerUnit.TabIndex = 14;
      // 
      // txtUpdateUnitsInStock
      // 
      this.txtUpdateUnitsInStock.Location = new System.Drawing.Point(108, 160);
      this.txtUpdateUnitsInStock.Name = "txtUpdateUnitsInStock";
      this.txtUpdateUnitsInStock.Size = new System.Drawing.Size(186, 20);
      this.txtUpdateUnitsInStock.TabIndex = 13;
      // 
      // txtUpdateUnitPrice
      // 
      this.txtUpdateUnitPrice.Location = new System.Drawing.Point(108, 119);
      this.txtUpdateUnitPrice.Name = "txtUpdateUnitPrice";
      this.txtUpdateUnitPrice.Size = new System.Drawing.Size(186, 20);
      this.txtUpdateUnitPrice.TabIndex = 12;
      // 
      // cmbxUpdateCategory
      // 
      this.cmbxUpdateCategory.FormattingEnabled = true;
      this.cmbxUpdateCategory.Location = new System.Drawing.Point(109, 76);
      this.cmbxUpdateCategory.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.cmbxUpdateCategory.Name = "cmbxUpdateCategory";
      this.cmbxUpdateCategory.Size = new System.Drawing.Size(186, 21);
      this.cmbxUpdateCategory.TabIndex = 11;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(14, 211);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(87, 13);
      this.label1.TabIndex = 10;
      this.label1.Text = "Quantity Per Unit";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(14, 165);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(74, 13);
      this.label2.TabIndex = 9;
      this.label2.Text = "Units In Stock";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(14, 121);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(53, 13);
      this.label3.TabIndex = 8;
      this.label3.Text = "Unit Price";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(14, 78);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(49, 13);
      this.label4.TabIndex = 7;
      this.label4.Text = "Category";
      // 
      // txtUpdateProductName
      // 
      this.txtUpdateProductName.Location = new System.Drawing.Point(109, 34);
      this.txtUpdateProductName.Name = "txtUpdateProductName";
      this.txtUpdateProductName.Size = new System.Drawing.Size(186, 20);
      this.txtUpdateProductName.TabIndex = 6;
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(14, 34);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(75, 13);
      this.label5.TabIndex = 5;
      this.label5.Text = "Product Name";
      // 
      // btnRemove
      // 
      this.btnRemove.Location = new System.Drawing.Point(525, 436);
      this.btnRemove.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.btnRemove.Name = "btnRemove";
      this.btnRemove.Size = new System.Drawing.Size(134, 21);
      this.btnRemove.TabIndex = 15;
      this.btnRemove.Text = "Remove";
      this.btnRemove.UseVisualStyleBackColor = true;
      this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(671, 786);
      this.Controls.Add(this.btnRemove);
      this.Controls.Add(this.grbUpdate);
      this.Controls.Add(this.grbAddNew);
      this.Controls.Add(this.groupBox2);
      this.Controls.Add(this.grbSearchByCategory);
      this.Controls.Add(this.dgwProducts);
      this.Name = "MainForm";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.Form1_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dgwProducts)).EndInit();
      this.grbSearchByCategory.ResumeLayout(false);
      this.grbSearchByCategory.PerformLayout();
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      this.grbAddNew.ResumeLayout(false);
      this.grbAddNew.PerformLayout();
      this.grbUpdate.ResumeLayout(false);
      this.grbUpdate.PerformLayout();
      this.ResumeLayout(false);

    }

        #endregion

        private System.Windows.Forms.DataGridView dgwProducts;
        private System.Windows.Forms.GroupBox grbSearchByCategory;
        private System.Windows.Forms.ComboBox cmbxCategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.GroupBox grbAddNew;
        private System.Windows.Forms.Label lblUnitsInStock;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.Label lblCategoryId;
        private System.Windows.Forms.TextBox txtProduct_Name;
        private System.Windows.Forms.Label lblProductNameAdd;
        private System.Windows.Forms.Label lblQuantityPerUnit;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.TextBox txtQuantityPerUnit;
        private System.Windows.Forms.TextBox txtUnitsInStock;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.ComboBox cmbxCategories;
        private System.Windows.Forms.GroupBox grbUpdate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtUpdateQuantityPerUnit;
        private System.Windows.Forms.TextBox txtUpdateUnitsInStock;
        private System.Windows.Forms.TextBox txtUpdateUnitPrice;
        private System.Windows.Forms.ComboBox cmbxUpdateCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUpdateProductName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnRemove;
    }
}

