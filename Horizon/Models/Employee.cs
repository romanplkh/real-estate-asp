using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;



namespace Horizon.Models
{
   public class Employee
   {
      public int EmployeeId { get; set; }

      [StringLength(20, MinimumLength = 3)]
      public string FirstName { get; set; }

      [StringLength(30, MinimumLength = 3)]
      public string  LastName { get; set; }

      [StringLength(20)]
      public string  MiddleName { get; set; }

      [StringLength(11, MinimumLength = 11)]
      public string SIN { get; set; }

      [StringLength(100, MinimumLength = 3)]
      public string StreetAddress { get; set; }

      [StringLength(50, MinimumLength = 3)]
      public string City { get; set; }

      [StringLength(6, MinimumLength = 6)]
      public string PostalCode { get; set; }

      [StringLength(14)]
      public string HomePhone  { get; set; }

      [StringLength(14)]
      public string CellPhone { get; set; }
      
      [StringLength(14)]
      public string OfficePhone { get; set; }

      [StringLength(50, MinimumLength = 3)]
      public string OfficeEmail { get; set; }

      [DataType(DataType.Date)]
      public DateTime DOB { get; set; }

   
      public  int AddedBy { get; set; }

      [DataType(DataType.Date)]
      public DateTime HireDate { get; set; }


      //FK
      public virtual Province Province { get; set; }
      public virtual Country Country { get; set; }


      //FK AUTH
      // public virtual Authentication Auth { get; set; }
      //FK
     // public int AccessLevelId { get; set; }




   }
}