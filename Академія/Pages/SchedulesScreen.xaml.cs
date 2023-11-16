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
using Академія.Domain.Items;
using Академія.Navigator;

namespace Академія.Pages
{
    /// <summary>
    /// Логика взаимодействия для SchedulesScreen.xaml
    /// </summary>
    public partial class SchedulesScreen : UserControl
    {
        string user;
        ListItems items;

        public SchedulesScreen(string username)
        {
            InitializeComponent();
            LBUser.Content = username;
            user = username;
            items = new ListItems(DayOfWeek.Monday);
            items.AddItems(new MyItems("Math"));
            items.AddItems(new MyItems("Math"));
            items.AddItems(new MyItems("Math"));
            if (items.DayOfWeek == DayOfWeek.Monday)
            {
                LVMonday.ItemsSource = items.myItems;
            }
        }

        private void OnGotFocusHandler(object sender, RoutedEventArgs e)
        {
            Button tb = e.Source as Button;
            tb.Background = Brushes.White;
            tb.Foreground = Brushes.Black;
        }
        // Raised when Button losses focus.
        // Changes the color of the Button back to white.
        private void OnLostFocusHandler(object sender, RoutedEventArgs e)
        {

            Button tb = e.Source as Button;
            tb.Background = Brushes.Black;
            tb.Foreground = Brushes.White;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigatorObject.Switch(new DzAndLabScreen(user));
        }
    }
}
