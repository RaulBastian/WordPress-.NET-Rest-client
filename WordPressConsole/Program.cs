using System;

namespace WordPress {
    class Program {
        static void Main(string[] args) {
            var client = new WordPressRestClient.WordPressClient("learnportugueseskype.wordpress.com/");
            var response = client.Posts.GetAll();
            Console.ReadLine();
        }
    }
}
