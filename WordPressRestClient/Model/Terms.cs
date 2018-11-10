using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordPressRestClient.Model {
    public class Terms {
        public Category category { get; set; }
        public Post_Tag post_tag { get; set; }
        public Post_Format post_format { get; set; }
        public Mentions mentions { get; set; }
    }
}
