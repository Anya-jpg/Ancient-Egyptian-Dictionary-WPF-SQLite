using EgyptianDictionary.Entities;
using EgyptianDictionary_SQLite.Windows;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace EgyptianDictionary_SQLite.Pages
{
    /// <summary>
    /// Логика взаимодействия для PharaonPage.xaml
    /// </summary>
    public partial class PharaohPage : Page
    {
        ApplicationContext db;
        public PharaohPage()
        {
            InitializeComponent();
            db = new ApplicationContext();
            db.Pharaohs.Load();
            LViewPharaohs.ItemsSource = db.Pharaohs.ToList();
        }
        private void BSearh_Click(object sender, RoutedEventArgs e)
        {
            db = new ApplicationContext();
            db.Pharaohs.Load();
            var modified = db.Pharaohs.ToList();
            if (TBSearchName.Text == "" && TBSearchName.Text == "" && TBSearchWords.Text == "")
            {
                LViewPharaohs.ItemsSource = db.Pharaohs.ToList();
            }
            if (TBSearchName.Text != "")
            {
                modified = modified.Where(p => !string.IsNullOrEmpty(p.Name) && p.Name.ToLower().Contains(TBSearchName.Text.ToLower())).ToList();
            }
            if (TBSearchWords.Text != "")
            {
                modified = modified.Where(p => !string.IsNullOrEmpty(p.BirthDescription) && p.BirthDescription.ToLower().Contains(TBSearchWords.Text.ToLower())
                || !string.IsNullOrEmpty(p.ThroneDescription) && p.ThroneDescription.ToLower().Contains(TBSearchWords.Text.ToLower())
                || !string.IsNullOrEmpty(p.Dynasty) && p.Dynasty.ToLower().Contains(TBSearchWords.Text.ToLower())).ToList();
            }
            LViewPharaohs.ItemsSource = modified;
        }

        private void BEdit_Click(object sender, RoutedEventArgs e)
        {
            // если ни одного объекта не выделено, выходим
            if (LViewPharaohs.SelectedItem == null) return;
            // получаем выделенный объект
            Pharaoh pharaoh = LViewPharaohs.SelectedItem as Pharaoh;

            PharaohWindow pharaohWindow = new PharaohWindow(new Pharaoh
            {
                Id = pharaoh.Id,
                Name = pharaoh.Name,
                BirthName = pharaoh.BirthName,
                BirthDescription = pharaoh.BirthDescription,
                ThroneName = pharaoh.ThroneName,
                ThroneDescription = pharaoh.ThroneDescription,
                Dynasty = pharaoh.Dynasty
            });

            if (pharaohWindow.ShowDialog() == true)
            {
                // получаем измененный объект
                pharaoh = db.Pharaohs.Find(pharaohWindow.Pharaohs.Id);
                if (pharaoh != null)
                {
                    pharaoh.Name = pharaohWindow.Pharaohs.Name;
                    pharaoh.BirthName = pharaohWindow.Pharaohs.BirthName;
                    pharaoh.BirthDescription = pharaohWindow.Pharaohs.BirthDescription;
                    pharaoh.ThroneName = pharaohWindow.Pharaohs.ThroneName;
                    pharaoh.ThroneDescription = pharaohWindow.Pharaohs.ThroneDescription;
                    pharaoh.Dynasty = pharaohWindow.Pharaohs.Dynasty;
                    db.Entry(pharaoh).State = EntityState.Modified;
                    db.SaveChanges();
                }
            }
        }

    }
}
