using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SID_Project.Model
{
    public class Task
    {
        private int _taskId;
        private string _content;
        private string _comment;
        private int _stationid;
        private string _username;
        private DateTimeOffset _date;
        private string _instrument;
        private string _schedule;

       

        public int TaskId { get => _taskId; set => _taskId = value; }
        public string Content { get => _content; set => _content = value; }
        public string Comment { get => _comment; set => _comment = value; }
        public int Stationtaskid { get => _stationid; set => _stationid = value; }
        public string Username { get => _username; set => _username = value; }
        public DateTimeOffset Date { get => _date; set => _date = value; }
        public string Instrument { get => _instrument; set => _instrument = value; }
        public string Schedule { get => _schedule; set => _schedule = value; }


        public Task(int taskId, string content, string comment, int stationtaskid, string username, DateTimeOffset date, string instrument, string schedule)
        {
            _taskId = taskId;
            _content = content;
            _comment = comment;
            _stationid = stationtaskid;
            _username = username;
            _date = date;
            _instrument = instrument;
            _schedule = schedule;
        }

        public Task()
        {
        }
    }
}
