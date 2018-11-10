using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordPressRestClient.Client;

namespace WordPressRestClient {

    /// <summary>
    /// Word press client for inspecting word press web sites
    /// </summary>
    public class WordPressClient {

        /// <summary>
        ///  WordPressClient constructor
        /// </summary>
        /// <param name="wordpressSite">e.g: learnportugueseskype.wordpress.com/</param>
        public WordPressClient(string wordpressSite) {
            this.Posts = new Posts(wordpressSite);
        }

        /// <summary>
        ///  Site blog posts
        /// </summary>
        public Posts Posts { get; private set; }
    }
}
