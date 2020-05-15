using Справочник_Гидролога.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Справочник_Гидролога.DAL
{
    class DAO
    {
        HydrologistGuide guide;
        string filePath = "guide.bin";
        public DAO(HydrologistGuide guide)
        {
            this.guide = guide;
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
