using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Horizon.Models
{
   public class Province
   {

      public int ProvinceId { get; set; }
      public string Name { get; set; }

      public  ICollection<Employee> Employees { get; set; }
   }
}