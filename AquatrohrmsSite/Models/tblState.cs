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
    
    public partial class tblState
    {
        public tblState()
        {
            this.tblEmployees = new HashSet<tblEmployee>();
            this.tblEmployees1 = new HashSet<tblEmployee>();
        }
    
        public int intStateID { get; set; }
        public string varStateName { get; set; }
        public Nullable<System.DateTime> dtCreatedOn { get; set; }
        public Nullable<System.DateTime> dtUpdatedOn { get; set; }
        public Nullable<int> intCreatedby { get; set; }
        public Nullable<int> intUpdatedby { get; set; }
    
        public virtual ICollection<tblEmployee> tblEmployees { get; set; }
        public virtual ICollection<tblEmployee> tblEmployees1 { get; set; }
    }
}
