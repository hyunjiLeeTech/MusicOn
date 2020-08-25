using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Assignment5.Models
{
    public class AlbumAddViewModel
    {

        [Required, StringLength(100)]
        [Display(Name="Album name")]
        public string Name { get; set; }

        [Display(Name="Release date")]
        public DateTime ReleaseDate { get; set; }

        // Get from Apple iTunes Preview, Amazon, or Wikipedia
        [Required, StringLength(200)]
        [Display(Name="Album cover art")]
        public string UrlAlbum { get; set; }

        [Required]
        [Display(Name="Album's primary genre")]
        public string Genre { get; set; }

        // User name who looks after the album
        [Required, StringLength(200)]
        public string Coordinator { get; set; }

        // capture content about the theme, style, content, assembly of the album
        [DataType(DataType.MultilineText)]
        public string Depiction { get; set; }

        public int ArtistId { get; set; }

        public ICollection<Track> Tracks { get; set; }
    }
}