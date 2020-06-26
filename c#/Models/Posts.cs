using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace React.Models
{
    public class Posts
    {
        public static List<Post> posts;
        static Posts()
        {
            posts = new List<Post>()
            {
                new Post()
                {
                    userId = 1,
                    id = 1,
                    title = "sunt aut facere repellat provident occaecati excepturi optio reprehenderit",
                    body = "quia et suscipit\nsuscipit recusandae consequuntur expedita et cum\nreprehenderit molestiae ut ut quas totam\nnostrum rerum est autem sunt rem eveniet architecto"
                },
                  new Post()
                {
                    userId = 1,
                    id = 2,
                    title = "qui est esse",
                    body = "reprehenderit molestiae ut ut quas totam\nnostrum rerum est autem sunt rem eveniet architecto"
                },  new Post()
                {
                    userId = 1,
                    id = 3,
                    title = "sunt aut facere repellat ",
                    body = "provident occaecati excepturi optio reprehenderit quia et suscipit\nsuscipit recusandae consequuntur expedita et cum\nreprehenderit molestiae ut ut quas totam\nnostrum rerum est autem sunt rem eveniet architecto"
                },  new Post()
                {
                    userId = 2,
                    id = 4,
                    title = "facere repellat provident occaecati excepturi optio reprehenderit",
                    body = "quia et suscipit reprehenderit molestiae ut ut quas totam\nnostrum rerum est autem sunt rem eveniet architecto"
                },
                  new Post()
                {
                    userId = 1,
                    id = 5,
                    title = "sunt aut facere repellat provident occaecati excepturi optio reprehenderit",
                    body = "quia et suscipit\nsuscipit recusandae consequuntur expedita et cum\nreprehenderit molestiae ut ut quas totam\nnostrum rerum est autem sunt rem eveniet architecto"
                },new Post()
                {
                    userId = 1,
                    id =6,
                    title = "sunt aut facere repellat provident occaecati excepturi optio reprehenderit",
                    body = "quia et suscipit\nsuscipit recusandae consequuntur expedita et cum\nreprehenderit molestiae ut ut quas totam\nnostrum rerum est autem sunt rem eveniet architecto"
                },new Post()
                {
                    userId = 1,
                    id = 7,
                    title = "sunt aut facere repellat provident occaecati excepturi optio reprehenderit",
                    body = "quia et suscipit\nsuscipit recusandae consequuntur expedita et cum\nreprehenderit molestiae ut ut quas totam\nnostrum rerum est autem sunt rem eveniet architecto"
                },new Post()
                {
                    userId = 1,
                    id = 8,
                    title = "sunt aut facere repellat provident occaecati excepturi optio reprehenderit",
                    body = "quia et suscipit\nsuscipit recusandae consequuntur expedita et cum\nreprehenderit molestiae ut ut quas totam\nnostrum rerum est autem sunt rem eveniet architecto"
                },new Post()
                {
                    userId = 1,
                    id = 9,
                    title = "sunt aut facere repellat provident occaecati excepturi optio reprehenderit",
                    body = "quia et suscipit\nsuscipit recusandae consequuntur expedita et cum\nreprehenderit molestiae ut ut quas totam\nnostrum rerum est autem sunt rem eveniet architecto"
                }
            };

        }
        
      public List<Post> PostsPost(Post post)
        {
            post.id = posts.Last().id + 1;
            posts.Add(post);
            return posts;
        }
    }
}