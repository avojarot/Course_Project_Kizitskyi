using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hydrologist.models
{
    [Serializable]
    public abstract class User
    {
        public int TotalMark { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
    }
}
