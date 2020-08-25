using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assignment5.Models
{
    public class TrackAddFormViewModel
    {
        [Required, StringLength(200)]
        [Display(Name = "Track name")]
        public string Name { get; set; }

        // Simple comma-separated string of all the track's composers
        [Required, StringLength(500)]
        [Display(Name = "Composer names (comma-separated)")]
        public string Composers { get; set; }

        [Required]
        public string Genre { get; set; }

        // User name who added/edited the track
        [Required, StringLength(200)]
        public string Clerk { get; set; }

        [DataType(DataType.Upload)]
        [Display(Name = "Sample clip")]
        public string ClipUpload { get; set; }

        [Display(Name = "Album name")]
        public ICollection<Album> Albums { get; set; }

        public SelectList GenreList { get; set; }


        public string AlbumName { get; set; }

        public int AlbumId { get; set; }

        public TrackAddFormViewModel()
        {
            Albums = new List<Album>();
        }
    }
}