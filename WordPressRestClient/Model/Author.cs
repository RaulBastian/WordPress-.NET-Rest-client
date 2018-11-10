using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordPressRestClient.Model {
    public class Author {
        public int ID { get; set; }
        public string login { get; set; }
        public bool email { get; set; }
        public string name { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string nice_name { get; set; }
        public string URL { get; set; }
        public string avatar_URL { get; set; }
        public string profile_URL { get; set; }
        public int site_ID { get; set; }

    }
}
