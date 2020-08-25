using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment5.Models
{
    public class ArtistWithMediaItemStringIdsViewModel: ArtistBaseViewModel
    {
        public ArtistWithMediaItemStringIdsViewModel()
        {
            MediaItems = new List<MediaItemBaseViewModel>();
        }

        public IEnumerable<MediaItemBaseViewModel> MediaItems { get; set; }
    }
}