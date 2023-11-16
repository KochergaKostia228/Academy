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
using Академія.Navigator;

namespace Академія.Pages
{
    /// <summary>
    /// Логика взаимодействия для HomeTeacherScreen.xaml
    /// </summary>
    public partial class HomeTeacherScreen : UserControl
    {
        string user;

        public HomeTeacherScreen(string username)
        {
            InitializeComponent();
            string user = username;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigatorObject.Switch(new SchedulesScreen(user));
        }
    }
}
