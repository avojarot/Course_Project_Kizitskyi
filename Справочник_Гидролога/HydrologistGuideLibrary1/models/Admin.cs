using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hydrologist.models
{[Serializable]
    //То же самое что и пользователь, но с раширеным фунционалом
   public class Admin : CommonUser
    {
        public Admin(string login, string password) : base(login,password) { }
        
    }
}

