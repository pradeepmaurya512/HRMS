using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AquatrohrmsSite.Models
{
    public class ChangePassword
    {

        [DataType(DataType.Password)]
        [DisplayName(" Old Password")]
        public string varPassword { get; set; }

        [DataType(DataType.Password)]
        [DisplayName(" New Password")]
        public string varNewPassword { get; set; }

        [DataType(DataType.Password)]
        [Compare("varPassword", ErrorMessage = "Passwords must match")]
        [Required(ErrorMessage = "Confirm password is required")]
        [DisplayName("Confirm Password")]
        public string varConfirmPassword { get; set; }

        [DisplayName("Email ID")]
        public string varLoginName { get; set; }
        public Nullable<System.DateTime> dtCreatedOn { get; set; }
        public Nullable<System.DateTime> dtUpdatedOn { get; set; }
        public Nullable<int> intCreatedBy { get; set; }
        public Nullable<int> intUpdatedBy { get; set; }



    }
}   