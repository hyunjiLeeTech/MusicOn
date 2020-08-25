﻿using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assignment5.Controllers
{
    public class MediaItemController : Controller
    {
        private Manager m = new Manager();
        // GET: MediaItem
        public ActionResult Index()
        {
            return View();
        }

        [Route("mediaItem/{stringId}")]
        public ActionResult Details(string stringId = "")
        {
            var artist = m.ArtistMediaItemGetById(stringId);

            if(artist == null)
            {
                return HttpNotFound();
            }
            else
            {
                return File(artist.Content, artist.ContentType);
            }
        }

        //[Route("mediaItem/{stringId}/download")]
        //public ActionResult DetailsDownload(string stringId = "")
        //{
        //    var artist = m.ArtistMediaItemGetById(stringId);

        //    if(artist == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    else
        //    {
        //        string extension;
        //        RegistryKey key;
        //        object value;

        //        key = Registry.ClassesRoot.OpenSubKey(@"MIME\Database\Content Type\" + o.ContentType, false);
        //        value = (key == null) ? null : key.GetValue("Extension", null);
        //        extension = (value == null) ? string.Empty : value.ToString();

        //        var cd = new System.Net.Mime.ContentDisposition
        //        {
        //            FileName = $"img-{stringId}{extension}",
        //            Inline = false
        //        };

        //        Response.AppendHeader("Content-Disposition", cd.ToString());

        //        return File(artist.Content, artist.ContentType);
        //    }
        //}

        // GET: MediaItem/Details/5
        //[Route("mediaitem/{id}")]
        //public ActionResult Details(string id="")
        //{
            
        //    return View();
        //}

        // GET: MediaItem/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MediaItem/Create
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

        // GET: MediaItem/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MediaItem/Edit/5
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

        // GET: MediaItem/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MediaItem/Delete/5
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
