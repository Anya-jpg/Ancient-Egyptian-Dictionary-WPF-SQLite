using System;
using System.Collections.Generic;
using System.Data.Entity;
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
    public partial class TranslationWindow : Window
    {
        readonly private Translation _currentTranslation = null;

        ApplicationContext db;
        public TranslationWindow(Translation currentTranslation)
        {
            InitializeComponent();
            _currentTranslation = currentTranslation;
            LClient.Content = "Перевод для " + _currentTranslation.ClientName;
            TBOriginal.Text = _currentTranslation.OriginalText;
            TBTask.Text = _currentTranslation.Task;
        }

        private void BSend_Click(object sender, RoutedEventArgs e)
        {
            db = new ApplicationContext();
            db.Translations.Load();
            if (TBResult.Text == "")
            {
                MessageBox.Show("Введите перевод текста!");
                return;
            }
            _currentTranslation.Result = TBResult.Text;
            db.SaveChanges();
            MessageBox.Show("Перевод отправлен!");
            this.Close();
        }
        private void BMinimize_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }
        private void BClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}