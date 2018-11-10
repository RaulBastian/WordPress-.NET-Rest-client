using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordPressRestClient.Model {
    public class Exif {
        public string aperture { get; set; }
        public string credit { get; set; }
        public string camera { get; set; }
        public string caption { get; set; }
        public string created_timestamp { get; set; }
        public string copyright { get; set; }
        public string focal_length { get; set; }
        public string iso { get; set; }
        public string shutter_speed { get; set; }
        public string title { get; set; }
        public string orientation { get; set; }
        public object[] keywords { get; set; }
    }
}
