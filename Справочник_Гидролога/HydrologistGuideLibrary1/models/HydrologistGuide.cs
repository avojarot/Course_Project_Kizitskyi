using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hydrologist.DAL;
using HydrologistGuideLibrary;

namespace Hydrologist.models
{//Справочник гидролога = админ + текущий пользователь + 
 // + коллекция водных объектов + коолекция пользователей +
 // + коллекция тестов
    [Serializable]
   public class HydrologistGuide
    {   public Admin admin { get; private set; }
        //Показывает Изменились ли данные
        public bool changed;
        public CommonUser CurrentUser { get;set; }
       public List<CommonUser> Users { get; private set; }
       public List<WaterObject> Articles { get; private set; }
       public List<Test> Tests { get; private set; }

        public HydrologistGuide()
        {
            Users = new List<CommonUser>();
            Articles = new List<WaterObject>();
            Tests = new List<Test>();
           
        }
        //Заполение иесиовыми данными
        public void FillTestData(int n)
        {   //Пользователи
            Users = new List<CommonUser>();
            for(int i=0; i<n; ++i)
            {
                Users.Add(new CommonUser($"User{i}", $"password{i}"));
            }

            //Статьи
            Articles = new List<WaterObject>();
           List<string> commonTypes = new List<string>
                {
                    "Река",
                    "Водохранилище",
                    "Озеро",
                    "Болото",
                    "Море",
                    "Пролив",
                    "Залив"
                };
            List<string> commonRegions = new List<string> {
             "Европа",
             "Азия",
             "Африка",
             "Северная Америка",
             "Южная Америка",
             "Австралия",
             "-" };
        
            for (int i = 0; i < n; ++i)
            {
                var temp = new WaterObject($"Water{i}", $"{commonTypes[(i/10)%commonTypes.Count]}", 
                    $"{commonRegions[(i)%commonRegions.Count]}",
                    i*10, i*100, $"Some editional data");
                temp.Image = DAO.LoadTestImage(temp.Type);
                Articles.Add(temp) ;
            }

            //тестами
            Tests = new List<Test>();
            const int NuberOfQuestions = 5;
            const int NuberOfOptions = 6;
            for (int i = 0; i < n; ++i)
            {
                var questions = new List<Question>();
                for (int j = 0; j < NuberOfQuestions; ++j)
                {
                    var options = new List<QuestionOp>();
                    for(int k = 0; k<NuberOfOptions; ++k)
                    {
                        options.Add(new QuestionOp($"Option{k}"));
                    }
                    questions.Add(new Question($"Text of question {j}", options[j % NuberOfOptions],
                        j, options));
                }

                Tests.Add(new Test($"Test{i}", questions));
            }
        }
        //Сохранение
        public void Save()
        {
            (new DAO(this)).Save();
            changed = false;
        }
        //Загрузка
        public void Load()
        { DAO d = new DAO(this);
            try
            {
                d.Load();
                admin = DAO.LoadAdmin();
                
            }
            catch (Exception)
            {
                d.IfSomethingWasWrong();
                d.Load();
                admin = DAO.LoadAdmin();
            }
            changed = false;
        }
    }
}
