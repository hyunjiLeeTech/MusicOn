using Assignment5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assignment5.Controllers
{
    public class ArtistController : Controller
    {
        private Manager m = new Manager();

        // GET: Artist
        //[Authorize(Roles = "User")]
        public ActionResult Index()
        {
            var artists = m.ArtistGetAll();
            return View(artists);
        }

        // GET: Artist/Details/5
        //[Authorize(Roles = "User")]
        public ActionResult Details(int? id)
        {
            var artist = m.ArtistGetById(id.GetValueOrDefault());
            if (artist != null)
            {
                return View(artist);
            }
            else
            {
                return HttpNotFound();
            }
        }

        //[Authorize(Roles = "User")]
        public ActionResult DetailsWithMediaItems(int? id)
        {
            var artist = m.ArtistGetByIdWithMediaItemInfo(id.GetValueOrDefault());
            if (artist != null)
            {
                return View(artist);
            }
            else
            {
                return HttpNotFound();
            }
        }

        // GET: Artist/Create
        [Authorize(Roles = "Executive")]
        public ActionResult Create()
        {
            //m.User.Name
            var addArtistForm = new ArtistAddFormViewModel();
            addArtistForm.Executive = m.User.Name;
            addArtistForm.GenreList = new SelectList(m.GenreGetAll(), "Name", "Name");
            return View(addArtistForm);
        }

        // POST: Artist/Create
        [Authorize(Roles = "Executive")]
        [ValidateInput(false)]
        [HttpPost]
        public ActionResult Create(ArtistAddViewModel newArtist)
        {
            if (!ModelState.IsValid)
            {
                return View(newArtist);
            }

            var addedArtist = m.ArtistAddNew(newArtist);

            if (addedArtist == null)
            {
                return View(newArtist);
            }
            else
            {
                return RedirectToAction("Details", new { id = addedArtist.Id });
            }
        }

        [Authorize(Roles = "Coordinator")]
        [Route("Artist/{id}/AddAlbum")]
        public ActionResult AddAlbum(int? id)
        {
            var artist = m.ArtistGetById(id.GetValueOrDefault());

            if(artist != null)
            {
                var albumAddForm = new AlbumAddFormViewModel();
                albumAddForm.Coordinator = m.User.Name;
                albumAddForm.GenreList = new SelectList(m.GenreGetAll(), "Name", "Name");
                albumAddForm.ArtistName = artist.Name;
                albumAddForm.ArtistId = artist.Id;
                return View(albumAddForm);
            }
            else
            {
                return HttpNotFound();
            }
        }

        [Authorize(Roles = "Coordinator")]
        [ValidateInput(false)]
        [Route("Artist/{id}/AddAlbum")]
        [HttpPost]
        public ActionResult AddAlbum(AlbumAddViewModel newAlbum)
        {
            if (!ModelState.IsValid)
            {
                return View(newAlbum);
            }

            var addedAlbum = m.AlbumAddNew(newAlbum);

            if (addedAlbum == null)
            {
                return View(newAlbum);
            }
            else
            {
                return RedirectToAction("Details", "Album", new { id = addedAlbum.Id });
            }
        }

        [Authorize(Roles = "Coordinator")]
        [Route("Artist/{id}/AddMediaItem")]
        public ActionResult AddMediaItem(int? id)
        {
            var artist = m.ArtistGetById(id.GetValueOrDefault());

            if(artist == null)
            {
                return HttpNotFound();
            }
            else
            {
                var form = new MediaItemAddFormViewModel();
                form.ArtistId = artist.Id;
                form.ArtistName = artist.Name;

                return View(form);
            }
        }

        [Authorize(Roles = "Coordinator")]
        [HttpPost]
        [Route("Artist/{id}/AddMediaItem")]
        public ActionResult AddMediaItem(int? id, MediaItemAddViewModel newItem)
        {
            if(!ModelState.IsValid && id.GetValueOrDefault() == newItem.ArtistId)
            {
                return View(newItem);
            }

            var addedItem = m.ArtistMediaItemAddNew(newItem);

            if(addedItem == null)
            {
                return View(newItem);
            }
            else
            {
                return RedirectToAction("DetailsWithMediaItems", new { id = addedItem.Id });
            }
        }
    }
}
