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
using System.Windows.Shapes;

namespace Академія.Pages
{
    /// <summary>
    /// Логика взаимодействия для DZOption.xaml
    /// </summary>
    public partial class DZOption : Window
    {
        public DZOption(string name, string description)
        {
            InitializeComponent();
            TBName.Text = name;
            TBDescription.Text = description;
        }
    }
}
