using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace PoorMansRedditAPI.Models
{
    public class RedditDAL
    {
        private HttpClient GetHttpClient() 
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://www.reddit.com");
            return client;
        
        }

        public async Task<RedditObject> GetImageBySearchTerm() 
        {
            var client = GetHttpClient();
            var request = await client.GetAsync($"/r/aww/.json");
            //var request = await client.GetAsync($"{client.BaseAddress}");
            var response = await request.Content.ReadAsAsync<RedditObject>();

            return response;
        }
    }
}
