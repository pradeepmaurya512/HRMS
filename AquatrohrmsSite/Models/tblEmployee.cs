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
    
    public partial class tblEmployee
    {
        public tblEmployee()
        {
            this.tblAllowancesManagements = new HashSet<tblAllowancesManagement>();
            this.tblEmployeeGoals = new HashSet<tblEmployeeGoal>();
            this.tblEmployeeQualificationDetails = new HashSet<tblEmployeeQualificationDetail>();
            this.tblEmployee1 = new HashSet<tblEmployee>();
            this.tblLogins = new HashSet<tblLogin>();
            this.tblPaySlips = new HashSet<tblPaySlip>();
            this.tblProjectDetails = new HashSet<tblProjectDetail>();
            this.tblTimeSheets = new HashSet<tblTimeSheet>();
            this.tblTrainings = new HashSet<tblTraining>();
            this.tblUserLeaveManagements = new HashSet<tblUserLeaveManagement>();
            this.tblWorkExperiences = new HashSet<tblWorkExperience>();
        }
    
        public int intEmployeeID { get; set; }

        //[DisplayName("Employee Full Name")]
        public string varFirstName { get; set; }
        public string varLastName { get; set; }
        public string varMiddleName { get; set; }
        public Nullable<int> intEmpRoleID { get; set; }

        public Nullable<int> intDesignationId { get; set; }
        public string varCurrAddressLine1 { get; set; }
        public string varCurrAddressLine2 { get; set; }
        public Nullable<int> intCurrCountryID { get; set; }
        public Nullable<int> intCurrStateID { get; set; }
        public Nullable<int> intCurrCityID { get; set; }
        public string varCurrPostalCode { get; set; }
        public string varPhoneNo { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<int> intLeaveBalance { get; set; }
        public string varGender { get; set; }
        public string charMarritalStatus { get; set; }
        public string varPANNo { get; set; }
        public string varWorkTelNo { get; set; }
        public Nullable<int> intReportingHead { get; set; }
        public string varOfficeEmailAdd { get; set; }
        public string varPersonalEmailAdd { get; set; }
        public string varFatherSpouceName { get; set; }
        public string varMotherName { get; set; }
        public string varEmergencyContactName { get; set; }
        public string varEmergencyContactNumber { get; set; }
        public Nullable<int> intEmergencyContactRelationshipID { get; set; }
   
        public Nullable<int> intDepartmentID { get; set; }
        public string varPermAddressLine1 { get; set; }
        public string varPermAddressLine2 { get; set; }
        public Nullable<int> intPermCountryID { get; set; }
        public Nullable<int> intPermStateID { get; set; }
        public Nullable<int> intPermCityID { get; set; }
        public string varPermPostalCode { get; set; }
        public string varAccessLevel { get; set; }

        public Nullable<System.DateTime> varDOJ { get; set; }   
        public virtual ICollection<tblAllowancesManagement> tblAllowancesManagements { get; set; }
        public virtual tblCity tblCity { get; set; }
        public virtual tblCity tblCity1 { get; set; }
        public virtual tblCountry tblCountry { get; set; }
        public virtual tblCountry tblCountry1 { get; set; }
        public virtual tblDepartment tblDepartment { get; set; }
        public virtual tblDesignation tblDesignation { get; set; }
        public virtual tblState tblState { get; set; }
        public virtual ICollection<tblEmployeeGoal> tblEmployeeGoals { get; set; }
        public virtual tblUserRole tblUserRole { get; set; }
        public virtual tblUserRelationship tblUserRelationship { get; set; }
        public virtual ICollection<tblEmployeeQualificationDetail> tblEmployeeQualificationDetails { get; set; }
        public virtual tblState tblState1 { get; set; }
        public virtual ICollection<tblEmployee> tblEmployee1 { get; set; }
        public virtual tblEmployee tblEmployee2 { get; set; }
        public virtual ICollection<tblLogin> tblLogins { get; set; }
        public virtual ICollection<tblPaySlip> tblPaySlips { get; set; }
        public virtual ICollection<tblProjectDetail> tblProjectDetails { get; set; }
        public virtual ICollection<tblTimeSheet> tblTimeSheets { get; set; }
        public virtual ICollection<tblTraining> tblTrainings { get; set; }
        public virtual ICollection<tblUserLeaveManagement> tblUserLeaveManagements { get; set; }
        public virtual ICollection<tblWorkExperience> tblWorkExperiences { get; set; }
    }
}
