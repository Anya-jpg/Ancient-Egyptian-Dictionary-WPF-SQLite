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
    public partial class PhonogramWindow : Window
    {
        public Phonogram Phonograms { get; private set; }

        public PhonogramWindow(Phonogram p)
        {
            InitializeComponent();
            Phonograms = p;
            this.DataContext = Phonograms;
        }

        private void Accept_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }
    }
}
