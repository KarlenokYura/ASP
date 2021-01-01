using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ninject;

namespace Lab_4.Controllers
{
    public class DictController : Controller
    {
        TelephoneDll.IPhoneDictionary repo;
        public DictController(TelephoneDll.IPhoneDictionary r)
        {
            IKernel ninjectKernel = new StandardKernel();
            ninjectKernel.Bind<TelephoneDll.IPhoneDictionary>().To<TelephoneDll.TelephoneContext>();
            repo = ninjectKernel.Get<TelephoneDll.IPhoneDictionary>();
        }

        // GET: Dict
        public ActionResult Index()
        {
            ViewBag.Select = repo.Select();
            return View();
        }

        public ActionResult Add()
        {
            ViewBag.Select = repo.Select();
            return View();
        }

        [HttpPost]
        public ActionResult Add(string surname, int number)
        {
            repo.Insert(surname, number);
            ViewBag.Select = repo.Select();
            return View("Index");
        }

        public ActionResult Update()
        {
            ViewBag.Select = repo.Select();
            return View();
        }

        [HttpPost]
        public ActionResult Update(int id, string surname, int number)
        {
            repo.Update(id, surname, number);
            ViewBag.Select = repo.Select();
            return View("Index");
        }

        public ActionResult Delete()
        {
            ViewBag.Select = repo.Select();
            return View();
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            repo.Delete(id);
            ViewBag.Select = repo.Select();
            return View("Index");
        }
    }
}