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
    
    public partial class tblLeaveType
    {
        public tblLeaveType()
        {
            this.tblUserLeaveManagements = new HashSet<tblUserLeaveManagement>();
        }
    
        public int intLeaveTypeID { get; set; }
        public string varLeaveTypeName { get; set; }
        public Nullable<System.DateTime> dtCreatedOn { get; set; }
        public Nullable<System.DateTime> dtUpdatedOn { get; set; }
        public Nullable<int> intCreatedby { get; set; }
        public Nullable<int> intUpdatedby { get; set; }
    
        public virtual ICollection<tblUserLeaveManagement> tblUserLeaveManagements { get; set; }
    }
}
