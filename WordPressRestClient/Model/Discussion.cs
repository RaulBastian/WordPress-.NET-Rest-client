using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordPressRestClient.Model {
    public class Discussion {
        public bool comments_open { get; set; }
        public string comment_status { get; set; }
        public bool pings_open { get; set; }
        public string ping_status { get; set; }
        public int comment_count { get; set; }
    }
}
