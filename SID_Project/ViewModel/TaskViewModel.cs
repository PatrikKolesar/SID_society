using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SID_Project.Common;
using SID_Project.Model;
using Task = SID_Project.Model.Task;

namespace SID_Project.ViewModel
{
    public class TaskViewModel : StationViewModel
    {
        // -------------------Fields-------------------------

        private TaskCatalogSingleton _taskCatalogSingleton = TaskCatalogSingleton.Instance;
        private Task _selectedTask;
        private ObservableCollection<Task> _tasksCollection;
       


        // ------------------ Properties --------------------



        public TaskCatalogSingleton TaskCatalogSingleton
        {
            get
            {
                return _taskCatalogSingleton;
            }
            set
            {
                _taskCatalogSingleton = value;
                OnPropertyChanged(nameof(_taskCatalogSingleton));
            }
        }

        public ObservableCollection<Task> TasksCollection
        {
            get
            {
                return _tasksCollection;
            }
            set
            {
                _tasksCollection = value;
                OnPropertyChanged(nameof(TasksCollection));
            }
        }

        public TaskHandlerClass TaskHandler { get; set; }

        public RelayCommand CreateTaskCommand { get; set; }

        public RelayCommand DeleteTaskCommand { get; set; }

        public Task SelectedTask
        {
            get
            {
                return _selectedTask;
            }
            set
            {
                _selectedTask = value;
                OnPropertyChanged(nameof(SelectedTask));
            }
        }

        // --------- Properties for Task ---------------------

        public int TaskId { get; set; }
        public string Content { get; set; }
        public string Comment { get; set; }
        public int StationTaskId { get; set; }
        public string Username { get; set; }
        public DateTimeOffset Date { get; set; }
        public string Instrument { get; set; }
        public string Schedule { get; set; }


        // ------------------ Constructor ---------------------

        public TaskViewModel()
        {
            TasksCollection = _taskCatalogSingleton.GetTaskCatalogSingleton();
            SelectedTask = new Task();
            TaskHandler = new TaskHandlerClass(this);
            CreateTaskCommand = new RelayCommand(TaskHandler.CreateTask);
            DeleteTaskCommand = new RelayCommand(TaskHandler.DeleteTask);
        }
    }
}
