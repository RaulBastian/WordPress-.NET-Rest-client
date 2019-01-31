using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordPressRestClient.Types
{
    public class WordPressConvert
    {
        public static WordPressResponse<T> DeserializeObject<T>(string json) where T: class
        {
            return JsonConvert.DeserializeObject<WordPressResponse<T>>(json, GetJsonSerializerSettings());
        }

        /// <summary>
        /// Configures a JsonSerializerSettings instance with a WordPressContractResolver
        /// </summary>
        /// <returns></returns>
        private static JsonSerializerSettings GetJsonSerializerSettings()
        {
            JsonSerializerSettings settings = new JsonSerializerSettings();
            settings.ContractResolver = new WordPressContractResolver();
            return settings;
        }
    }
}
