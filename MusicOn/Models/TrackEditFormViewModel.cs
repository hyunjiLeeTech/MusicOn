using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assignment5.Models
{
    public class TrackEditFormViewModel
    {
        [Key]
        public int Id { get; set; }

        [Required, StringLength(200)]
        [Display(Name = "Track name")]
        public string Name { get; set; }

        [DataType(DataType.Upload)]
        [Display(Name = "Sample clip")]
        public string ClipUpload { get; set; }
    }
}