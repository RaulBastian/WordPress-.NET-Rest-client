using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordPressRestClient.Types {

    /// <summary>
    /// Generic type used for word press responses
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class WordPressResponse<T> where T: class {

        [JsonProperty("found")]
        public int Found { get; set; }

        public T Items { get; set; }
    }
}
