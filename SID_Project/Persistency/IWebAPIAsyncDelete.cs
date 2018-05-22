using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SID_Project.Persistency
{
    public interface IWebAPIAsyncDelete<T>
    {
        Task<ObservableCollection<T>> Delete(string table, int key);
    }
}
