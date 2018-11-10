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


        //e.g: https://public-api.wordpress.com/rest/v1.1/sites/learnportugueseskype.wordpress.com/posts
        public async Task<IEnumerable<T>> GetAll() {
            HttpClient client = new HttpClient();

            try {
                string response = await client.GetStringAsync(GetEntityURL());


                var response_object = JsonConvert.DeserializeObject<WordPressResponse<IEnumerable<T>>>(response,GetJsonSerializerSettings());

                return response_object.Items;
            }
            catch (Exception ex) {

                throw;
            }
        }
         


        private JsonSerializerSettings GetJsonSerializerSettings() {
            JsonSerializerSettings settings = new JsonSerializerSettings();
            settings.ContractResolver = new WordPressContractResolver();
            return settings;
        }


        private string GetEntityURL() {
            string wordpress_entity = WordPressAttribute.GetApiNameFromType(this.GetType());
            var uri = new Uri(urlWithRelativeURL, wordpress_entity);
            return uri.AbsoluteUri;
        }
        

    }
}
