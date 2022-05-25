using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant_AB1506
{
    class Users
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public Users(string username, string password)
        {
            UserName = username;
            Password = password;
        }

    }
}
