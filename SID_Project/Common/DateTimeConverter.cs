using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SID_Project.Common
{
    public class DateTimeConverter
    {


        public DateTimeConverter()
        {

        }

        public DateTimeOffset DateToDate(DateTimeOffset InsertedDate)
        {


            return InsertedDate.Date;
        }

        public TimeSpan DateToTime(TimeSpan InsertedTime)
        {
            return InsertedTime;
        }



    }
}

