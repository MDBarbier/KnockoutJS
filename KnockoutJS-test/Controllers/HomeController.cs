using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KnockoutJS_test.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View(new DataObject("Hello World", DateTime.Now.ToString()));
        }
    }

    public class DataObject
    {
        public string Message { get; set; }
        public string Timestamp { get; set; }

        public DataObject (string message, string timestamp)
        {
            this.Message = message;
            this.Timestamp = timestamp;
        }
    }
}