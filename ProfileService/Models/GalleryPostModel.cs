using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProfileService.Models
{
    public class GalleryModel
    {
        public int GalleryID { get; set; }
        public int UserID { get; set; }
        public List<ImageModel> Images { get; set; }
        public GalleryModel()
        {
            Images = new List<ImageModel>();
        }
    }
}