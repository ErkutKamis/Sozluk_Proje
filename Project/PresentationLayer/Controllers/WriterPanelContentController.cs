using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using PagedList;
using PagedList.Mvc;

namespace PresentationLayer.Controllers
{
    public class WriterPanelContentController : Controller
    {
        // GET: WriterPanelContent

        readonly ContentManager cm = new ContentManager(new EfContent());
        readonly Context c = new Context();

        public ActionResult MyContent(string p)
        {
            
            p = (string)Session["WriterMail"];
            var writeridinfo = c.Writers.Where(x => x.WriterMail == p).Select(y => y.Id).FirstOrDefault();
            var contentValues = cm.GetListByWriter(writeridinfo);
            return View(contentValues);
        }
        [HttpGet]
        public ActionResult AddContent(int id)
        {
            ViewBag.d = id;
            return View();
        }
        [HttpPost]
        public ActionResult AddContent(EntityLayer.Concrete.Content ct)
        {
            string mail = (string)Session["WriterMail"];
            var writeridinfo = c.Writers.Where(x => x.WriterMail == mail).Select(y => y.Id).FirstOrDefault();
            ct.ContentDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            ct.WriterId = writeridinfo;
            ct.ContentStatus = true;
            cm.ContentAdd(ct);
            return RedirectToAction("MyContent");
        }

    }
}