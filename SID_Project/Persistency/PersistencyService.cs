using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;
using Windows.UI.Popups;
using Newtonsoft.Json;

namespace SID_Project.Persistency
{
    public class PersistencyService
    {
        private static string _taskFileName;
        private static string _tasksJsonString;

        public PersistencyService()
        {

        }

        public static async void SaveTasksAsJsonAsync(ObservableCollection<Model.Task> tasks)
        {
            _taskFileName = "EventAsJson.dat";
            _tasksJsonString = JsonConvert.SerializeObject(tasks);
            SerializeTasksFileAsync(_tasksJsonString, _taskFileName);
        }


        public static async Task<List<Task>> LoadTasksFromJasonAsync()
        {
            string tasksJasonString = await DeSerializeTasksFileAsync(_taskFileName);
            if (tasksJasonString != null)
            {
                return (List<Task>)JsonConvert.DeserializeObject(_tasksJsonString, typeof(List<Task>));
            }

            else
            {
                return null;
            }
        }



        public static async void SerializeTasksFileAsync(string tasksString, string fileName)
        {
            StorageFile localFile = await ApplicationData.Current.LocalFolder.CreateFileAsync(fileName, CreationCollisionOption.ReplaceExisting);

            await FileIO.WriteTextAsync(localFile, tasksString);

        }


        public static async Task<string> DeSerializeTasksFileAsync(String fileName)
        {
            try
            {
                StorageFile localFile = await ApplicationData.Current.LocalFolder.GetFileAsync(fileName);
                return await FileIO.ReadTextAsync(localFile);
            }

            catch (FileNotFoundException ex)
            {
                var messageDialog = new MessageDialog("File of tasks not found. Login for the first time?");
                await messageDialog.ShowAsync();
                return null;
            }
        }
    }
}
