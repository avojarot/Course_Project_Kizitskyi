using HydrologistGuideLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hydrologist.models
{
    [Serializable]
  public  class Question
    {
        QuestionOp correctAnswer;
       public static Random r = new Random();
        public string TextOfQuestion { get; set; }
        public List<QuestionOp> AnswerOptions { get; set; }
        public QuestionOp CorrectAnswer
        {
            get
            {
                return correctAnswer;
            }
            set
            {
                if (AnswerOptions.Contains(value))
                {
                    correctAnswer = value;
                }
            }
        }
        public int Points { get; set; }
        public Question(string text, QuestionOp cAns, int points,List<QuestionOp> options)
        {
            Points = points;
            TextOfQuestion = text;
            AnswerOptions = new List<QuestionOp>(options);
            if(!AnswerOptions.Contains(cAns))
               AnswerOptions.Add(cAns);
            CorrectAnswer = cAns;
        }
        public Question(Question q)
        {
            Points = q.Points;
            TextOfQuestion = new String(q.TextOfQuestion.ToCharArray());
            AnswerOptions = new List<QuestionOp>(q.AnswerOptions);
            CorrectAnswer = new QuestionOp(q.CorrectAnswer.Value);
        }
        public Question()
        {
            AnswerOptions = new List<QuestionOp>();
        }

        public void Ramdomize()
        {
            int selected = 0;
            for (int i = AnswerOptions.Count - 1; i >= 0; --i)
            {
                selected = r.Next(0,AnswerOptions.Count - 1);
                var temp = AnswerOptions[selected];
                AnswerOptions[selected] = AnswerOptions[i];
                AnswerOptions[i] = temp;

            }
        }

    }
}
