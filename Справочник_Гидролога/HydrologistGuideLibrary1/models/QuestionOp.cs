using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HydrologistGuideLibrary
{
    [Serializable]
    public class QuestionOp
    {
        public string Value { get; set;}

        public QuestionOp(string name)
        {
            Value = name;
        }
        public override bool Equals(object o)
        {   if (!(o is QuestionOp))
                return false;
            return ((QuestionOp)o).Value == Value;
        }
    }
}
