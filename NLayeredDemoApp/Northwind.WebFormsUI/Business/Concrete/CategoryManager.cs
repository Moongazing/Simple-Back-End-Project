using Northwind.WebFormsUI.Business.Abstract;
using Northwind.WebFormsUI.DataAccess.Abstract;
using Northwind.WebFormsUI.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.WebFormsUI.Business.Concrete
{
  public class CategoryManager : ICategoryService
  {
    ICategoryDal _categoryDal;

    public CategoryManager(ICategoryDal categoryDal)
    {
      _categoryDal = categoryDal;
    }

    public List<Category> GetAll()
    {
      return _categoryDal.GetAll();
    }
  }
}
