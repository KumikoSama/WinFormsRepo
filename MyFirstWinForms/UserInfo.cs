using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstWinForms
{
    public class UserInfo
    {
        public string firstname, lastname, gender, username, password, birthday;        
        public UserInfo(string firstname, string lastname, string gender, string username, string password, string birthday)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.gender = gender;
            this.username = username;
            this.password = password;
            this.birthday = birthday;
        }
    }
}
