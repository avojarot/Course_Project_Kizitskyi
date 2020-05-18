﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hydrologist.DAL;

namespace Hydrologist.models
{
    [Serializable]
   public class HydrologistGuide
    {   public readonly Admin admin;
       public User CurrentUser { get;set; }
       public List<User> Users { get; private set; }
       public List<WaterObject> Articles { get; private set; }
       public List<Test> Tests { get; private set; }

        public HydrologistGuide()
        {
            Users = new List<User>();
            Articles = new List<WaterObject>();
            Tests = new List<Test>();
            admin = DAO.LoadAdmin();
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
                var temp = new WaterObject($"Water{i}", "River", $"Region{i}",
                    i*10, i*100, $"Some editional data");
                temp.Image = DAO.LoadTestImage();
                Articles.Add(temp) ;
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
