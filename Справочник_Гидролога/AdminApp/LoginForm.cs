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
{   //Форма для вхoда и регистрации 
    public partial class LoginForm : Form
    {
       readonly HydrologistGuide guide;
        
        public LoginForm()
        {
            InitializeComponent();
            guide = new HydrologistGuide();
        }
        //Загрузка базы пользоватилей
        private void Form1_Load(object sender, EventArgs e)
        {   
            guide.Load();
            
        }

        private void Enter_Click(object sender, EventArgs e)
        {
            string login = LoginBox.Text;
            string password = PasswordBox.Text;
            var userList = guide.Users.Where(x => x.Password == password && x.Login == login).ToList();
            if(login == guide.admin.Login && password == guide.admin.Password)
            {
                guide.CurrentUser = guide.admin;
                var homeForm = new ArticleHomeForm(guide);
                homeForm.Show();
                this.Hide();
                
            }
            else if (userList.Count == 0 )
                MessageBox.Show("Неверный логин и/или пароль", "Ошибка");
            else
            {   
                guide.CurrentUser = userList[0];
                var homeForm = new ArticleHomeForm(guide);
                homeForm.Show();
                this.Hide();
            }
        }

        private void Registration_Click(object sender, EventArgs e)
        {
            string login = LoginBox.Text;
            string password = PasswordBox.Text;
            var userList = guide.Users.Where(x =>x.Login == login).ToList();
            if ((userList.Count != 0 || login == guide.admin.Login))
                MessageBox.Show("Пользователь с таким логином уже существует", "Ошибка");
            else if (Chek(LoginBox) || Chek(PasswordBox))
            {
                Chek(LoginBox);
                Chek(PasswordBox);
                MessageBox.Show("Не все поля заполнены", "Ошибка");
            }
            else
            {
                guide.Users.Add(new CommonUser(login, password));
                MessageBox.Show("Регистрация прошла успешно!");
                guide.Save();
            }
        }
        //Проверка вводимых данных
        private bool Chek(Control control)
        {
            bool res = string.IsNullOrWhiteSpace(control.Text);
            if (res)
                control.BackColor = Color.LightPink;
            else
                control.BackColor = Color.LightGreen;
            return res;
        }

       
    }
}
