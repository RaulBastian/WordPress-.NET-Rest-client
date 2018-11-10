using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordPressRestClient.Model {
    public class Uncategorized {
        public int ID { get; set; }
        public string name { get; set; }
        public string slug { get; set; }
        public string description { get; set; }
        public int post_count { get; set; }
        public int parent { get; set; }
        public Meta meta { get; set; }
    }
}
