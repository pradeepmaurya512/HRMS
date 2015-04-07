﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AquatrohrmsSite.Models;
using System.Web.Security;
using System.Data.SqlClient;
using System.Configuration;
using AquatrohrmsSite.Models;
using System.Net.Mail;
using System.Net;
namespace AquatrohrmsSite.Controllers
{
    public class LoginController : Controller
    {

        HRIMSConEntities db = new HRIMSConEntities();
        [HttpGet]
        public ActionResult AddEmployee()
        {
            //ViewBag.Departments = (db.tblDepartments.Select(x => new { x.intDepartmentID, x.varDepartmentName })).ToList();

            ViewBag.departs = new SelectList(db.tblDepartments, "intDepartmentID", "varDepartmentName");
            ViewBag.designation = new SelectList(db.tblDesignations, "intDesignationID", "varDesignationName");

            //ViewBag.reportingto = new SelectList(db.tblEmployees, "intEmployeeID", "varFirstName");
            //ViewBag.Acesscontrol = new SelectList(db.tblDesignations, "intAccessID", "varFirstName");
            //ViewBag.accessID = new SelectList(db.tblAccesses, "intAccessID", "varAccessName");
            //ViewBag.employeelist = new SelectList(db.tblEmployees, "intEmployeeID", "varFirstName");

            return View();
        }

        [HttpPost]
        public ActionResult AddEmployee(tblLogin objtlogin)
        {
            tblEmployee objemp = new tblEmployee();
            //objemp.intDepartmentID= new SelectList(,)
            if (ModelState.IsValid)
            {
                db.tblLogins.Add(objtlogin);
                db.tblEmployees.Add(objemp);
                db.SaveChanges();
            }

            ViewBag.departs = new SelectList(db.tblDepartments, "intDepartmentID", "varDepartmentName", objemp.intDepartmentID);
            ViewBag.designation = new SelectList(db.tblDesignations, "intDesignationID", "varDesignationName", objemp.intDesignationId);
            //ViewBag.reportingto = new SelectList(db.tblDesignations, "intEmpRoleID", "varDesignationName", objemp.intReportingHead);
            //ViewBag.accessID = new SelectList(db.tblAccesses, "intAccessID", "varAccessName", objemp.varAccessLevel);
            //ViewBag.employeelist = new SelectList(db.tblEmployees, "intEmployeeID", "varFirstName", objemp.intEmployeeID);
            return View(objtlogin);
        }

        public JsonResult CheckForDuplication(string EmailId)
        {
            var data = db.tblLogins.Where(p => p.varLoginName.Equals(EmailId, StringComparison.CurrentCultureIgnoreCase)).FirstOrDefault();

            if (data != null)
            {
                return Json("Sorry, this name already exists", JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(true, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpGet]
        public ActionResult AccountLogin()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AccountLogin(tblLogin objlogin)
        {

            if (IsValid(objlogin.varLoginName, objlogin.varPassword))
            {
                FormsAuthentication.SetAuthCookie(objlogin.varLoginName, false);

                return RedirectToAction("Index", "Home");
            }
            else
            {
                return RedirectToAction("AddEmployee", "Login");
                //ModelState.AddModelError("", "Login details are wrong.");
            }
            return View(objlogin);

        }

        private bool IsValid(string username, string password)
        {
            var crypto = new SimpleCrypto.PBKDF2();
            bool IsValid = false;
            using (HRIMSConEntities db = new HRIMSConEntities())
            {
                var user = db.tblLogins.Where(x => x.varLoginName == username).FirstOrDefault();
                if (user != null)
                {
                    if (user.varPassword == password)
                    {
                        IsValid = true;
                    }
                }
            }
            return IsValid;
        }

        public ActionResult ChangePassword()
        {
            return View();
        }

        public ActionResult ForgotPassword()
        {

            return View();
        }


    }

   }

      
