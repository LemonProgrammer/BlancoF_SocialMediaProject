using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProfileService.Models
{
    public class FavoritesModel
    {
        // Enums?
        public int CategoryID { get; set; }
        public string Category { get; set; }
        public string Title { get; set; }
        //public string Genre { get; set; }
        public ImageModel Image { get; set; }
    }
}