using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Assignment5.Models
{
    public class MediaItemAddViewModel
    {
        public int ArtistId { get; set; }
        
        [Required, StringLength(100)]
        public string Caption { get; set; }

        [Required]
        public HttpPostedFileBase MediaItemUpload { get; set; }
    }
}