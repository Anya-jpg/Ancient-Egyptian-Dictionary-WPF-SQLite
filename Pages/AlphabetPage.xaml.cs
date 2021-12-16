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
    /// Логика взаимодействия для AlphabetPage.xaml
    /// </summary>
    public partial class PhonogramPage : Page
    {
        ApplicationContext db;
        public PhonogramPage()
        {
            InitializeComponent();
            db = new ApplicationContext();
            db.Phonograms.Load();
            LViewPhonogram.ItemsSource = db.Phonograms.Where(p => p.Type == "alphabet").ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            db = new ApplicationContext();
            db.Phonograms.Load();
            int index = int.Parse(((Button)e.Source).Uid);

            GridCursor.Margin = new Thickness(40 + (284 * index), 0, 0, 0);

            switch (index)
            {
                case 0:
                    LViewPhonogram.ItemsSource = db.Phonograms.Where(p => p.Type == "alphabet").ToList();
                    break;
                case 1:
                    LViewPhonogram.ItemsSource = db.Phonograms.Where(p => p.Type == "biliteral").ToList();
                    break;
                case 2:
                    LViewPhonogram.ItemsSource = db.Phonograms.Where(p => p.Type == "triliteral").ToList();
                    break;
            }
        }
        private void BSearh_Click(object sender, RoutedEventArgs e)
        {
            db = new ApplicationContext();
            db.Phonograms.Load();
            var _phonograms = db.Phonograms.ToList();

            if (TBSearchGardiner.Text == "" && TBSearchTransliteration.Text == "" && TBSearchUnicode.Text == "")
            {
                _phonograms = db.Phonograms.ToList();
            }
            if (TBSearchGardiner.Text != "")
            {
                _phonograms = _phonograms.Where(p => !string.IsNullOrEmpty(p.GardinerCode) && p.GardinerCode.ToLower().Contains(TBSearchGardiner.Text.ToLower())).ToList();
            }
            if (TBSearchTransliteration.Text != "")
            {
                _phonograms = _phonograms.Where(p => !string.IsNullOrEmpty(p.Transliteration) && p.Transliteration.ToLower().Contains(TBSearchTransliteration.Text.ToLower())).ToList();
            }
            if (TBSearchUnicode.Text != "")
            {
                _phonograms = _phonograms.Where(p => !string.IsNullOrEmpty(p.Glyph) && p.Glyph.ToLower().Contains(TBSearchUnicode.Text.ToLower())).ToList();
            }
            LViewPhonogram.ItemsSource = _phonograms;

        }

        private void BEdit_Click(object sender, RoutedEventArgs e)
        {
            // если ни одного объекта не выделено, выходим
            if (LViewPhonogram.SelectedItem == null) return;
            // получаем выделенный объект
            Phonogram phonogram = LViewPhonogram.SelectedItem as Phonogram;

            PhonogramWindow phonogramWindow = new PhonogramWindow(new Phonogram
            {
                Id = phonogram.Id,
                Glyph = phonogram.Glyph,
                GardinerCode = phonogram.GardinerCode,
                Transliteration = phonogram.Transliteration,
                ManuelCotage = phonogram.ManuelCotage
            });

            if (phonogramWindow.ShowDialog() == true)
            {
                // получаем измененный объект
                phonogram = db.Phonograms.Find(phonogramWindow.Phonograms.Id);
                if (phonogram != null)
                {
                    phonogram.Glyph = phonogramWindow.Phonograms.Glyph;
                    phonogram.GardinerCode = phonogramWindow.Phonograms.GardinerCode;
                    phonogram.Transliteration = phonogramWindow.Phonograms.Transliteration;
                    phonogram.ManuelCotage = phonogramWindow.Phonograms.ManuelCotage;
                    db.Entry(phonogram).State = EntityState.Modified;
                    db.SaveChanges();
                }
            }

        }

    }
}
