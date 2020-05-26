using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hydrologist.models
{
    [Serializable]
   public class CommonUser : User
    {
        public CommonUser(string login, string password)
        {
            Login = login;
            Password = password;
            TotalMark = 0;
        }
    }
}
