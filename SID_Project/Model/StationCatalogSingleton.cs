using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SID_Project.Handler;
using SID_Project.Persistency;

namespace SID_Project.Model
{
    public class StationCatalogSingleton
    {
        private static StationCatalogSingleton instances;

        private static ObservableCollection<Station> StationCollection { get; set; }
        private WebAPIAsyncLoad<Station> stationApiAsync;
        private StationCatalogSingleton()
        {
            StationCollection = LoadDataToObservableCollection();
        }
        // Load data to collection
        public ObservableCollection<Station> LoadDataToObservableCollection()
        {
            WebAPIAsyncLoad<Station> retrievedCatalogs = new WebAPIAsyncLoad<Station>();
            Task<ObservableCollection<Station>> tables = retrievedCatalogs.Load("Stations");
            ObservableCollection<Station> collections = tables.Result;
            return collections;
        }
        //public async void DoDeleteStationAsync(Station deletedStation)
        //{
        //    int key = deletedStation.StationId;
        //    WebAPIAsyncDelete<Station> deleteStation = new WebAPIAsyncDelete<Station>();
        //    await deleteStation.Delete("Stations", key);
        //    StationCollection.Remove(deletedStation);
        //}

        //public void DoAddStation(Station addedStation)
        //{
        //    WebAPIAsyncCreate<Station> createStation = new WebAPIAsyncCreate<Station>();
        //    createStation.Create(addedStation, "Stations");
        //    StationCollection.Add(addedStation);
        //}
        public static StationCatalogSingleton Instances
        {
            get
            {
                if (instances == null)
                {
                    instances = new StationCatalogSingleton();
                }
                return instances;

            }

        }

        public ObservableCollection<Station> GetStationsCatalogSingleton()
        {
            return StationCollection;
        }

    }
}