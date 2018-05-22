using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SID_Project
{
    public interface IWebAPIAsyncLoad<T>
    {
        Task<ObservableCollection<T>> Load(string table);
    }
}