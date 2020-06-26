using React.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace React.Controllers
{
    [EnableCors(origins: "http://localhost:3000", headers: "*", methods: "*")]
    public class PostsController : ApiController
    {
        public List<Post> GetPosts()
        {
            return Posts.posts;
        }
        public Post getPost(int id)
        {
            Post post = Posts.posts.FirstOrDefault(x => x.id == id);
            return post;
        }
        [HttpPost]
        public IHttpActionResult postPost(Post post)
        {
            if (post == null)
                return BadRequest();
            Posts posts1 = new Posts();
            List<Post> posts = posts1.PostsPost(post);
            return Ok(posts);
        }
        [HttpDelete]
        public IHttpActionResult delet(int id)
        {
            Posts.posts.Remove(Posts.posts.FirstOrDefault(x => x.id == id));
            return Ok(Posts.posts);
        }

    }
}
