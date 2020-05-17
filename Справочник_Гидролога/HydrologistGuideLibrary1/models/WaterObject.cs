using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hydrologist.models
{
    [Serializable]
    public class WaterObject
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public  string Region { get;set; }
        public string Regime { get;set; }
        public   decimal Area { get;set; }
        public  string EditionalData { get;set; }
       public Bitmap Image { get;set; }
        public WaterObject() { }
        public WaterObject(WaterObject o2) : this(o2.Name, o2.Type, o2.Region,
            o2.Regime, o2.Area, o2.EditionalData)
        {
            this.Image = o2.Image;
        }
        public WaterObject(string name, string type, string region,
            string regim, decimal area, string ed ="")
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
