using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfileService.Models
{
    public class PostModel
    {
        public int PostID { get; set; }
        public int UserID { get; set; }
        public string ImageID { get; set; }
        public string PostTitle { get; set; }
        public string PostText { get; set; }
    }
}
