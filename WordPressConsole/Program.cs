using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordPressPCL;
using WordPressRestClient;

namespace WordPress {
    class Program {
        static void Main(string[] args) {
            // var client = new WordPressClient("http://demo.wp-api.org/wp-json/");
            //var client = new WordPressClient("https://public-api.wordpress.com/rest/v1.1/sites/learnportugueseskype.wordpress.com/");
            //var client = new WordPressClient("http://public-api.wordpress.com/", "wp/v2/sites/learnportugueseskype.wordpress.com/");
            var client = new WordPressRestClient.WordPressClient("learnportugueseskype.wordpress.com/");

            client.Posts.GetAll();

            //foreach(var p in posts) {
            //    Console.WriteLine(p.Title);
            //}

            Console.ReadLine();
        }
    }
}
