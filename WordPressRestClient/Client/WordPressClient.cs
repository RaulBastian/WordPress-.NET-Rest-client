using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordPressRestClient.Client;

namespace WordPressRestClient {
    public class WordPressClient {

        /// <summary>
        /// e.g: mysite.wordpress.com
        /// </summary>
        /// <param name="uri"></param>
        public WordPressClient(string wordpressSite) {
            this.Posts = new Posts(wordpressSite);
        }


        public Posts Posts { get; private set; }
    }
}
