using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SID_Project.Model
{
    class User
    {
        private int _userid;
        private string _username;
        private string _password;

        public int UserId { get => _userid; set => _userid = value; }
        public string Username { get => _username; set => _username = value; }
        public string Password { get => _password; set => _password = value; }

        public User(int userId, string userName, string password)
        {
            _userid = userId;
            _username = userName;
            _password = password;
        }

        public User()
        {
        }
    }
}
