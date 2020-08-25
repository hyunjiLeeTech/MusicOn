using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Assignment5.Models
{
    public class ArtistAddViewModel
    {
        // For an individual, can be birth name, or a stage/performer name
        // For a duo/band/group/orchestra, will typically be a stage/performer name
        [Required, StringLength(100)]
        [Display(Name="Artist name or stage name")]
        public string Name { get; set; }

        // For an individual, a birth name
        [StringLength(100)]
        [Display(Name="If applicable, artist's birth name")]
        public string BirthName { get; set; }

        // For an individual, a birth date
        // For all others, can be the date the artist started working together
        [Display(Name="Birth date, or start date")]
        public DateTime BirthOrStartDate { get; set; }

        // Get from Apple iTunes Preview, Amazon, or Wikipedia
        [Required, StringLength(200)]
        [Display(Name="Artist Photo")]
        public string UrlArtist { get; set; }

        [Required]
        [Display(Name="Artist's primary genre")]
        public string Genre { get; set; }

        // User name who looks after this artist
        [Required, StringLength(200)]
        public string Executive { get; set; }

        // Capture content about the history, biographical data, and musical style of the artist
        [DataType(DataType.MultilineText)]
        [Display(Name="Artist portrayal")]
        public string Portrayal { get; set; }

        public ICollection<Album> Albums { get; set; }

    }
}