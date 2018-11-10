# WordPress

Simple client to retrive blog posts from a wordpress web page

## How to use:
```
var client = new WordPressRestClient.WordPressClient("learnportugueseskype.wordpress.com/");
var response = await client.Posts.GetAll();
```
