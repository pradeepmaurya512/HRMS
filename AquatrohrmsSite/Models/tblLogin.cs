//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AquatrohrmsSite.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;

    using System.ComponentModel.DataAnnotations.Schema;
    using System.ComponentModel.DataAnnotations;
    using System.Configuration;
    using System.Data.SqlClient;
    using System.Web.Mvc;
    
    public partial class tblLogin
    {
        public int intLoginId { get; set; }

        public string varUserName { get; set; }

        //[DataType(DataType.Password)]
        //[DisplayName(" Password")]
        public string varPassword { get; set; }

        [DataType(DataType.Password)]
        //[System.ComponentModel.DataAnnotations.Compare("varPassword", ErrorMessage = "Passwords must match")]
        //[Required(ErrorMessage = "Confirm password is required")]
        //[DisplayName("Confirm Password")]
        public string varConfirmPassword { get; set; }

        [NotMapped]
        public SelectList intDesignationId { get; set; }
        [NotMapped]
        public SelectList intDepartmentID { get; set; }       

        public Nullable<bool> IsActive { get; set; }
        public Nullable<int> intEmployeeID { get; set; }
        public Nullable<int> IsChkLoginCount { get; set; }

         //[DisplayName("Email ID")]

         //[Remote("CheckForDuplication", "Login", ErrorMessage = "This {0} is already used.")]
        public string varLoginName { get; set; }


        public Nullable<System.DateTime> dtCreatedOn { get; set; }
        public Nullable<System.DateTime> dtUpdatedOn { get; set; }
        public Nullable<int> intCreatedBy { get; set; }
        public Nullable<int> intUpdatedBy { get; set; }
    
        public virtual tblEmployee tblEmployee { get; set; }
        public IList<SelectListItem> Access { get; set; }
    }
        public SelectList DesignationModel { get; set; }
        public SelectList EmployeeModel { get; set; }
        public SelectList AccessList { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Current password")]
        public string OldPassword { get; set; }
        [DataType(DataType.Password)]
        [DisplayName("New Password")]
        public string varPassword { get; set; }

        [DataType(DataType.Password)]
        [System.ComponentModel.DataAnnotations.Compare("varPassword", ErrorMessage = "Passwords must match")]
        [Required(ErrorMessage = "Confirm password is required")]
        [DisplayName("Confirm Password")]
        public string varConfirmPassword { get; set; }
    }

    public class ForgotPassword
    {
        [Display(Name = "User Name")]
        public string varUserName { get; set; }
        [Display(Name="Email Id")]
        public string varLoginName { get; set; }
    }
}
