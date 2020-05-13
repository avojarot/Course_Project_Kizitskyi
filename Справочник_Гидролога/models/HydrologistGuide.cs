using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Справочник_Гидролога.models
{
    class HydrologistGuide
    {
       public List<User> Users { get; private set; }
       public List<WaterObject> Articles { get; private set; }
       public List<Test> Tests { get; private set; }

        public HydrologistGuide()
        {
            Users = new List<User>();
            Articles = new List<WaterObject>();
            Tests = new List<Test>();
        }
    }
}
