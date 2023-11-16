using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Академія.Domain.Admin;
using Академія.Domain.Student;
using Академія.Domain.Teacher;
using Академія.Navigator;

namespace Академія.Pages
{
    /// <summary>
    /// Логика взаимодействия для LoginScreen.xaml
    /// </summary>
    public partial class LoginScreen : UserControl
    {
        private ListStudent students = new ListStudent();
        private ListTeacher teacher = new ListTeacher();
        private Admin admin = new Admin();

        public LoginScreen()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            LBErrorPassword.Content = string.Empty;
            LBErrorStatus.Content = string.Empty;
            LBErrorUsername.Content = string.Empty;
            TBPassword.Foreground = Brushes.Black;
            TBUsername.Foreground = Brushes.Black;

            if (CBStatus.Text == "" || TBUsername.Text == "" || TBPassword.Password == "")
            {
                if (CBStatus.Text == "")
                {
                    LBErrorStatus.Content = "this field is empty";
                }
                if (TBUsername.Text == "")
                {
                    LBErrorUsername.Content = "this field is empty";
                    TBUsername.Foreground = Brushes.Red;
                }
                if (TBPassword.Password == "")
                {
                    LBErrorPassword.Content = "this field is empty";
                    TBPassword.Foreground = Brushes.Red;
                }
            }

            if (CBStatus.Text == "Student")
            {
                foreach (Student item in students.GetUsers())
                {
                    if (item.GetUsername() == TBUsername.Text && item.GetPassword() == TBPassword.Password)
                    {
                        NavigatorObject.Switch(new HomeStudentScreen(item.GetUsername()));
                    }
                    else
                    {
                        LBErrorPassword.Content = "incorrect username or password";
                        TBPassword.Foreground = Brushes.Red;
                        TBUsername.Foreground = Brushes.Red;
                    }
                }
            }
            else if (CBStatus.Text == "Teacher")
            {
                foreach (Teacher item in teacher.GetUsers())
                {
                    if (item.GetUsername() == TBUsername.Text && item.GetPassword() == TBPassword.Password)
                    {
                        NavigatorObject.Switch(new HomeTeacherScreen(item.GetUsername()));
                    }
                    else
                    {
                        LBErrorPassword.Content = "incorrect username, status or password";
                        TBPassword.Foreground = Brushes.Red;
                        TBUsername.Foreground = Brushes.Red;
                    }
                }
            }
            else if (CBStatus.Text == "Admin")
            {
                if (admin.GetUsername() == TBUsername.Text && admin.GetPassword() == TBPassword.Password)
                {
                    NavigatorObject.Switch(new HomeAdminScreen(admin.GetUsername()));
                }
                else
                {
                    LBErrorPassword.Content = "incorrect username, status or password";
                    TBPassword.Foreground = Brushes.Red;
                    TBUsername.Foreground = Brushes.Red;
                }
            }
        }

        
    }
}
