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
    
    public partial class tblPaySlip
    {
        public int intPaySlipId { get; set; }
        public Nullable<int> intEmployeeID { get; set; }
        public Nullable<decimal> varBasic { get; set; }
        public Nullable<decimal> varHRA { get; set; }
        public Nullable<decimal> varConveyance { get; set; }
        public Nullable<decimal> intProfessionalTax { get; set; }
        public Nullable<decimal> intProvidentFund { get; set; }
        public Nullable<System.DateTime> dtCreatedOn { get; set; }
        public Nullable<System.DateTime> dtUpdatedOn { get; set; }
        public Nullable<int> intCreatedby { get; set; }
        public Nullable<int> intUpdatedby { get; set; }
    
        public virtual tblEmployee tblEmployee { get; set; }
    }
}
