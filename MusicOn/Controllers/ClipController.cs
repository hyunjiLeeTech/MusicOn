using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assignment5.Controllers
{
    public class ClipController : Controller
    {
        private Manager m = new Manager();
        // GET: Clip
        public ActionResult Index()
        {
            return View();
        }

        // GET: Clip/Details/5
        [Route("clip/{id}")]
        public ActionResult Details(int? id)
        {
            var clip = m.TrackClipGetById(id.GetValueOrDefault());

            if(clip != null)
            {
                return File(clip.Clip, clip.ClipContentType);
            }
            else
            {
                return HttpNotFound();
            }
        }

        // GET: Clip/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Clip/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Clip/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Clip/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Clip/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Clip/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
