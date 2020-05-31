using Hydrologist.models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Drawing;

namespace Hydrologist.DAL
{   //Объект доступа к данным
   public class DAO
    {
        readonly HydrologistGuide Guide;
        readonly string  filePath = "guide.bin";
        readonly static string directoryName = @"Pictures\";
       static readonly string AdminFile = "admin.txt";

        //Создание объекта
        public DAO(HydrologistGuide guide)
        {
            this.Guide = guide;
        }
        //Устарняет ошибки связанные с фалами
        public void IfSomethingWasWrong()
        {   //Не существует файла для загрузки
            if (!File.Exists(filePath))
            {
                File.Create(filePath);
            }
            //не существует файла администратора
            if (!File.Exists(AdminFile))
            {
                RecriateAdmin();
            }
            
        }

        private static void RecriateAdmin()
        {
            var file = File.Create(AdminFile);
            file.Dispose();
            using (StreamWriter writer = File.AppendText(AdminFile))
            {
                const string login = "bond";
                const string password = "007";
                writer.WriteLine(login);
                writer.WriteLine(password);
            }
        }
        //Загружает картинки
        public static Bitmap LoadTestImage(string s)
        {
            return new Bitmap(Path.GetFullPath(directoryName + s + ".jpg")); 
        }
        //Загружает администратора
        static public Admin LoadAdmin()
        {
            using (var rd = new StreamReader(AdminFile))
            {

                string tempLogin = rd.ReadLine();
                string tempPassword = rd.ReadLine();
                //Если файл администратора поменялся
                if (string.IsNullOrWhiteSpace(tempLogin) || string.IsNullOrWhiteSpace(tempPassword))
                {
                    rd.Dispose();
                    RecriateAdmin();
                    return LoadAdmin();
                    
                }
                var admin = new Admin(tempLogin,tempPassword);
                return admin;


            }    
        }
        //Сохраняет коллекцию в файл
        public void Save()
        {
            using (Stream stream = File.Create(filePath))
            {
                var serializer = new BinaryFormatter();
                serializer.Serialize(stream, Guide);
            }
        }
        //загружает коллекцию из файла
        public void Load()
        {
            using (Stream stream = File.OpenRead(filePath))
            {
                var serializer = new BinaryFormatter();
                HydrologistGuide gu = null;
                try
                {
                    gu = (HydrologistGuide)serializer.Deserialize(stream);
                }
                //Если что-то, или кто-то изменил в файл
                catch(Exception)
                {
                    stream.Dispose();
                    Save();
                    Load();
                    return;
                   
                }
                    Copy(gu.Articles, Guide.Articles);
                    Copy(gu.Tests, Guide.Tests);
                    Copy(gu.Users, Guide.Users);
            }
            //Копирование коллекций
            void Copy<T>(List<T> list1, List<T> list2)
            {
                list2.Clear();
                list2.AddRange(list1);
            }
        }
    }
}
