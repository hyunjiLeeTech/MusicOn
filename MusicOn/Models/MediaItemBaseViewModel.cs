using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Assignment5.Models
{
    public class MediaItemBaseViewModel
    {
        public int Id { get; set; }

        [Display(Name="Added on date/time")]
        public DateTime TimeStamp { get; set; }

        // For the generated identifier
        [Required, StringLength(100)]
        [Display(Name = "Unique identifier")]
        public string StringId { get; set; }

        // Brief descriptive caption
        [Required, StringLength(100)]
        [Display(Name = "Descriptive caption")]
        public string Caption { get; set; }

        public string ContentType { get; set; }
    }
}