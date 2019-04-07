using Help_Desk.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Help_Desk.Repository
{
    public class AccountRepository
    {
        EmployeeContext employeeContext = new EmployeeContext();
        public bool SaveUserDetails(UserDetails userdetails)
        {
            try
            {
                employeeContext.Configuration.ValidateOnSaveEnabled = false;
                employeeContext.Users.Add(userdetails);
                employeeContext.SaveChanges();
               return true;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                throw ex;
            }          
        }
    }
}