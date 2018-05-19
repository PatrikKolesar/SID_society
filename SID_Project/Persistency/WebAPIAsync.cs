using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace SID_Project.Persistency
{
    public class WebAPIAsync<T> : IWebAPIAsync<T> where T : class
    {
        private string _serverURL;
        private string _apiPrefix;
        private string _apiID;
        private HttpClientHandler _httpClientHandler;
        private HttpClient _httpClient;
        private IWebAPIAsync<T> _webApiAsyncImplementation;

        public WebAPIAsync(string serverURL, string apiPrefix, string apiID)
        {
            _serverURL = serverURL;
            _apiID = apiID;
            _apiPrefix = apiPrefix;
            _httpClientHandler = new HttpClientHandler();
            _httpClientHandler.UseDefaultCredentials = true;
            _httpClient = new HttpClient(_httpClientHandler);
            _httpClient.BaseAddress = new Uri(_serverURL);
        }


        public async Task<List<T>> Load()
        {
            using (_httpClient)
            {
                _httpClient.BaseAddress = new Uri(_serverURL);
                _httpClient.DefaultRequestHeaders.Clear();
                _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                Task<HttpResponseMessage> rTask = _httpClient.GetAsync("api/Tasks");

                await rTask;

                if (rTask.Result.IsSuccessStatusCode)
                {

                    var cTask = rTask.Result.Content.ReadAsStringAsync();
                    

                }

                return null;
            }

        }

    }
}
