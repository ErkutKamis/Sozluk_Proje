using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PresentationLayer.Controllers
{
    public class WriterController : Controller
    {
        readonly WriterValidator writerValidator = new WriterValidator();
        readonly WriterManager wm = new WriterManager(new EfWriter());
        public ActionResult Index()
        {
            var writerValues = wm.GetList();
            return View(writerValues);
        }


        [HttpGet]
        public ActionResult AddWriter()
        {
            return View();
        }


        [HttpPost]
        public ActionResult AddWriter(Writer w)
        {
           
            ValidationResult result = writerValidator.Validate(w);
            if (result.IsValid)
            {
                wm.WriterAdd(w);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
        [HttpGet]
        public ActionResult EditWriter(int id)
        {
            var writerValues = wm.GetById(id);
            return View(writerValues);
        }
        [HttpPost]
        public ActionResult EditWriter(Writer w)
        {

            ValidationResult result = writerValidator.Validate(w);
            if (result.IsValid)
            {
                wm.WriterUpdate(w);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
           
        }
    }
}