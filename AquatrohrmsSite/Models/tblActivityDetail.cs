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
    
    public partial class tblActivityDetail
    {
        public tblActivityDetail()
        {
            this.tblTimeSheets = new HashSet<tblTimeSheet>();
        }
    
        public int intActivityID { get; set; }
        public string varActivityName { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<System.DateTime> dtCreatedOn { get; set; }
        public Nullable<System.DateTime> dtUpdatedOn { get; set; }
        public Nullable<int> intCreatedby { get; set; }
        public Nullable<int> intUpdatedby { get; set; }
    
        public virtual ICollection<tblTimeSheet> tblTimeSheets { get; set; }
    }
}
