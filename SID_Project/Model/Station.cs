using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SID_Project.Model
{
    public class Station
    {
        private int _stationId;
        private string _stationname;
        

        public int StationId { get => _stationId; set => _stationId = value; }
        public string StationName { get => _stationname; set => _stationname = value; }
        

        public Station(int stationId, string stationName)
        {
            _stationId = stationId;
            _stationname = stationName;
           
        }

        public Station()
        {
        }
    }
}
