using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Help_Desk.Models
{
    public class UserModel
    {
        [Required(ErrorMessage = ("Enter First Name"))]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = ("Enter Only Character"))]
        public string FirstName
        {
            get;
            set;
        }
        [Required(ErrorMessage = ("Enter Last Name"))]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = ("Enter Only Character"))]
        public string LastName
        {
            get;
            set;
        }
        [Required(ErrorMessage = ("Enter Email ID"))]
        [RegularExpression(@"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", ErrorMessage = ("Invalid EmailID"))]
        public string EmailID
        {
            get;
            set;
        }
        [Required(ErrorMessage = ("Enter Mobile Number"))]
        [RegularExpression("([1-9][0-9]*)", ErrorMessage = ("Enter Only Number"))]
        public string Mobile
        {
            get;
            set;
        }
        [Required(ErrorMessage = ("Enter Password"))]
        public string Password
        {
            get;
            set;
        }
        [Required(ErrorMessage = ("Enter Confirm Password"))]
        [Compare("Password", ErrorMessage = ("Password Does Not Match"))]
        public string ConfirmPassword
        {
            get;
            set;
        }
        [Required(ErrorMessage = ("Enter Date Of Birth"))]
        public DateTime DOB
        {
            get;
            set;
        }
        [Required(ErrorMessage = ("Select District"))]
        public string District
        {
            get;
            set;
        }
    }
}