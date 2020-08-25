using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Assignment5.Models
{
    public class GenreBaseViewModel
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
    }
}