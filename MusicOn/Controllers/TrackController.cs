using Assignment5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assignment5.Controllers
{
    public class TrackController : Controller
    {
        private Manager m = new Manager();

        // GET: Track
        //[Authorize(Roles = "User")]
        public ActionResult Index()
        {
            var tracks = m.TrackGetAll();
            return View(tracks);
        }

        // GET: Track/Details/5
        //[Authorize(Roles = "User")]
        public ActionResult Details(int? id)
        {
            var track = m.TrackGetById(id.GetValueOrDefault());
            return View(track);
        }

        // POST: Track/Create
        [Authorize(Roles = "Clerk")]
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

        // GET: Track/Edit/5
        [Authorize(Roles = "Clerk")]
        public ActionResult Edit(int? id)
        {
            var track = m.TrackGetById(id.GetValueOrDefault());

            if(track != null)
            {
                var editedTrack = m.mapper.Map<TrackBaseViewModel, TrackEditFormViewModel>(track);
                return View(editedTrack);
            }
            else
            {
                return HttpNotFound();
            }
        }

        // POST: Track/Edit/5
        [Authorize(Roles = "Clerk")]
        [HttpPost]
        public ActionResult Edit(int? id, TrackEditViewModel track)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Edit", new { id = track.Id});
            }

            if (id.GetValueOrDefault() != track.Id)
            {
                return RedirectToAction("Index");
            }

            var editedEmployee = m.TrackEdit(track);

            if (editedEmployee != null)
            {
                return RedirectToAction("Index", new { id = track.Id });
            }
            else
            {
                return RedirectToAction("Edit", new { id = track.Id });
            }
        }

        // GET: Track/Delete/5
        [Authorize(Roles = "Clerk")]
        public ActionResult Delete(int? id)
        {
            var track = m.TrackGetById(id.GetValueOrDefault());
            if(track == null)
            {
                return HttpNotFound();
            }
            else
            {
                return View(track);
            }
        }

        // POST: Track/Delete/5
        [Authorize(Roles = "Clerk")]
        [HttpPost]
        public ActionResult Delete(int? id, HttpPostedFileBase clip)
        {
            m.TrackDelete(id.GetValueOrDefault(), clip);

            return RedirectToAction("Index");
        }
    }
}
