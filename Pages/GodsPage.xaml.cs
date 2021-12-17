using EgyptianDictionary_SQLite.Windows;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace EgyptianDictionary_SQLite.Pages
{
    /// <summary>
    /// Логика взаимодействия для GodsPage.xaml
    /// </summary>
    public partial class GodsPage : Page
    {
        ApplicationContext db;
        public GodsPage()
        {
            InitializeComponent();
            db = new ApplicationContext();
            db.Gods.Load();
            LViewGods.ItemsSource = db.Gods.ToList();
        }
        private void BSearh_Click(object sender, RoutedEventArgs e)
        {
            db = new ApplicationContext();
            db.Gods.Load();
            var modified = db.Gods.ToList();
            if (TBSearchGardiner.Text == "" && TBSearchName.Text == "" && TBSearchTransliteration.Text == "" && TBSearchUnicode.Text == "" && TBSearchWords.Text == "")
            {
                LViewGods.ItemsSource = db.Gods.ToList();
            }
            if (TBSearchGardiner.Text != "")
            {
                modified = modified.Where(p => !string.IsNullOrEmpty(p.GardinerCode) && p.GardinerCode.ToLower().Contains(TBSearchGardiner.Text.ToLower())).ToList();
            }
            if (TBSearchName.Text != "")
            {
                modified = modified.Where(p => !string.IsNullOrEmpty(p.Name) && p.Name.ToLower().Contains(TBSearchName.Text.ToLower())).ToList();
            }
            if (TBSearchTransliteration.Text != "")
            {
                modified = modified.Where(p => !string.IsNullOrEmpty(p.Transliteration) && p.Transliteration.ToLower().Contains(TBSearchTransliteration.Text.ToLower())).ToList();
            }
            if (TBSearchUnicode.Text != "")
            {
                modified = modified.Where(p => !string.IsNullOrEmpty(p.Hieroglyphic) && p.Hieroglyphic.ToLower().Contains(TBSearchUnicode.Text.ToLower())).ToList();
            }
            if (TBSearchWords.Text != "")
            {
                modified = modified.Where(p => !string.IsNullOrEmpty(p.Description) && p.Description.ToLower().Contains(TBSearchWords.Text.ToLower())
                || !string.IsNullOrEmpty(p.Type) && p.Type.ToLower().Contains(TBSearchWords.Text.ToLower())
                || !string.IsNullOrEmpty(p.View) && p.View.ToLower().Contains(TBSearchWords.Text.ToLower())).ToList();
            }
            LViewGods.ItemsSource = modified;
        }

        private void BEdit_Click(object sender, RoutedEventArgs e)
        {
            // если ни одного объекта не выделено, выходим
            if (LViewGods.SelectedItem == null) return;
            // получаем выделенный объект
            God god = LViewGods.SelectedItem as God;

            GodsWindow godWindow = new GodsWindow(new God
            {
                Id = god.Id,
                Name = god.Name,
                Description = god.Description,
                GardinerCode = god.GardinerCode,
                Hieroglyphic = god.Hieroglyphic,
                Transliteration = god.Transliteration,
                Type = god.Type,
                View = god.View
            });

            if (godWindow.ShowDialog() == true)
            {
                // получаем измененный объект
                god = db.Gods.Find(godWindow.Gods.Id);
                if (god != null)
                {
                    god.Name = godWindow.Gods.Name;
                    god.Hieroglyphic = godWindow.Gods.Hieroglyphic;
                    god.GardinerCode = godWindow.Gods.GardinerCode;
                    god.Transliteration = godWindow.Gods.Transliteration;
                    god.Type = godWindow.Gods.Type;
                    god.View = godWindow.Gods.View;
                    god.Description = godWindow.Gods.Description;
                    db.Entry(god).State = EntityState.Modified;
                    db.SaveChanges();
                }
            }

        }
    }

}
