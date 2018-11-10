using WordPressRestClient.Model;
using WordPressRestClient.Types;

namespace WordPressRestClient.Client {

    [WordPressAttribute(ApiName ="posts")]
    public class Posts: BaseClient<Post> {

        public Posts(string relativeSite):base(relativeSite) {

        }

    }
}
