using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Popups;
using SID_Project.Common;
using Task = SID_Project.Model.Task;

namespace SID_Project.ViewModel
{
    public class TaskHandlerClass
    {
        private TaskViewModel _taskViewModel;

        private DateTimeConverter _dateTimeConverter;

        public Action CreatedEvent { get; set; }

        public TaskHandlerClass(TaskViewModel TaskViewModel)
        {
            _taskViewModel = TaskViewModel;
        }


        public void CreateTask()
        {
            _dateTimeConverter = new DateTimeConverter();

            DateTimeOffset changedDate = _dateTimeConverter.DateToDate(_taskViewModel.Date);



            Task createdTask = new Task(_taskViewModel.TaskId, _taskViewModel.Content, _taskViewModel.Comment, _taskViewModel.StationId, _taskViewModel.Username, changedDate, _taskViewModel.Instrument, _taskViewModel.Schedule);
               
                
            _taskViewModel.TaskCatalogSingleton.DoAddTask(createdTask);
            //_taskViewModel.TaskCatalogSingleton.SaveTasks(_taskViewModel.TasksCollection);

        }

        public async void DeleteTask()
        {
            if (_taskViewModel.SelectedTask == null)
            {
                var messageDialog = new MessageDialog("You need to select a Task in order to delete it");
                await messageDialog.ShowAsync();
            }

            else
            {
                _taskViewModel.TaskCatalogSingleton.DoDeleteTaskAsync(_taskViewModel.SelectedTask);
            }

        }


    }
}

