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
    
    public partial class tblWorkExperience
    {
        public int intWorkExpID { get; set; }
        public Nullable<int> intEmployeeID { get; set; }
        public string varCompanyName { get; set; }
        public string varDesignation { get; set; }
        public string varJobProfile { get; set; }
        public Nullable<System.DateTime> dtFromDate { get; set; }
        public Nullable<System.DateTime> dtEndDate { get; set; }
        public Nullable<int> intCreatedBy { get; set; }
        public Nullable<System.DateTime> dtCreatedOn { get; set; }
        public Nullable<int> intUpdatedBy { get; set; }
        public Nullable<System.DateTime> dtUpdatedOn { get; set; }
    
        public virtual tblEmployee tblEmployee { get; set; }
    }
}
