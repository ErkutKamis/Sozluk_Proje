using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.Mvc;

namespace PresentationLayer.Controllers
{
    public class HeadingController : Controller
    {
        // GET: Heading
        readonly HeadingManager hm = new HeadingManager(new EfHeading());
        readonly CategoryManager cm = new CategoryManager(new EfCategory());
        readonly WriterManager wm = new WriterManager(new EfWriter());

        public ActionResult Index()
        {
            var headingValues = hm.GetList();
            return View(headingValues);
        }
        [HttpGet]
        public ActionResult AddHeading()
        {
            List<SelectListItem> valueCategory = (from x in cm.GetCategoryList()
                                                  select new SelectListItem
                                                  {
                                                      Text = x.CategoryName ,
                                                      Value = x.Id.ToString()
                                                  }
                                                  ).ToList();
            List<SelectListItem> valueWriter = (from x in wm.GetList()
                                               select new SelectListItem
                                               {
                                                   Text = x.WriterName,
                                                   Value = x.Id.ToString()
                                               }
                                               ).ToList();
            ViewBag.vlc = valueCategory;
            ViewBag.vlw = valueWriter;
            return View();
        }
        [HttpPost]
        public ActionResult AddHeading(Heading h)
        {
            h.HeadingDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            hm.HeadingAdd(h);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult EditHeading(int id)
        {
            List<SelectListItem> valueCategory = (from x in cm.GetCategoryList()
                                                  select new SelectListItem
                                                  {
                                                      Text = x.CategoryName,
                                                      Value = x.Id.ToString()
                                                  }
                                                 ).ToList();
            ViewBag.vlc = valueCategory;
            var headingValues = hm.GetById(id);
            return View(headingValues);
        }
        [HttpPost]
        public ActionResult EditHeading(Heading h)
        {
            hm.HeadingUpdate(h);
            return RedirectToAction("Index");
        }

        public ActionResult DeleteHeading(int id)
        {
            var headingValue = hm.GetById(id);
            headingValue.HeadingStatus = false;
            hm.HeadingDelete(headingValue);
            return RedirectToAction("Index");
        }


    }
}