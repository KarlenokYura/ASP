using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab_3.Controllers
{
    public class DictController : Controller
    {
        Models.TelephoneDictionary telephoneDictionary = new Models.TelephoneDictionary();
        // GET: Dict
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Add()
        {
            return View();
        }

        public ActionResult Update()
        {
            return View();
        }

        public ActionResult Delete()
        {
            return View();
        }
    }
}