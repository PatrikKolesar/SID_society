using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Popups;
using Newtonsoft.Json;
using SID_Project.Persistency;

namespace SID_Project.Handler
{
    class WebAPIAsyncDelete<T> : IWebAPIAsyncDelete<T> where T : class
    {
        private string _serverURL = "http://localhost:64060";
        private string _apiPrefix = "api";
        private HttpClientHandler _httpClientHandler;
        private HttpClient _httpClient;

        public Task<ObservableCollection<T>> Delete(string table, int key)
        {
            _httpClientHandler = new HttpClientHandler() { UseDefaultCredentials = true };
            using (_httpClient = new HttpClient(_httpClientHandler))
            {
                _httpClient.BaseAddress = new Uri(_serverURL);
                _httpClient.DefaultRequestHeaders.Clear();
                _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                try
                {               
                    Task<HttpResponseMessage> rTask = _httpClient.DeleteAsync($"{_serverURL}/{_apiPrefix}/{table}/{key}");

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
