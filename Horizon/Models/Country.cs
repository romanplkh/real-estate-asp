using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Horizon.Models
{
   public class Country
   {

      public int CountryId { get; set; }
      public string Name { get; set; }

      public  ICollection<Employee> Employees { get; set; }
   }
}