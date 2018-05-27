using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SID_Project.Persistency;

namespace SID_Project.Model
{
    class UserCatalogSingleton
    {
        private static UserCatalogSingleton instance;

        private ObservableCollection<User> UserCollection { get; set; }
        //private WebAPIAsyncLoad<Station> stationApiAsync;
        private UserCatalogSingleton()
        {
            UserCollection = LoadDataToObservableCollection();
        }
        // Load data to collection
        public ObservableCollection<User> LoadDataToObservableCollection()
        {
            WebAPIAsyncLoad<User> retrievedCatalog = new WebAPIAsyncLoad<User>();
            Task<ObservableCollection<User>> table = retrievedCatalog.Load("Users");
            ObservableCollection<User> collection = table.Result;
            return collection;
        }
        public static UserCatalogSingleton Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new UserCatalogSingleton();
                }
                return instance;

            }

        }

        public ObservableCollection<User> GetUsersCatalogSingleton()
        {
            return UserCollection;
        }

    }
}
