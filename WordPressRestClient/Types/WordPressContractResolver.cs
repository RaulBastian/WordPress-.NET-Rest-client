using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using WordPressRestClient.Model;

namespace WordPressRestClient.Types {
    public class WordPressContractResolver: DefaultContractResolver {

        Type genericTypeDefinition = (new WordPressResponse<Post>()).GetType().GetGenericTypeDefinition();


        protected override JsonStringContract CreateStringContract(Type objectType) {
            return base.CreateStringContract(objectType);   
        }

        protected override IList<JsonProperty> CreateProperties(Type type, MemberSerialization memberSerialization) {
            var items = base.CreateProperties(type, memberSerialization);

            if (type.IsGenericType && type.GetGenericTypeDefinition() == genericTypeDefinition) {

                var genericParameterType = type.GetGenericArguments().First();

                if(genericParameterType.IsGenericType) {
                    var parameterType = genericParameterType.GenericTypeArguments.First();

                    var wordpressApiName = WordPressAttribute.GetApiNameFromType(parameterType);

                    var responseItem = items.Where(i => i.PropertyType.IsGenericType).First();
                    responseItem.PropertyName = wordpressApiName;
                }

                
            }
            
            return items;
        }

    }
}
