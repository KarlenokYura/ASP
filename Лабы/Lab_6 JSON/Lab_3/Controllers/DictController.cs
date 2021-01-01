using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ninject;

namespace Lab_3.Controllers
{
    public class DictController: Controller
    {
        TelephoneDll.IPhoneDictionary repo;
        public DictController(TelephoneDll.IPhoneDictionary r1)
        {
            repo = r1;
        }

        public ActionResult Index()
        {
            ViewBag.selectAll1 = repo.selectAll();
            return View();
        }

        public ActionResult Add()
        {
            ViewBag.selectAll1 = repo.selectAll();
            return View();
        }

        [HttpPost]
        public ActionResult Add(string surname, int number)
        {
            repo.insert(surname, number);
            ViewBag.selectAll1 = repo.selectAll();
            return View("Index");
        }

        public ActionResult Update()
        {
            ViewBag.selectAll1 = repo.selectAll();
            return View();
        }

        [HttpPost]
        public ActionResult Update(int id, string surname, int number)
        {
            repo.update(id, surname, number);
            ViewBag.selectAll1 = repo.selectAll();
            return View("Index");
        }

        public ActionResult Delete()
        {
            ViewBag.selectAll1 = repo.selectAll();
            return View();
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            repo.delete(id);
            ViewBag.selectAll1 = repo.selectAll();
            return View("Index");
        }
    }
}