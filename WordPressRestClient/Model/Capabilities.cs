using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordPressRestClient.Model {
    public class Capabilities {
        public bool publish_post { get; set; }
        public bool delete_post { get; set; }
        public bool edit_post { get; set; }
    }
}
