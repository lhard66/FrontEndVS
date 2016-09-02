using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FrontEndStudy.Controllers
{
    public class ValidateController : Controller
    {
        // GET: Validate
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult DoPost(string name="",string pwd="")
        {
            return Content(name + "---" + pwd);
        }
        [HttpPost]
        public bool CanLogin(string name = "", string pwd = "")
        {
            if (name == "lhard" && pwd == "123")
            {
                return true;
            }
            return false;
        }
    }
}