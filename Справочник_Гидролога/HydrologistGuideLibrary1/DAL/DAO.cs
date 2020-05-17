using Hydrologist.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Drawing;

namespace Hydrologist.DAL
{
    class DAO
    {
        HydrologistGuide guide;
      readonly string  filePath = "guide.bin";
       static readonly string testImage = "river.jpg";

        public DAO(HydrologistGuide guide)
        {
            this.guide = guide;
        }


        public static Bitmap LoadTestImage()
        {
            return new Bitmap(Path.GetFullPath(testImage));
        }
        static public Admin LoadAdmin()
        {
            var admin = new Admin();
            using (var rd = new StreamReader(Admin.AdminFile))
            {

                admin.Login = rd.ReadLine();
                admin.Password = rd.ReadLine();

                
            }
            return admin;
        }
        public void Save()
        {
            using (Stream stream = File.Create(filePath))
            {
                var serializer = new BinaryFormatter();
                serializer.Serialize(stream, guide);
            }
        }
        public void Load()
        {
            using (Stream stream = File.OpenRead(filePath))
            {
                var serializer = new BinaryFormatter();
                HydrologistGuide gu = (HydrologistGuide)serializer.Deserialize(stream);
                Copy(gu.Articles, guide.Articles);
                Copy(gu.Tests, guide.Tests);
                Copy(gu.Users, guide.Users);
            }

            void Copy<T>(List<T> list1, List<T> list2)
            {
                list2.Clear();
                list2.AddRange(list2);
            }
        }
    }
}
