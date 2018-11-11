using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordPressRestClient.Client;
using WordPressRestClient.Model;
using WordPressRestClient.Types;

namespace WordPressRestClient.Model {

    [WordPressAttribute(ApiName = "posts")]
    public class Post {

        [JsonProperty("ID",DefaultValueHandling =DefaultValueHandling.Ignore)]
        public int Id { get; set; }

        [JsonProperty("site_ID", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Site_ID { get; set; }

        [JsonProperty("author", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Author Author { get; set; }

        [JsonProperty("Date", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DateTime date { get; set; }

        [JsonProperty("modified", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DateTime Modified { get; set; }

        [JsonProperty("title", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Title { get; set; }

        [JsonProperty("URL", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string URL { get; set; }

        [JsonProperty("short_URL", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Short_URL { get; set; }

        [JsonProperty("content", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Content { get; set; }

        [JsonProperty("excerpt", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Excerpt { get; set; }

        [JsonProperty("slug", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Slug { get; set; }

        [JsonProperty("guid", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Guid { get; set; }

        [JsonProperty("status", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Status { get; set; }

        [JsonProperty("sticky", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool Sticky { get; set; }

        [JsonProperty("password", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Password { get; set; }

        [JsonProperty("parent", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool Parent { get; set; }

        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Type { get; set; }

        [JsonProperty("discussion", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Discussion Discussion { get; set; }

        [JsonProperty("likes_enabled", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool Likes_enabled { get; set; }

        [JsonProperty("sharing_enabled", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool Sharing_enabled { get; set; }

        [JsonProperty("like_count", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Like_count { get; set; }

        [JsonProperty("i_like", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool L_like { get; set; }

        [JsonProperty("is_reblogged", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool Is_reblogged { get; set; }

        [JsonProperty("is_following", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool Is_following { get; set; }

        [JsonProperty("global_ID", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Global_ID { get; set; }

        [JsonProperty("featured_image", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Featured_image { get; set; }

        [JsonProperty("post_thumbnail", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Post_Thumbnail Post_thumbnail { get; set; }

        [JsonProperty("format", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Format { get; set; }

        [JsonProperty("geo", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool Geo { get; set; }

        [JsonProperty("menu_order", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Menu_order { get; set; }

        [JsonProperty("page_template", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Page_template { get; set; }

        [JsonProperty("publicize_URLs", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object[] Publicize_URLs { get; set; }

        [JsonProperty("terms", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Terms Terms { get; set; }

        [JsonProperty("tags", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Tags Tags { get; set; }

        [JsonProperty("categories", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Categories Categories { get; set; }

        [JsonProperty("attachments", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Attachments Attachments { get; set; }

        [JsonProperty("attachment_count", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Attachment_count { get; set; }

        [JsonProperty("metadata", DefaultValueHandling = DefaultValueHandling.Include)]
        [JsonConverter(typeof(BoolToNullConverter))]
        public Metadata[] Metadata { get; set; }

        [JsonProperty("meta", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Meta Meta { get; set; }

        [JsonProperty("capabilities", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Capabilities Capabilities { get; set; }

        [JsonProperty("other_URLs", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public OtherUrls OtherURLs { get; set; }
    }
}














































