using lab04_tuan04.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace lab04_tuan04.Controllers
{
    public class LaptopController : Controller
    {
        TMDT5Entities db = new TMDT5Entities();
        // GET: Laptop
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult getCompany()
        {
            var ListCompany = db.laptops.GroupBy(l => l.Company).Select(l => l.Key);
            return PartialView(ListCompany);
        }
        public ActionResult getCPU()
        {
            var ListCPU = db.laptops.GroupBy(l => l.Cpu).Select(l => l.Key);
            return PartialView(ListCPU);
        }
        public ActionResult getTypeName()
        {
            var ListTypeName = db.laptops.GroupBy(l => l.TypeName).Select(l => l.Key);
            return PartialView(ListTypeName);
        }
        public ActionResult getMemory()
        {
            var ListMemory = db.laptops.GroupBy(l => l.Memory).Select(l => l.Key);
            return PartialView(ListMemory);
        }
        public ActionResult getGPU()
        {
            var ListGPU = db.laptops.GroupBy(l => l.Gpu).Select(l => l.Key);
            return PartialView(ListGPU);
        }
        public ActionResult getInches()
        {
            var ListInches = db.laptops.GroupBy(l => l.Inches).Select(l => l.Key);
            return PartialView(ListInches);
        }
        public ActionResult getOpSys()
        {
            var ListOpSys = db.laptops.GroupBy(l => l.OpSys).Select(l => l.Key);
            return PartialView(ListOpSys);
        }
        public ActionResult getRam()
        {
            var ListRam = db.laptops.GroupBy(l => l.Ram).Select(l => l.Key);
            return PartialView(ListRam);
        }
        public ActionResult getWeight()
        {
            var ListWeight = db.laptops.GroupBy(l => l.Weight).Select(l => l.Key);
            return PartialView(ListWeight);
        }
    }
}