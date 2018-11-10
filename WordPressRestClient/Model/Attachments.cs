using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordPressRestClient.Model {
    public class Attachments {
        public _9 _9 { get; set; }
    }

    public class _9 {
        public int ID { get; set; }
        public string URL { get; set; }
        public string guid { get; set; }
        public DateTime date { get; set; }
        public int post_ID { get; set; }
        public int author_ID { get; set; }
        public string file { get; set; }
        public string mime_type { get; set; }
        public string extension { get; set; }
        public string title { get; set; }
        public string caption { get; set; }
        public string description { get; set; }
        public string alt { get; set; }
        public Thumbnails thumbnails { get; set; }
        public int height { get; set; }
        public int width { get; set; }
        public Exif exif { get; set; }
        public Meta meta { get; set; }
    }

}
