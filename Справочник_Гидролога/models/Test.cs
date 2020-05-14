using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Справочник_Гидролога.models
{
    [Serializable]
    class Test
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
