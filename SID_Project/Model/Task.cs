using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SID_Project.Model
{
    class Task
    {
        public int TaskID { get; set; }
        public string Content { get; set; }
        public string Comment { get; set; }
        public int StationID { get; set; }
        public string Username { get; set; }
        public DateTime Date { get; set; }
        public string Instrument { get; set; }
        public string Schedule { get; set; }

        public Task (int taskId)
        {
            TaskID = taskId;
        }

        public override string ToString()
        {
            return string.Format("Task id {0}", TaskID);
        }
    }
}
