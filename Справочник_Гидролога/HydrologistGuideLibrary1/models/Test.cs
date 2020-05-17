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
        public string Name { get; private set; }
        public List<Question> Questions { get; private set; }

        public Test(string name, List<Question> questions)
        {
            Name = name;
            Questions = questions;
        }



    }
}
