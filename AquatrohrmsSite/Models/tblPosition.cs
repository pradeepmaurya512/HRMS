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
    
    public partial class tblPosition
    {
        public tblPosition()
        {
            this.tblRecruitments = new HashSet<tblRecruitment>();
            this.tblVacancises = new HashSet<tblVacancise>();
        }
    
        public int intPositionId { get; set; }
        public string varPositionName { get; set; }
        public string varPositionDescription { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<System.DateTime> varStatus { get; set; }
        public Nullable<System.DateTime> dtCreatedOn { get; set; }
        public Nullable<System.DateTime> dtUpdatedOn { get; set; }
        public Nullable<int> intCreatedby { get; set; }
        public Nullable<int> intUpdatedby { get; set; }
    
        public virtual ICollection<tblRecruitment> tblRecruitments { get; set; }
        public virtual ICollection<tblVacancise> tblVacancises { get; set; }
    }
}