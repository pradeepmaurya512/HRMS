﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AquatrohrmsSite.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class HRIMSConnectionEntities : DbContext
    {
        public HRIMSConnectionEntities()
            : base("name=HRIMSConnectionEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tblAccess> tblAccesses { get; set; }
        public virtual DbSet<tblActivityDetail> tblActivityDetails { get; set; }
        public virtual DbSet<tblAllowance> tblAllowances { get; set; }
        public virtual DbSet<tblAllowancesManagement> tblAllowancesManagements { get; set; }
        public virtual DbSet<tblCity> tblCities { get; set; }
        public virtual DbSet<tblClientDetail> tblClientDetails { get; set; }
        public virtual DbSet<tblClientTeam> tblClientTeams { get; set; }
        public virtual DbSet<tblCountry> tblCountries { get; set; }
        public virtual DbSet<tblDepartment> tblDepartments { get; set; }
        public virtual DbSet<tblDesignation> tblDesignations { get; set; }
        public virtual DbSet<tblEmployee> tblEmployees { get; set; }
        public virtual DbSet<tblEmployeeGoal> tblEmployeeGoals { get; set; }
        public virtual DbSet<tblEmployeeQualificationDetail> tblEmployeeQualificationDetails { get; set; }
        public virtual DbSet<tblHolidayList> tblHolidayLists { get; set; }
        public virtual DbSet<tblLeaveType> tblLeaveTypes { get; set; }
        public virtual DbSet<tblLinkDetail> tblLinkDetails { get; set; }
        public virtual DbSet<tblLogin> tblLogins { get; set; }
        public virtual DbSet<tblNew> tblNews { get; set; }
        public virtual DbSet<tblPaySlip> tblPaySlips { get; set; }
        public virtual DbSet<tblPosition> tblPositions { get; set; }
        public virtual DbSet<tblProjectDetail> tblProjectDetails { get; set; }
        public virtual DbSet<tblRecruitment> tblRecruitments { get; set; }
        public virtual DbSet<tblRecruitmentType> tblRecruitmentTypes { get; set; }
        public virtual DbSet<tblState> tblStates { get; set; }
        public virtual DbSet<tblStatu> tblStatus { get; set; }
        public virtual DbSet<tblTimeSheet> tblTimeSheets { get; set; }
        public virtual DbSet<tblTraining> tblTrainings { get; set; }
        public virtual DbSet<tblUserLeaveManagement> tblUserLeaveManagements { get; set; }
        public virtual DbSet<tblUserRelationship> tblUserRelationships { get; set; }
        public virtual DbSet<tblUserRole> tblUserRoles { get; set; }
        public virtual DbSet<tblVacancise> tblVacancises { get; set; }
        public virtual DbSet<tblWorkExperience> tblWorkExperiences { get; set; }
    }
}
