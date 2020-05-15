using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Справочник_Гидролога.models
{
    [Serializable]
    abstract class User
    {
        public string Login { get; set; }
        public string Password { get; set; }
    }
}
