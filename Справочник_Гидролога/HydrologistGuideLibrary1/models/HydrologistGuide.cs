using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Справочник_Гидролога.DAL;

namespace Справочник_Гидролога.models
{
    [Serializable]
    class HydrologistGuide
    {
       public List<User> Users { get; private set; }
       public List<WaterObject> Articles { get; private set; }
       public List<Test> Tests { get; private set; }

        public HydrologistGuide()
        {
            Users = new List<User>();
            Articles = new List<WaterObject>();
            Tests = new List<Test>();
        }
        public void FillTestData(int n)
        {
            Users = new List<User>();
            for(int i=0; i<n; ++i)
            {
                Users.Add(new CommonUser($"User{i}", $"password{i}"));
            }


            Articles = new List<WaterObject>();
            for (int i = 0; i < n; ++i)
            {
                Articles.Add(new WaterObject($"Water{i}","River",$"Region{i}",
                    $"Regim{i}", i, $"Some editional data"));
            }


            Tests = new List<Test>();
            const int NuberOfQuestions = 5;
            const int NuberOfOptions = 6;
            for (int i = 0; i < n; ++i)
            {
                var q = new List<Question>();
                for (int j = 0; j < NuberOfQuestions; ++j)
                {
                    var o = new List<string>();
                    for(int k = 0; k<NuberOfOptions; ++k)
                    {
                        o.Add($"Option{k}");
                    }
                    q.Add(new Question($"Text{j}", o[j % NuberOfOptions],j, o));
                }

                Tests.Add(new Test($"Test{i}", q));
            }
        }
        public void Save()
        {
            (new DAO(this)).Save();
        }
        public void Load()
        {
            (new DAO(this)).Load();
        }
    }
}
