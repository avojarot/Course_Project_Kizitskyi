using HydrologistGuideLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hydrologist.models
{
    [Serializable]
   public  class Test
    {
        public string Name { get;set; }
        public List<Question> Questions { get; private set; }

        public Test(string name, List<Question> questions)
        {
            Name = name;
            Questions = questions;
        }

        public Test(Test t)
        {
            Name = new String(t.Name.ToCharArray());
            Questions = new List<Question>(t.Questions);
        }
       public Test()
        {
            Questions = new List<Question>();
        }

    }
}
