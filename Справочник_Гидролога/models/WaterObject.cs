using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Справочник_Гидролога.models
{
    class WaterObject
    {
        public string Name { get; private set; }
        public string Type { get; private set; }
        public  string Region { get; private set; }
        public string Regime { get; private set; }
        public   double Area { get; private set; }
        public  string EditionalData { get; private set; }

        public WaterObject(string name, string type, string region,
            string regim, double area, string ed ="")
        {
            Name = name;
            Type = type;
            Region = region;
            Regime = regim;
            Area = area;
            EditionalData = ed;

        }


    }
}
