using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hydrologist.models;



namespace AdminApp
{
    public partial class First : Form
    {
        HydrologistGuide guide;
        public First()
        {
            InitializeComponent();
            guide = new HydrologistGuide();
            guide.FillTestData(100);
            //guide.Save();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          //guide.Load();
        }

        private void Enter_Click(object sender, EventArgs e)
        {
            string log = Login.Text;
            string pas = Password.Text;
            var list = guide.Users.Where(x => x.Password == pas && x.Login == log).ToList();
            if(log == guide.admin.Login && pas == guide.admin.Password)
            {
                guide.CurrentUser = guide.admin;
                var f2 = new HomeForm(guide);
               
                f2.Show();
                this.Hide();
                
            }
            else if (list.Count == 0 )
                MessageBox.Show("Неверный логин и/или пароль", "Ошибка");
            else
            {   
                guide.CurrentUser = list[0];
                var f2 = new HomeForm(guide);
                f2.Show();
                this.Hide();
            }
        }

        private void Registration_Click(object sender, EventArgs e)
        {
            string log = Login.Text;
            string pas = Password.Text;
            var list = guide.Users.Where(x =>x.Login == log).ToList();
            if ((list.Count != 0 || log == guide.admin.Login))
                MessageBox.Show("Пользователь с таким логином уже существует", "Ошибка");
            else if (chek(Login) || chek(Password))
            {
                chek(Login);
                chek(Password);
                MessageBox.Show("Не все поля заполнены", "Ошибка");
            }
            else
            {
                guide.Users.Add(new CommonUser(log, pas));
                MessageBox.Show("Регистрация прошла успешно!");
                guide.Save();
            }
        }

        private bool chek(Control c)
        {
            bool res = string.IsNullOrWhiteSpace(c.Text);
            if (res)
                c.BackColor = Color.LightPink;
            else
                c.BackColor = Color.LightGreen;
            return res;
        }
        
    }
}
