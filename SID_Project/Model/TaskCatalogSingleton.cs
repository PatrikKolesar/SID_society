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

        private ObservableCollection<Task> taskCollection;

        private TaskCatalogSingleton()
        {
            taskCollection = new ObservableCollection<Task>()
            {
                new Task(1, "content1", "comment1", 1, "username1", DateTime.Now, "instrument1", "schedule1"),
                new Task(2, "content2", "comment2", 2, "username2", DateTime.Today, "instrument2", "schedule2"),
                new Task(3, "content3", "comment3", 3, "username3", DateTime.Now, "instrument3", "schedule3"),
                new Task(4, "content4", "comment4", 4, "username4", DateTime.Now, "instrument4", "schedule4"),
                new Task(5, "content5", "comment5", 5, "username5", DateTime.Now, "instrument5", "schedule5"),
                new Task(6, "content6", "comment6", 6, "username6", DateTime.Now, "instrument6", "schedule6"),
            };
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

        public void SaveTasks(ObservableCollection<Task> savedAsJsonObservableCollection)
        {
            PersistencyService.SaveTasksAsJsonAsync(savedAsJsonObservableCollection);
        }

        public async void LoadTasks()
        {
            await PersistencyService.LoadTasksFromJasonAsync();
        }
    }
}
