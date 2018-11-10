using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordPressRestClient.Types {
    public class WordPressResponse<T> where T: class {

        [JsonProperty("found")]
        public int Found { get; set; }

        public T Items { get; set; }
    }
}
