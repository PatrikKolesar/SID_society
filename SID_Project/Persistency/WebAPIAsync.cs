using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Popups;
using Newtonsoft.Json;

namespace SID_Project.Persistency
{
    public class WebAPIAsync<T> : IWebAPIAsync<T> where T : class
    {
        private string _serverURL = "http://localhost:64060";
        
        private string _apiPrefix = "api";
        //private string _apiID;
        private HttpClientHandler _httpClientHandler;
        private HttpClient _httpClient;

        //public WebAPIAsync(string serverURL, string apiPrefix, string apiID)
        //{
        //    _serverURL = serverURL;
        //    _apiID = apiID;
        //    _apiPrefix = apiPrefix;
        //    _httpClientHandler = new HttpClientHandler();
        //    _httpClientHandler.UseDefaultCredentials = true;
        //    _httpClient = new HttpClient(_httpClientHandler);
        //    _httpClient.BaseAddress = new Uri(_serverURL);
        //}


        public async Task<ObservableCollection<T>> Load(string table)
        {
            _httpClientHandler = new HttpClientHandler(){UseDefaultCredentials = true};
            using (_httpClient = new HttpClient(_httpClientHandler))
            {
                _httpClient.BaseAddress = new Uri(_serverURL);
                _httpClient.DefaultRequestHeaders.Clear();
                _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                try
                {
                    Task<HttpResponseMessage> rTask = _httpClient.GetAsync($"{_serverURL}/{_apiPrefix}/{table}");

                    if (rTask!= null)
                    {
                        if (rTask.Result.IsSuccessStatusCode)
                        {
                            var task1 = await rTask.Result.Content.ReadAsStringAsync();
                            var list = JsonConvert.DeserializeObject<ObservableCollection<T>>(task1);
                            return list;
                        }
                    }

                }
                catch (Exception ex)
                {
                    new MessageDialog(ex.Message).ShowAsync();
                }

                return null;
            }



        }

    }
}
