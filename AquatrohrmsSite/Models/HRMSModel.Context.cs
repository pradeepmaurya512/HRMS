﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class HRIMSConEntities : DbContext
    {
        public HRIMSConEntities()
            : base("name=HRIMSConEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<tblAccess> tblAccesses { get; set; }
        public DbSet<tblActivityDetail> tblActivityDetails { get; set; }
        public DbSet<tblAllowance> tblAllowances { get; set; }
        public DbSet<tblAllowancesManagement> tblAllowancesManagements { get; set; }
        public DbSet<tblCity> tblCities { get; set; }
        public DbSet<tblClientDetail> tblClientDetails { get; set; }
        public DbSet<tblClientTeam> tblClientTeams { get; set; }
        public DbSet<tblCountry> tblCountries { get; set; }
        public DbSet<tblDepartment> tblDepartments { get; set; }
        public DbSet<tblDesignation> tblDesignations { get; set; }
        public DbSet<tblEmployee> tblEmployees { get; set; }
        public DbSet<tblEmployeeGoal> tblEmployeeGoals { get; set; }
        public DbSet<tblEmployeeQualificationDetail> tblEmployeeQualificationDetails { get; set; }
        public DbSet<tblHolidayList> tblHolidayLists { get; set; }
        public DbSet<tblLeaveType> tblLeaveTypes { get; set; }
        public DbSet<tblLinkDetail> tblLinkDetails { get; set; }
        public DbSet<tblLogin> tblLogins { get; set; }
        public DbSet<tblNew> tblNews { get; set; }
        public DbSet<tblPaySlip> tblPaySlips { get; set; }
        public DbSet<tblPosition> tblPositions { get; set; }
        public DbSet<tblProjectDetail> tblProjectDetails { get; set; }
        public DbSet<tblRecruitment> tblRecruitments { get; set; }
        public DbSet<tblRecruitmentType> tblRecruitmentTypes { get; set; }
        public DbSet<tblState> tblStates { get; set; }
        public DbSet<tblStatu> tblStatus { get; set; }
        public DbSet<tblTimeSheet> tblTimeSheets { get; set; }
        public DbSet<tblTraining> tblTrainings { get; set; }
        public DbSet<tblUserLeaveManagement> tblUserLeaveManagements { get; set; }
        public DbSet<tblUserRelationship> tblUserRelationships { get; set; }
        public DbSet<tblUserRole> tblUserRoles { get; set; }
        public DbSet<tblVacancise> tblVacancises { get; set; }
        public DbSet<tblWorkExperience> tblWorkExperiences { get; set; }
    }
}
