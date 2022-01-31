using Library.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class PostProcessor :IProcessor<PostModel>
    {
        public async Task<List<PostModel>> LoadAllPosts()
        {
            using (var client = new HttpClient())
            {
                List<PostModel> post = await client.GetAsync("https://jsonplaceholder.typicode.com/posts").Result.Content.ReadAsAsync<List<PostModel>>();

                return post;
            }


        }

        public async Task<string> SendPost(PostModel post)
        {
            using (var client = new HttpClient())
            {
                var newPostJson = JsonConvert.SerializeObject(post);
                var payload = new StringContent(newPostJson, Encoding.UTF8, "application/json");
                var result = await client.PostAsync("https://jsonplaceholder.typicode.com/posts", payload).Result.Content.ReadAsStringAsync();
                return result;
            }


        }

        public async Task<string> UpdatePost(PostModel post)
        {
            using (var client = new HttpClient())
            {
                var newPostJson = JsonConvert.SerializeObject(post);
                var payload = new StringContent(newPostJson, Encoding.UTF8, "application/json");
                var result = await client.PutAsync("https://jsonplaceholder.typicode.com/posts/" + post.Id, payload).Result.Content.ReadAsStringAsync();
                return result;
            }

        }

        public async Task<string> DeletePost(int id)
        {
            using (var client = new HttpClient())
            {
                var result = await client.DeleteAsync("https://jsonplaceholder.typicode.com/posts/"+id).Result.Content.ReadAsStringAsync();
                return result;
            }


        }

        public async Task<string> GetById(int id)
        {
            using (var client = new HttpClient())
            {
                var result = await client.GetAsync("https://jsonplaceholder.typicode.com/posts/" + id).Result.Content.ReadAsStringAsync();
                return result;
            }
        }

    }
}
