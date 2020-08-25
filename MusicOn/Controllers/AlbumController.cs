using Assignment5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assignment5.Controllers
{
    public class AlbumController : Controller
    {
        private Manager m = new Manager();

        // GET: Album
        //[Authorize(Roles = "User")]
        public ActionResult Index()
        {
            var albums = m.AlbumGetAll();
            return View(albums);
        }

        // GET: Album/Details/5
        //[Authorize(Roles = "User")]
        public ActionResult Details(int? id)
        {
            var album = m.AlbumGetById(id.GetValueOrDefault());

            if(album != null)
            {
                return View(album);
            }
            else
            {
                return HttpNotFound();
            }
        }

        [Authorize(Roles = "Clerk")]
        [Route("Album/{id}/AddTrack")]
        public ActionResult AddTrack(int? id)
        {
            var album = m.AlbumGetById(id.GetValueOrDefault());

            if(album != null)
            {
                var trackAddForm = new TrackAddFormViewModel();
                trackAddForm.GenreList = new SelectList(m.GenreGetAll(), "Name", "Name");
                trackAddForm.AlbumName = album.Name;
                trackAddForm.Clerk = m.User.Name;
                trackAddForm.AlbumId = album.Id;

                return View(trackAddForm);
            }
            else
            {
                return HttpNotFound();
            }
        }

        [Authorize(Roles = "Clerk")]
        [Route("Album/{id}/AddTrack")]
        [HttpPost]
        public ActionResult AddTrack(TrackAddViewModel newTrack)
        {
            if (!ModelState.IsValid)
            {
                return View(newTrack);
            }

            var addedTrack = m.TrackAddNew(newTrack);

            if(addedTrack == null)
            {
                return View(newTrack);
            }
            else
            {
                return RedirectToAction("Details", "Track", new { id = addedTrack.Id });
            }
        }
    }
}
