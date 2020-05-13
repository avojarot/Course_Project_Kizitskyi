using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Справочник_Гидролога.models
{
    class CommonUser : User
    {
       public int TotalMark { get; set; }

        public CommonUser(string login, string password)
        {
            Login = login;
            Password = password;
            TotalMark = 0;
        }
    }
}
