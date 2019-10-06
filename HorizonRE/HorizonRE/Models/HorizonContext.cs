﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace HorizonRE.Models
{
   public class HorizonContext: DbContext
   {
      public DbSet<Employee> Employees { get; set; }
      public DbSet<Country> Countries { get; set; }
      public DbSet<Province> Provinces { get; set; }
   }
}