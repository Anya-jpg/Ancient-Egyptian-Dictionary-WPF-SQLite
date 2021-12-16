using System.Windows;

namespace EgyptianDictionary_SQLite.Windows
{
    public partial class PharaohWindow : Window
    {
        public Pharaoh Pharaohs { get; private set; }

        public PharaohWindow(Pharaoh p)
        {
            InitializeComponent();
            Pharaohs = p;
            this.DataContext = Pharaohs;
        }

        private void Accept_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }
    }
}