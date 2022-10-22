using Northwind.WebFormsUI.Business.Abstract;
using Northwind.WebFormsUI.Business.Concrete;
using Northwind.WebFormsUI.DataAccess.Concrete.EntityFramework;
using Northwind.WebFormsUI.DataAccess.Concrete.NHibernate;
using Northwind.WebFormsUI.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Northwind.WebFormsUI
{
  public partial class MainForm : Form
  {
    public MainForm()
    {
      InitializeComponent();
      _productService = new ProductManager(new EfProductDal());
      _categoryService = new CategoryManager(new EfCategoryDal());
    }

    private IProductService _productService;
    private ICategoryService _categoryService;

    /*Load datagrid with products*/
    private void LoadProducts()
    {
      dgwProducts.DataSource = _productService.GetAll();

    }


    /*Load comboboxes with categories*/
    private void LoadCategories()
    {
      cmbxCategory.DataSource = _categoryService.GetAll();
      cmbxCategory.DisplayMember = "CategoryName";
      cmbxCategory.ValueMember = "CategoryId";

      /*For adding*/
      cmbxCategories.DataSource = _categoryService.GetAll();
      cmbxCategories.DisplayMember = "CategoryName";
      cmbxCategories.ValueMember = "CategoryId";

      /*For updating*/
      cmbxUpdateCategory.DataSource = _categoryService.GetAll();
      cmbxUpdateCategory.DisplayMember = "CategoryName";
      cmbxUpdateCategory.ValueMember = "CategoryId";

    }


    /*We call the load methods on Form1_load*/
    private void Form1_Load(object sender, EventArgs e)
    {
      LoadProducts();
      LoadCategories();
    }


    /*We load datagrid with category*/
    private void cmbxCategory_SelectedIndexChanged(object sender, EventArgs e)
    {
      try
      {
        dgwProducts.DataSource = _productService.GetProductsByCategory(Convert.ToInt32(cmbxCategory.SelectedValue));

      }
      catch
      {

      }

    }



    /*We load datagrid with product name*/
    private void txtProductName_TextChanged(object sender, EventArgs e)
    {
      if (!String.IsNullOrEmpty(txtProductName.Text))
      {
        dgwProducts.DataSource = _productService.GetProductsByProductName(txtProductName.Text);
      }
      else
      {
        LoadProducts();
      }

    }

    /*After operation we need to clear the fields,so we create method */
    private void ClearAddFields()
    {
      foreach (Control item in Controls)
      {

        if (item is TextBox)
        {
          item.Text = string.Empty;
        }
      }
    }

    /*We check fields with validation but this can use to*/
    private bool CheckFields()
    {
      if (String.IsNullOrEmpty(txtProduct_Name.Text) &&
        String.IsNullOrEmpty(cmbxCategories.Text) &&
        String.IsNullOrEmpty(txtQuantityPerUnit.Text) &&
        String.IsNullOrEmpty(txtUnitPrice.Text) &&
        String.IsNullOrEmpty(txtUnitsInStock.Text))
      {
        return true;
      }
      else
      {
        return false;
      }
    }


    /*Adding new product */
    private void btnAddProduct_Click(object sender, EventArgs e)
    {
      try
      {
        _productService.Add(new Product
        {
          CategoryId = Convert.ToInt32(cmbxCategories.SelectedValue),
          ProductName = txtProduct_Name.Text,
          QuantityPerUnit = txtQuantityPerUnit.Text,
          UnitPrice = Convert.ToDecimal(txtUnitPrice.Text),
          UnitsInStock = Convert.ToInt16(txtUnitsInStock.Text)
        });
        MessageBox.Show("Product added!");
        ClearAddFields();
        LoadProducts();
      }
      catch (Exception exception)
      {

        MessageBox.Show(exception.Message);
      }
        
      
    }


    /*Updating product*/
    private void btnUpdate_Click(object sender, EventArgs e)
    {
      _productService.Update(new Product
      {
        ProductId = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].ToString()),
        ProductName = txtUpdateProductName.Text,
        CategoryId = Convert.ToInt32(cmbxUpdateCategory.SelectedValue),
        UnitsInStock = Convert.ToInt16(txtUpdateUnitsInStock.Text),
        UnitPrice = Convert.ToDecimal(txtUpdateUnitPrice.Text),
        QuantityPerUnit = txtUpdateQuantityPerUnit.Text
      });
      MessageBox.Show("Product updated!");
      LoadProducts();
    }


    /*We can select the row in datagrid and we fiil the fields according to that*/
    private void dgwProducts_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      var row = dgwProducts.CurrentRow;
      txtUpdateProductName.Text = row.Cells[1].Value.ToString();
      cmbxUpdateCategory.SelectedValue = row.Cells[2].Value.ToString();
      txtUpdateUnitPrice.Text = row.Cells[3].Value.ToString();
      txtUpdateQuantityPerUnit.Text = row.Cells[4].Value.ToString();
      txtUpdateUnitsInStock.Text = row.Cells[5].Value.ToString();

    }


    /*Deleting product in datagrid we can select on datagrid first*/
    private void btnRemove_Click(object sender, EventArgs e)
    {
      try
      { 
        if (dgwProducts.CurrentRow != null)
        {
          _productService.Delete(new Product
          {
            ProductId = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value)
          });
          MessageBox.Show("Product Deleted!");
          LoadProducts();
        }
      }
      catch (Exception exception)
      {

        MessageBox.Show(exception.Message);
      }
      

    }
  }
}
