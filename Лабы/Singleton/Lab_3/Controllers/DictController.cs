using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ninject;
using Lab_3.Model;

namespace Lab_3.Controllers
{
    public class DictController: Controller
    {
        ISingleton repo1;
        ISingleton repo2;
        ISingleton repo3;
        ISingleton repo4;
        ISingleton repo5;

        public DictController(ISingleton r1, ISingleton r2, ISingleton r3, ISingleton r4, ISingleton r5)
        {
            repo1 = r1;
            repo2 = r2;
            repo3 = r3;
            repo4 = r4;
            repo5 = r5;
        }

        public ActionResult Index()
        {
            return Content($"Result: repo1 = {repo1.Get()}, repo2 = {repo2.Get()}, repo3 = {repo3.Get()}, repo4 = {repo4.Get()}, repo5 = {repo5.Get()}");
        }
    }
}