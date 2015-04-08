using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AquatrohrmsSite.Models;
using System.Web.Security;
using System.Data.SqlClient;
using System.Configuration;
using AquatrohrmsSite.Models;
namespace AquatrohrmsSite.Controllers
{
    public class LoginController : Controller
    {
    
        HRIMSConEntities db = new HRIMSConEntities();
        
        public ActionResult AddEmployee()
        {                                    
            //----------------------- Department Binding entity -----------------------------//
            List<tblDepartment> deptList = (from data in db.tblDepartments
                                            select data).ToList();

            tblDepartment objDept = new tblDepartment();

            objDept.varDepartmentName = "-- Select --";
            objDept.intDepartmentID = 0;

            deptList.Insert(0, objDept);
            SelectList objModelDept = new SelectList(deptList, "intDepartmentID", "varDepartmentName", 0);
            tblLogin objLogin = new tblLogin();
            objLogin.DepartmentModel = objModelDept;

            //---------------------- End Department Binding ---------------------------------------//

            //---------------------- Designation Binding entity ----------------------------//

            List<tblDesignation> desigList = (from data in db.tblDesignations
                                              select data).ToList();

            tblDesignation objDesignation = new tblDesignation();

            objDesignation.varDesignationName = "-- Select --";
            objDesignation.intDesignationID = 0;


            desigList.Insert(0, objDesignation);

            SelectList objModelDesignation = new SelectList(desigList, "intDesignationID", "varDesignationName", 0);

            objLogin.DesignationModel = objModelDesignation;

            //----------------------- End Designation Binding ---------------------------------------//

            //---------------------- Employee Binding entity ----------------------------//

            List<tblEmployee> empList = (from data in db.tblEmployees
                                         select data).ToList();

            tblEmployee objemp = new tblEmployee();
            objemp.varFirstName = "-- Select --";
            objemp.intEmployeeID = 0 ;

            empList.Insert(0, objemp);

            SelectList objEmployeeModel = new SelectList(empList, "intEmployeeID", "varFirstName", 0);

            objLogin.EmployeeModel = objEmployeeModel;

            //---------------------- End Employee Binding ------------------------------------//

            //---------------------- Access Binding entity ----------------------------//

            List<tblAccess> accessList = (from data in db.tblAccesses
                                          select data).ToList();
            SelectList objAccessList = new SelectList(accessList, "intAccessID", "varAccessName", 0);
            objLogin.AccessList = objAccessList;

            //---------------------- End Access Binding ------------------------------------//
         
            return View(objLogin);  
            }
        [HttpPost]
        public ActionResult AddEmployee(tblLogin objtlogin)
        {            
                db.tblLogins.Add(objtlogin);
                db.SaveChanges();           
  
            return RedirectToAction("AddEmployee");
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
        public ActionResult ChangePassword()
        {
            return View();
        }
        public ActionResult Email()
        {
            return View();
        }
        //public ActionResult SendMail(string Subject, string Body)
        //{
        //    Email oMail = new Email();
        //    oMail.SendMail("Email", "xxxxx@xxxxxx.com", new String[] { Subject, Body });

        //    return Content("Success");
        //}
    }
}
