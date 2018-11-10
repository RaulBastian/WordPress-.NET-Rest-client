using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using WordPressRestClient.Model;

namespace WordPressRestClient.Types {
    public class WordPressContractResolver: DefaultContractResolver {

        /// <summary>
        /// Generic type definition for the WordPressResponse type
        /// </summary>
        Type genericTypeDefinition = (new WordPressResponse<Post>()).GetType().GetGenericTypeDefinition();

        /// <summary>
        /// Updates the the JSON property at runtime, it inspects the WordPressResponse generic argument and updates the json property name
        /// </summary>
        /// <param name="type"></param>
        /// <param name="memberSerialization"></param>
        /// <returns></returns>
        protected override IList<JsonProperty> CreateProperties(Type type, MemberSerialization memberSerialization) {
            var items = base.CreateProperties(type, memberSerialization);

            //If it's a WordPressResponse type...
            if (type.IsGenericType && type.GetGenericTypeDefinition() == genericTypeDefinition) {

                //We retrieve its generic arguments, e.g: Post this would be IEnumerable<Post>
                var genericParameterType = type.GetGenericArguments().First();

                //If it's a generic type, which if it's a IEnumerable<Post> it will, we continue...
                if (genericParameterType.IsGenericType) {

                    //We retrive the generic argument, for IEnumerable<Post>  it would be of type Post
                    var parameterType = genericParameterType.GenericTypeArguments.First();

                    //We get the wordpress corresponding api entity name...
                    var wordpressApiName = WordPressAttribute.GetApiNameFromType(parameterType);

                    //From the JSON contract, we find the property we are interested in and update the property name so it deserialises correctly...
                    var responseItem = items.Where(i => i.PropertyType.IsGenericType).First();
                    responseItem.PropertyName = wordpressApiName;
                }

                
            }
            
            return items;
        }

    }
}
