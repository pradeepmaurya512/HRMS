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
    
    public partial class tblLogin
    {
        public int intLoginId { get; set; }
        public string varUserName { get; set; }
        public string varPassword { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<int> intEmployeeID { get; set; }
        public Nullable<int> IsChkLoginCount { get; set; }
        public string varLoginName { get; set; }
        public Nullable<System.DateTime> dtCreatedOn { get; set; }
        public Nullable<System.DateTime> dtUpdatedOn { get; set; }
        public Nullable<int> intCreatedBy { get; set; }
        public Nullable<int> intUpdatedBy { get; set; }  
        public virtual tblEmployee tblEmployee { get; set; }
    }
}
