﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AquatrohrmsSite.Models;
using System.Web.Security;
namespace AquatrohrmsSite.Controllers
{
    public class LoginController : Controller
    {
        //
        // GET: /Login/

        HRIMSConEntities db = new HRIMSConEntities();
        public ActionResult AddEmployee()
        {
             //ViewBag.Departments = (db.tblDepartments.Select(x => new { x.intDepartmentID, x.varDepartmentName })).ToList();
            ViewBag.departs = new SelectList(db.tblDepartments, "intDepartmentID", "varDepartmentName");
            ViewBag.designation = new SelectList(db.tblDesignations, "intDesignationID", "varDesignationName");
            return View();
        }

        [HttpPost]
        public ActionResult AddEmployee(tblLogin objtlogin)
        {

            tblEmployee objemp = new tblEmployee();
            //objemp.intDepartmentID= new SelectList(,)
            db.tblLogins.Add(objtlogin);
         
            db.SaveChanges();
            return View();
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
            using (  HRIMSConEntities db = new HRIMSConEntities())
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
    }
}
