using Playground.Core.AppConfig.Abstract;
using Playground.Core.Common.Exceptions;
using Playground.Core.Common.Helpers;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace Playground.Core.Data.Abstract
{
    public abstract class ApiRepositoryBase
    {
        private readonly IApplicationConfiguration ApplicationConfiguration;

        //Even though this implements IDisposable make this static. It will reuse sockets. If it's used with a using, it will create a new socket for each implementation, eventually exhausting the connection pool.
        //TODO - Inject this
        //https://stackoverflow.com/questions/55391284/should-i-use-the-using-statement-with-httpclient
        private static HttpClient Client = new HttpClient();

        public ApiRepositoryBase(IApplicationConfiguration applicationConfiguration)
        {
            ApplicationConfiguration = applicationConfiguration;
            Client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", ApplicationConfiguration.SpotifyApiConfiguration.oAuthToken);
        }

        protected async Task<T> ExecuteGet<T>(string url, string queryParameters)
        {
            HttpResponseMessage response = await Client.GetAsync(ApplicationConfiguration.SpotifyApiConfiguration.BaseUri + url + queryParameters);

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