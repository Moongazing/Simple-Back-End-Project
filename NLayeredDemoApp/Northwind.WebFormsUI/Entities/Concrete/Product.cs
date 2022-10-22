using Northwind.WebFormsUI.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.WebFormsUI.Entities.Concrete
{
  public class Product:IEntity
  {
    public int ProductId { get; set; }
    public string ProductName { get; set; }
    public int CategoryId { get; set; }
    public decimal UnitPrice { get; set; }
    public string QuantityPerUnit { get; set; }
    public Int16 UnitsInStock { get; set; }
  }
}
