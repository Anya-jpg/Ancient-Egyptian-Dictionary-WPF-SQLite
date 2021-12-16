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

namespace EgyptianDictionary_SQLite.Windows
{
    /// <summary>
    /// Логика взаимодействия для GodsWindow.xaml
    /// </summary>
    public partial class GodsWindow : Window
    {
        public God Gods { get; private set; }

        public GodsWindow(God g)
        {
            InitializeComponent();
            Gods = g;
            this.DataContext = Gods;
        }

        private void Accept_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }
    }
}
