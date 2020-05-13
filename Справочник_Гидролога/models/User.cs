using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Справочник_Гидролога.models
{
   abstract class User
    {
        protected string Login { get; set; }
        protected string Password { get; set; }
    }
}
