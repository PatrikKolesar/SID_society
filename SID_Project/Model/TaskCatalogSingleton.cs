using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SID_Project.Handler;
using SID_Project.Persistency;
using SID_Project.ViewModel;

namespace SID_Project.Model
{
    public class TaskCatalogSingleton
    {
        private static TaskCatalogSingleton instance;

        private ObservableCollection<Task> TaskCollection { get; set; }
        private WebAPIAsyncLoad<Task> taskApiAsync;
        private TaskCatalogSingleton()
        {
            TaskCollection = LoadDataToObservableCollection();
        }
        // Load data to collection
        public ObservableCollection<Task> LoadDataToObservableCollection()
        {
            WebAPIAsyncLoad<Task> retrievedCatalog = new WebAPIAsyncLoad<Task>();
            Task<ObservableCollection<Task>> table = retrievedCatalog.Load("Tasks");
            ObservableCollection<Task> collection = table.Result;
            return collection;
        }
        public async void DoDeleteTaskAsync(Task deletedTask)
        {
            int key = deletedTask.TaskId;
            WebAPIAsyncDelete<Task> deleteTask = new WebAPIAsyncDelete<Task>();
            await deleteTask.Delete("Tasks", key);
            TaskCollection.Remove(deletedTask);
        }

        public async void DoAddTask(Task addedTask)
        {
            WebAPIAsyncCreate<Task> createTask = new WebAPIAsyncCreate<Task>();
            TaskCollection.Add(addedTask);
            await createTask.Create(addedTask, "Tasks");
            
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
            return TaskCollection;
        }

        //   Add an event to the collection.





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
