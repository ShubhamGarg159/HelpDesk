using Help_Desk.Models;
using Help_Desk.Models.Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Help_Desk.Repository
{
    public class AccountRepository
    {
        AppContext DBContext = new AppContext();
        public bool SaveUserDetails(UserDetails userdetails)
        {
            try
            {
                DBContext.Userinfo.Add(userdetails);
                DBContext.SaveChanges();
                return (true);
            }
            catch(Exception ex)
            {
                throw ex;
            }          
        }
    }
}