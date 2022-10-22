using Northwind.WebFormsUI.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations.Model;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.WebFormsUI.DataAccess.Abstract
{
  public interface IProductDal:IEntityRepository<Product>
  {
   

  }
}
