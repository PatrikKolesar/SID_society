using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SID_Project
{
    public interface IWebAPIAsync<T>
    {
        Task<List<T>> Load();
    }
}