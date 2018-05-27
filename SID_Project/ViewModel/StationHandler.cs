using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Popups;
using SID_Project.Common;
using SID_Project.Model;
using Task = SID_Project.Model.Task;

namespace SID_Project.ViewModel
{
    public class StationHandlerClass
    {
        private StationViewModel _stationViewModel;

        private DateTimeConverter _dateTimeConverter;

        //public Action CreatedStation { get; set; }

        public StationHandlerClass(StationViewModel StationViewModel)
        {
            _stationViewModel = StationViewModel;
        }


       //public void CreateStation()
       // {
       //     _dateTimeConverter = new DateTimeConverter();

       //// DateTimeOffset changedDate = _dateTimeConverter.DateToDate(_stationViewModel.Date);



       // var createdStation = new Station(_stationViewModel.StationId, _stationViewModel.StationName);


       // _stationViewModel.StationCatalogSingleton.DoAddStation(createdStation);
       //     //_taskViewModel.TaskCatalogSingleton.SaveTasks(_taskViewModel.TasksCollection);

       // }

    //public async void DeleteStation()
    //{
    //    if (_stationViewModel.SelectedStation == null)
    //    {
    //        var messageDialog = new MessageDialog("You need to select a Task in order to delete it");
    //        await messageDialog.ShowAsync();
    //    }

    //    else
    //    {
    //        _stationViewModel.StationCatalogSingleton.DoDeleteStationAsync(_stationViewModel.SelectedStation);
    //    }

    //}


}
}
