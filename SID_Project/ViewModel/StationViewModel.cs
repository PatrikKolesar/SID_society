using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SID_Project.Common;
using SID_Project.Model;

namespace SID_Project.ViewModel
{
    public class StationViewModel : NotifyPropertyChanged
    {
        // -------------------Fields-------------------------

        private StationCatalogSingleton _stationCatalogSingleton = StationCatalogSingleton.Instances;
        private Station _selectedStation;
        private ObservableCollection<Station> _stationsCollection;



        // ------------------ Properties --------------------



        public StationCatalogSingleton StationCatalogSingleton
        {
            get
            {
                return _stationCatalogSingleton;
            }
            set
            {
                _stationCatalogSingleton = value;
                OnPropertyChanged(nameof(_stationCatalogSingleton));
            }
        }

        public ObservableCollection<Station> StationsCollection
        {
            get
            {
                return _stationsCollection;
            }
            set
            {
                _stationsCollection = value;
                OnPropertyChanged(nameof(StationsCollection));
            }
        }


        public Model.Station SelectedStation
        {
            get
            {
                return _selectedStation;
            }
            set
            {
                _selectedStation = value;

                OnPropertyChanged(nameof(SelectedStation));
            }
        }

        // --------- Properties for Station ---------------------

        public int StationId { get; set; }
        public string StationName { get; set; }
        



        // ------------------ Constructor ---------------------

        public StationViewModel()
        {
            StationsCollection = _stationCatalogSingleton.GetStationsCatalogSingleton();
            SelectedStation = new Model.Station();
            }
        
    }
}
