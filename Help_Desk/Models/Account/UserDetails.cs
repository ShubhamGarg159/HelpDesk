using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Help_Desk.Models.Account
{
    [Table("tb_userdetail")]
    public class UserDetails
    {
        public int ID
        {
            get;
            set;
        }
        [Required(ErrorMessage = ("Enter EmployeeID"))]
        public string EmployeeID
        {
            get;
            set;
        }
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
       // [RegularExpression(@"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", ErrorMessage = ("Invalid EmailID"))]
        [Remote("IsAlreadySigned", "User", HttpMethod = "POST", ErrorMessage = "EmailId already exists in database.")]
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
        [System.ComponentModel.DataAnnotations.Compare("Password", ErrorMessage = ("Password Does Not Match"))]
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
        public string DistrictID
        {
            get;
            set;
        }
        [HiddenInput]
        public string UserRole
        {
            get;set;
        }
    }
}