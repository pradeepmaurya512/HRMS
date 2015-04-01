using AquatrohrmsSite.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AquatrohrmsSite.Controllers
{
    public class HomeController : Controller
    {
          HRIMSConEntities db = new HRIMSConEntities(); 

        public ActionResult Index() {

            return View();
        }

        public ActionResult AddClient()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddClient(tblClientDetail objclient)
        {
            objclient.dtCreatedOn = DateTime.Now;
            db.tblClientDetails.Add(objclient);
            db.SaveChanges();
            return View();
        }

        [HttpPost]
        public JsonResult ClientList()
        {
            List<tblClientDetail> client = db.tblClientDetails.ToList();
            //return Json(client);
           // System.Web.Script.Serialization.JavaScriptSerializer objJSSerializer = new System.Web.Script.Serialization.JavaScriptSerializer();
           // var o = JObject.Parse("sss");
            //return "dgdg";
            //var strJSON = objJSSerializer.Serialize(client);
            return Json(client,JsonRequestBehavior.AllowGet);
        }

    }
}
