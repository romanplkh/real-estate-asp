using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Configuration;
using System.Linq;
using System.Web;



namespace Horizon.Models
{
   public class Employee
   {
      public int EmployeeId { get; set; }

      [Required(ErrorMessage = "First Name is required")]
      [Display(Name = "First Name" )]
      [StringLength(20, MinimumLength = 3)]
      public string FirstName { get; set; }

      [Required(ErrorMessage = "Last Name is required")]
      [Display(Name = "Last Name" )]
      [StringLength(30, MinimumLength = 3)]
      public string  LastName { get; set; }


      [Display(Name = "Middle Name" )]
      [StringLength(20)]
      public string  MiddleName { get; set; }

      [Required(ErrorMessage = "SIN is required")]
      [Display(Name = "SIN" )]
      [StringLength(11, MinimumLength = 11)]
      [RegularExpression(@"^\d{3}-\d{3}-\d{3}$", ErrorMessage = "SIN has incorrect format")]
      public string SIN { get; set; }


      [Required(ErrorMessage = "Street address is required")]
      [Display(Name = "Street address" )]
      [StringLength(100, MinimumLength = 3)]
      public string StreetAddress { get; set; }

      [StringLength(50, MinimumLength = 3)]
      [Required(ErrorMessage = "City is required")]
      public string City { get; set; }

      [Required(ErrorMessage = "Postal code is required")]
      [Display(Name = "Postal Code" )]
      [StringLength(6, MinimumLength = 6)]
      [RegularExpression(@"^[ABCEGHJ-NPRSTVXY]\d[ABCEGHJ-NPRSTV-Z]\d[ABCEGHJ-NPRSTV-Z]\d$", ErrorMessage = "Postal code has incorrect format")]
      public string PostalCode { get; set; }


      [StringLength(14)]
      [RegularExpression(@"^[(]\d{3}[)][\s]\d{3}[-]\d{4}$", ErrorMessage = "Phone has a wrong format.Format should be (XXX) XXX-XXXX")]
      public string HomePhone  { get; set; }

      [StringLength(14)]
      [RegularExpression(@"^[(]\d{3}[)][\s]\d{3}[-]\d{4}$", ErrorMessage = "Phone has a wrong format.Format should be (XXX) XXX-XXXX")]
      public string CellPhone { get; set; }
      
      [StringLength(14)]
      [RegularExpression(@"^[(]\d{3}[)][\s]\d{3}[-]\d{4}$", ErrorMessage = "Phone has a wrong format.Format should be (XXX) XXX-XXXX")]
      public string OfficePhone { get; set; }

      [StringLength(50, MinimumLength = 3)]
      [EmailAddress]
      public string OfficeEmail { get; set; }

      [DataType(DataType.Date)]
      [CustomAttribute.AgeIsValid]
      public DateTime DOB { get; set; }

   
      [Required]
      [IntegerValidator]
      public int AddedBy { get; set; }

      [DataType(DataType.Date)]
      [CustomAttribute.HireDateIsValid]
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