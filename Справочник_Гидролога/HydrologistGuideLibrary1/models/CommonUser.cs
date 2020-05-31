using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hydrologist.models
{   //Пользователь = логин + пароль + количество очков
    [Serializable]
   public class CommonUser
    {
        public int TotalMark { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public CommonUser(string login, string password)
        {
            Login = login;
            Password = password;
            TotalMark = 0;
        }
    }
}
