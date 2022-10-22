using FluentValidation;
using Northwind.WebFormsUI.Business.Abstract;
using Northwind.WebFormsUI.Business.Utilities;
using Northwind.WebFormsUI.Business.ValidationRules.FluentValidation;
using Northwind.WebFormsUI.DataAccess.Abstract;
using Northwind.WebFormsUI.DataAccess.Concrete;
using Northwind.WebFormsUI.DataAccess.Concrete.EntityFramework;
using Northwind.WebFormsUI.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.WebFormsUI.Business.Concrete
{
  public class ProductManager : IProductService
  {
    private IProductDal _productDal;

    public ProductManager(IProductDal productDal)
    {
      _productDal = productDal;
    }

    public void Add(Product product)
    {
      ValidationTool.Validate(new ProductValidator(),product);
      _productDal.Add(product);
    }

    public void Delete(Product product)
    {
      try
      {
        _productDal.Delete(product);
      }
      catch (DbUpdateException e)
      {

        throw new Exception("Delete did not happen!");
      }

    }

    public List<Product> GetAll()
    {
      /*Business code here*/
      return _productDal.GetAll();
    }

    public List<Product> GetProductsByCategory(int categoryId)
    {
      return _productDal.GetAll(p => p.CategoryId == categoryId);
    }

    public List<Product> GetProductsByProductName(string productName)
    {
      return _productDal.GetAll(p => p.ProductName.ToLower().Contains(productName.ToLower()));
    }

    public void Update(Product product)
    {
      ValidationTool.Validate(new ProductValidator(), product);
      _productDal.Update(product);
    }
  }
}
