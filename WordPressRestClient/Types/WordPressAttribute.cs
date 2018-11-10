using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordPressRestClient.Types {

    /// <summary>
    /// Attribute used to map a .NET to a wordpress entity
    /// </summary>
    public class WordPressAttribute:Attribute {

        private static Dictionary<Type, string> type_entity_api_name = new Dictionary<Type, string>();

        public string ApiName { get; set; }

        public static string GetApiNameFromType(Type type) {
            if (!type_entity_api_name.ContainsKey(type)) {
                var attribute = type.GetCustomAttributes(typeof(WordPressAttribute), true).OfType<WordPressAttribute>().FirstOrDefault();
                type_entity_api_name.Add(type, attribute.ApiName);
            }
            return type_entity_api_name[type];
        }

    }
}
