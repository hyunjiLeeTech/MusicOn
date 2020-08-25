using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Assignment5.Models
{
    public class TrackEditViewModel
    {
        [Key]
        public int Id { get; set; }
        public HttpPostedFileBase ClipUpload { get; set; }
    }
}