using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assignment5.Models
{
    public class AlbumAddFormViewModel : AlbumAddViewModel
    {
        public SelectList GenreList { get; set; }

        public string ArtistName { get; set; }

        public AlbumAddFormViewModel()
        {
            ReleaseDate = DateTime.Now;
            Tracks = new List<Track>();
        }
    }
}