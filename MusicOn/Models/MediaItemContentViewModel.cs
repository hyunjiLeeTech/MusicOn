using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment5.Models
{
    public class MediaItemContentViewModel
    {
        public int Id { get; set; }
        public string ContentType { get; set; }
        public byte[] Content { get; set; }
    }
}