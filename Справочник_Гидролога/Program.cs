using Справочник_Гидролога.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Справочник_Гидролога
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var guaid = new HydrologistGuide();
            guaid.FillTestData(100);
            Console.WriteLine(guaid.Articles[99].Type);
            Console.WriteLine(guaid.Users[8].Login);
            Console.WriteLine(guaid.Tests[0].Questions[3].CorrectAnswer);
            Console.ReadLine();
           // Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
        }
    }
}
