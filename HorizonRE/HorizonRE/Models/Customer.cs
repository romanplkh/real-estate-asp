﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HorizonRE.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }

        [Required(ErrorMessage = "First Name is required")]
        [Display(Name = "First Name")]
        [StringLength(20, MinimumLength = 3)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name is required")]
        [Display(Name = "Last Name")]
        [StringLength(30, MinimumLength = 3)]
        public string LastName { get; set; }

        [Display(Name = "Middle Name")]
        [StringLength(20)]
        public string MiddleName { get; set; }


        [Required(ErrorMessage = "Street address is required")]
        [Display(Name = "Street address")]
        [StringLength(100, MinimumLength = 3)]
        public string StreetAddress { get; set; }

        [StringLength(50, MinimumLength = 3)]
        [Required(ErrorMessage = "City is required")]
        public string City { get; set; }

        [Required(ErrorMessage = "Postal code is required")]
        [Display(Name = "Postal Code")]
        [StringLength(6, MinimumLength = 6)]
        [CustomAttribute.PostalCodeIsValid]

        public string PostalCode { get; set; }


        [StringLength(14)]
        [RegularExpression(@"^[(]\d{3}[)][\s]\d{3}[-]\d{4}$",
            ErrorMessage = "Phone has a wrong format.Format should be (XXX) XXX-XXXX")]
        public string Phone { get; set; }

        [StringLength(50, MinimumLength = 3)]
        [EmailAddress]
        public string Email { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:d}",
          ApplyFormatInEditMode = true)]
        [CustomAttribute.AgeIsValid]
        public DateTime DOB { get; set; }


        //foreign keys
        public virtual Province Province { get; set; }
        public virtual Country Country { get; set; }
    }
}