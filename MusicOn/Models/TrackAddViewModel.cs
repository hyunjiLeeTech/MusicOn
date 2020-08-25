using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Assignment5.Models
{
    public class TrackAddViewModel
    {
        [Required, StringLength(200)]
        [Display(Name="Track name")]
        public string Name { get; set; }

        // Simple comma-separated string of all the track's composers
        [Required, StringLength(500)]
        [Display(Name="Composer names (comma-separated)")]
        public string Composers { get; set; }

        [Required]
        public string Genre { get; set; }

        // User name who added/edited the track
        [Required, StringLength(200)]
        public string Clerk { get; set; }

        [Display(Name="Album name")]
        public ICollection<Album> Albums { get; set; }

        public HttpPostedFileBase ClipUpload { get; set; }

        public int AlbumId { get; set; }

    }
}