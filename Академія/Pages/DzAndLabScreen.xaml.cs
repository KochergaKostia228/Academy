using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Media;
using Академія.Domain.Task;
using Академія.Navigator;

namespace Академія.Pages
{

    public partial class DzAndLabScreen : UserControl
    {
        string user;
        ListTask taskList;

        public DzAndLabScreen(string username)
        {         
            InitializeComponent();
            LBUser.Content = username;
            user = username;
            taskList = new ListTask();
            taskList.AddTask(new Domain.Task.MyTask("rgvfced", "rvcfexd"));
            taskList.AddTask(new Domain.Task.MyTask("rgvfced", "rvcfexd"));
            taskList.AddTask(new Domain.Task.MyTask("rgvfced", "rvcfexd"));
            taskList.AddTask(new Domain.Task.MyTask("rgvfced", "rvcfexd"));
            taskList.AddTask(new Domain.Task.MyTask("rgvfced", "rvcfexd"));
            LVTasks.ItemsSource = taskList.tasks;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            NavigatorObject.Switch(new SchedulesScreen(user));
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

        private void StackPanel_MouseDown(object sender, RoutedEventArgs e)
        {
            var task = (sender as StackPanel).DataContext as MyTask;
            DZOption dZOption = new DZOption(task.Name,task.Description);
            dZOption.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            dZOption.ShowDialog();
        }
    }
}
