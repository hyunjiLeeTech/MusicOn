using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assignment5.Models
{
    public class ArtistAddFormViewModel: ArtistAddViewModel
    {
        public SelectList GenreList { get; set; }

        public ArtistAddFormViewModel()
        {
            BirthOrStartDate = DateTime.Now;
            Albums = new List<Album>();
        }
    }
}