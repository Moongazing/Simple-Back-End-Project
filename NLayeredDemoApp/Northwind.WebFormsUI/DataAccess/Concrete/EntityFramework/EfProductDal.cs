using Northwind.WebFormsUI.DataAccess.Abstract;
using Northwind.WebFormsUI.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.WebFormsUI.DataAccess.Concrete.EntityFramework
{
  public class EfProductDal :EfEntityRepositoryBase<Product,NorthwindContext>, IProductDal
  {
   
  }
}
