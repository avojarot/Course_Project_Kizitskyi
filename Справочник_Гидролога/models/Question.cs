using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Справочник_Гидролога.models
{
    [Serializable]
    class Question
    {
        string correctAnswer;
        public string TextOfQuestion { get; private set; }
        public List<string> AnswerOptions { get; private set; }
        public string CorrectAnswer
        {
            get
            {
                return correctAnswer;
            }
            private set
            {
                if (AnswerOptions.Contains(value))
                {
                    correctAnswer = value;
                }
            }
        }
        public int Points { get; private set; }
        public Question(string text, string cAns, int points,List<string> options)
        {
            Points = points;
            TextOfQuestion = text;
            AnswerOptions = options;
            if(!AnswerOptions.Contains(cAns))
               AnswerOptions.Add(cAns);
            CorrectAnswer = cAns;
        }

    }
}
