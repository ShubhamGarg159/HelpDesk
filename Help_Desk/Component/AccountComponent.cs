using Help_Desk.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PasswordSecurity;
using Help_Desk.Models;

namespace Help_Desk.Component
{
    public class AccountComponent
    {
        AccountRepository objrepository = new AccountRepository();
        public bool SaveUserDetails(UserDetails userDetails)
        {
            userDetails.Password = PasswordStorage.CreateHash(userDetails.Password);
            //userDetails.UserRole = "U";
            return (objrepository.SaveUserDetails(userDetails));
        }
    }
}