using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SID_Project.Persistency;

namespace SID_Project.Model
{
    public class TaskCatalogSingleton
    {
        private static TaskCatalogSingleton instance;

        private ObservableCollection<Task> taskCollection { get; set; }

        private WebAPIAsync<Task> taskApiAsync;
        private TaskCatalogSingleton()
        {
            taskCollection = LoadDataToObservableCollection();
        }

        public ObservableCollection<Task> LoadDataToObservableCollection()
        {
            WebAPIAsync<Task> retrievedCatalog = new WebAPIAsync<Task>();
            Task<ObservableCollection<Task>> table = retrievedCatalog.Load("Tasks");
            ObservableCollection<Task> collection = table.Result;
            return collection;
        }

        public static TaskCatalogSingleton Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new TaskCatalogSingleton();
                }
                return instance;

            }

        }

        // If you need to retrieve the Event Catalog Singleton as a Observable Collecion

        public ObservableCollection<Task> GetTaskCatalogSingleton()
        {
            return taskCollection;
        }

        //   Add an event to the collection.

        public void DoAddTask(Task addedTask)
        {
            taskCollection.Add(addedTask);
        }

        public void DoDeleteTask(Task deletedTask)
        {
            taskCollection.Remove(deletedTask);
        }

        // Serialization Methods

    //    public void SaveTasks(ObservableCollection<Task> savedAsJsonObservableCollection)
    //    {
    //        PersistencyService.SaveTasksAsJsonAsync(savedAsJsonObservableCollection);
    //    }

    //    public async void LoadTasks()
    //    {
    //        await PersistencyService.LoadTasksFromJasonAsync();
    //    }
    }
}
