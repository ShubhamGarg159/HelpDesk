using Help_Desk.Models.Account;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Help_Desk.Models
{
    public class AppContext:DbContext
    {
        public DbSet<UserDetails> Userinfo { get; set; }
    }
}