using MaterialDesignThemes.Wpf;
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

namespace Академія.Pages.AdminScreens
{
    /// <summary>
    /// Логика взаимодействия для SchedulesAdminScreen.xaml
    /// </summary>
    public partial class SchedulesAdminScreen : UserControl
    {
        MyItems myItems;
        List<TabItem> tabItems;
       

        
        public SchedulesAdminScreen()
        {
            InitializeComponent();
            tabItems = new List<TabItem>();
            foreach (string day in Enum.GetNames(typeof(DayOfWeek)))
            {
                CreateTabItem(day);
            }
            foreach (TabItem item in tabItems)
            {
                TCWeek.Items.Add(item);
            }
           

        }
        void AddItemToCurrentTab(MyItems myItems)
        {
            var curentTab = TCWeek.SelectedItem as TabItem;
            if (curentTab != null)
            {
                ListBox listBox = curentTab.Content as ListBox;
                ListBoxItem item = new ListBoxItem();
                item.Content = myItems.Name;
                item.Foreground = Brushes.Black;
                listBox.Items.Add(item);
            }
        }
        void CreateTabItem(string Name)
        {
            TabItem tabItem = new TabItem();
            tabItem.Foreground = Brushes.White;
            tabItem.Tag = Name;
            tabItem.Content = new ListBox();
            tabItems.Add(tabItem);
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

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            AddItemToCurrentTab(new MyItems("Test"));
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
           
           
        }
    }

}
