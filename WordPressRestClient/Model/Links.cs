using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordPressRestClient.Model {
    public class Links {
        public string self { get; set; }
        public string help { get; set; }
        public string site { get; set; }
        public string replies { get; set; }
        public string likes { get; set; }

        public string parent { get; set; }
    }
}
