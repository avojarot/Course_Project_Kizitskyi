using HydrologistGuideLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hydrologist.models
{//Тест = Название + коллекция вопросов
    [Serializable]
   public  class Test
    {
        public string Name { get;set; }
        public int MaxMark
        {
            get
            {
                int res = 0;
                foreach(Question i in Questions)
                {
                    res += i.Points;
                }
                return res;
            }
        }
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
        //Перемешивает вопросы
       public void Ramdomize()
        {
            int selected = 0;
            for(int i = Questions.Count - 1; i>=0; --i)
            {
                selected = Question.r.Next(0, i); 
                var temp = Questions[selected];
                Questions[selected] = Questions[i];
                Questions[i] = temp;
                temp.Ramdomize();
            }
        }

    }
}
