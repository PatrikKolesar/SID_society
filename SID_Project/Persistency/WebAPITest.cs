using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SID_Project.Persistency
{
    public class WebAPITest<T>
    {
        private IWebAPIAsync<T> _webAPI;

        public WebAPITest(IWebAPIAsync<T> webApi)
        {
            _webAPI = webApi;


        }
        public async Task RunAPITestLoad()
        {
            await LoadAndPrint();
        }

        private async Task LoadAndPrint()
        {
            Task<List<T>> loadTask = _webAPI.Load();
            await loadTask;
            PrintMultipleRecords(loadTask.Result);
        }

        private void PrintMultipleRecords(List<T> records)
        {

        }
    }
}
