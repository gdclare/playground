using Common.Exceptions;
using Common.Helpers;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace Data.Abstract
{
    public abstract class ApiRepositoryBase
    {
        //TODO - Should come from some sort of config
        private Uri BaseUri => new Uri("https://api.spotify.com/");
        private string oAuthToken => "BQDVEHEg9czlFzR4fmlDRnUQ1aWslYhUa2IukPyDq746LFj1tGx_FnVUBSP1wgV1vxuFZh8VW_JM7QNz6r8-TtAnId0osqE_J2XPIU8I0hLMf16LD1L7pC0ozYGp5AwuQ4BgM6_YFUc";

        //Even though this implements IDisposable make this static. It will reuse sockets. If it's used with a using, it will create a new socket for each implementation, eventually exhausting the connection pool.

        //TODO - Inject this
        //https://stackoverflow.com/questions/55391284/should-i-use-the-using-statement-with-httpclient
        private static HttpClient Client = new HttpClient();

        public ApiRepositoryBase()
        {
            Client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", oAuthToken);
        }

        protected async Task<T> ExecuteGet<T>(string url, string queryParameters)
        {
            HttpResponseMessage response = await Client.GetAsync(BaseUri + url + queryParameters);

            if (!response.IsSuccessStatusCode)
            {
                throw new InvalidStatusCodeException(response.StatusCode.ToString());
            }

            var jsonString = await response.Content.ReadAsStringAsync();

            T model = JsonHelper.Deserialize<T>(jsonString);

            return model;
        }
    }
}
