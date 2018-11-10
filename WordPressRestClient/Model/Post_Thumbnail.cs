using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordPressRestClient.Model {
    public class Post_Thumbnail {
        public int ID { get; set; }
        public string URL { get; set; }
        public string guid { get; set; }
        public string mime_type { get; set; }
        public int width { get; set; }
        public int height { get; set; }
    }
}
