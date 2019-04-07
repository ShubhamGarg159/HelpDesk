
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Help_Desk.Models
{
    public class EmployeeContext:DbContext
    {
        public DbSet<UserDetails> Users { get; set; }
    }
}