using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment5.Models
{
    public class TrackClipViewModel
    {
        public int Id { get; set; }
        public string ClipContentType { get; set; }
        public byte[] Clip { get; set; }
    }
}