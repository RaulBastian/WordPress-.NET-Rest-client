using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordPressRestClient.Model;

namespace WordPressRestClient.Types {

    /// <summary>
    /// Converts false to null when deserialising a boolen value to an array.
    /// e.g: Only used with the Metadata property.
    /// </summary>
    public class BoolToNullConverter : JsonConverter {
        public override bool CanConvert(Type objectType) {
            return true;
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) {
            if (reader != null && reader.Value is bool) {
                return null;
            }

            if(objectType == typeof(Metadata[])) {
                return serializer.Deserialize<Metadata[]>(reader);
            }

            return serializer.Deserialize(reader);
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) {
         
        }
    }
}
