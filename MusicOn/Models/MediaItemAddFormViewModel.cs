using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Assignment5.Models
{
    public class MediaItemAddFormViewModel
    {
        public int ArtistId { get; set; }

        [Required, StringLength(100)]
        [Display(Name ="Descriptive caption")]
        public String Caption { get; set; }

        [Required]
        [Display(Name ="Media item")]
        [DataType(DataType.Upload)]
        public string MediaItemUpload { get; set; }

        public string ArtistName { get; set; }
    }
}