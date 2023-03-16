using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PresentationLayer.Controllers
{
    public class ContentController : Controller
    {
        // GET: Content

        readonly ContentManager cm = new ContentManager(new EfContent());
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ContentByHeading(int id)
        {
            var contentValues = cm.GetListById(id);
            return View(contentValues);
        }
    }
}