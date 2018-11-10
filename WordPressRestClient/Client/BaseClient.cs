using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using WordPressRestClient.Types;

namespace WordPressRestClient.Client {
    public class BaseClient<T> where T: class {

        private Uri urlWithRelativeURL = null;
        private const string baseURI = "https://public-api.wordpress.com/rest/v1.1/sites/";

        public BaseClient(string relativeURL) {
            urlWithRelativeURL = new Uri(new Uri(baseURI), relativeURL);
        }

        /// <summary>
        /// Returns a WordPressResponse for the current entity
        /// </summary>
        /// <returns></returns>
        public async Task<WordPressResponse<IEnumerable<T>>> GetAll() {
            HttpClient client = new HttpClient();
            string response = await client.GetStringAsync(GetCurrentEntityURL());
            return JsonConvert.DeserializeObject<WordPressResponse<IEnumerable<T>>>(response, GetJsonSerializerSettings());
        }


        /// <summary>
        /// Configures a JsonSerializerSettings instance with a WordPressContractResolver
        /// </summary>
        /// <returns></returns>
        private JsonSerializerSettings GetJsonSerializerSettings() {
            JsonSerializerSettings settings = new JsonSerializerSettings();
            settings.ContractResolver = new WordPressContractResolver();
            return settings;
        }

        /// <summary>
        /// Returns the URL for the current entity from the base and relative URL
        /// </summary>
        /// <returns></returns>
        private string GetCurrentEntityURL() {
            string wordpress_entity = WordPressAttribute.GetApiNameFromType(this.GetType());
            var uri = new Uri(urlWithRelativeURL, wordpress_entity);
            return uri.AbsoluteUri;
        }
        

    }
}
