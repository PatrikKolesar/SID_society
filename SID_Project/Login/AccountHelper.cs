using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Windows.Storage;
using SID_Project.Model;

namespace SID_Project.Login
{
    public static class AccountHelper
    {

        public static bool ValidateAccountCredentials(string username)
        {

            if (string.IsNullOrEmpty(username))
            {
                return false;
            }

            if (!string.Equals(username, "Patrik"))
            { 
                return false;
            }

            return true;
        }

    }
}
