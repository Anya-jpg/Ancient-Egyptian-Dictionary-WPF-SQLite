using EgyptianDictionary_SQLite.Windows;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace EgyptianDictionary_SQLite.Pages
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class DictionaryPage : Page
    {
        ApplicationContext db;
        public DictionaryPage()
        {
            InitializeComponent();
            db = new ApplicationContext();
            db.Dictionaries.Load();
            LViewDictionary.ItemsSource = db.Dictionaries.Where(p => p.Categoria == "A").ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            db = new ApplicationContext();
            db.Dictionaries.Load();
            int index = int.Parse(((Button)e.Source).Uid);

            GridCursor.Margin = new Thickness(15 + (32 * index), 0, 0, 0);

            switch (index)
            {
                case 0:
                    LViewDictionary.ItemsSource = db.Dictionaries.Where(p => p.Categoria == "A").ToList();
                    TBCategoria.Text = "Категория A: Мужчина и его занятия";
                    break;
                case 1:
                    LViewDictionary.ItemsSource = db.Dictionaries.Where(p => p.Categoria == "B").ToList();
                    TBCategoria.Text = "Категория B: Женщина и её занятия";
                    break;
                case 2:
                    LViewDictionary.ItemsSource = db.Dictionaries.Where(p => p.Categoria == "C").ToList();
                    TBCategoria.Text = "Категория C: Антропоморфные божества";
                    break;
                case 3:
                    LViewDictionary.ItemsSource = db.Dictionaries.Where(p => p.Categoria == "D").ToList();
                    TBCategoria.Text = "Категория D: Части тела человека";
                    break;
                case 4:
                    LViewDictionary.ItemsSource = db.Dictionaries.Where(p => p.Categoria == "E").ToList();
                    TBCategoria.Text = "Категория E: Млекопитающие";
                    break;
                case 5:
                    LViewDictionary.ItemsSource = db.Dictionaries.Where(p => p.Categoria == "F").ToList();
                    TBCategoria.Text = "Категория F: Части тела млекопитающих";
                    break;
                case 6:
                    LViewDictionary.ItemsSource = db.Dictionaries.Where(p => p.Categoria == "G").ToList();
                    TBCategoria.Text = "Категория G: Птицы";
                    break;
                case 7:
                    LViewDictionary.ItemsSource = db.Dictionaries.Where(p => p.Categoria == "H").ToList();
                    TBCategoria.Text = "Категория H: Части тела птиц";
                    break;
                case 8:
                    LViewDictionary.ItemsSource = db.Dictionaries.Where(p => p.Categoria == "I").ToList();
                    TBCategoria.Text = "Категория I: Амфибии и пресмыкающиеся";
                    break;
                case 9:
                    LViewDictionary.ItemsSource = db.Dictionaries.Where(p => p.Categoria == "K").ToList();
                    TBCategoria.Text = "Категория K: Амфибии и пресмыкающиеся";
                    break;
                case 10:
                    LViewDictionary.ItemsSource = db.Dictionaries.Where(p => p.Categoria == "L").ToList();
                    TBCategoria.Text = "Категория L: Беспозвоночные";
                    break;
                case 11:
                    LViewDictionary.ItemsSource = db.Dictionaries.Where(p => p.Categoria == "M").ToList();
                    TBCategoria.Text = "Категория M: Деревья и растения";
                    break;
                case 12:
                    LViewDictionary.ItemsSource = db.Dictionaries.Where(p => p.Categoria == "N").ToList();
                    TBCategoria.Text = "Категория N: Небо, земля, вода";
                    break;
                case 13:
                    LViewDictionary.ItemsSource = db.Dictionaries.Where(p => p.Categoria == "NU").ToList();
                    TBCategoria.Text = "Категория NU: Верхний Нил";
                    break;
                case 14:
                    LViewDictionary.ItemsSource = db.Dictionaries.Where(p => p.Categoria == "NL").ToList();
                    TBCategoria.Text = "Категория NL: Нижний Нил";
                    break;
                case 15:
                    LViewDictionary.ItemsSource = db.Dictionaries.Where(p => p.Categoria == "O").ToList();
                    TBCategoria.Text = "Категория O: Здания и их части";
                    break;
                case 16:
                    LViewDictionary.ItemsSource = db.Dictionaries.Where(p => p.Categoria == "P").ToList();
                    TBCategoria.Text = "Категория P: Суда и части судов";
                    break;
                case 17:
                    LViewDictionary.ItemsSource = db.Dictionaries.Where(p => p.Categoria == "Q").ToList();
                    TBCategoria.Text = "Категория Q: Домашняя и походная утварь";
                    break;
                case 18:
                    LViewDictionary.ItemsSource = db.Dictionaries.Where(p => p.Categoria == "R").ToList();
                    TBCategoria.Text = "Категория R: Храмовая утварь и священные эмблемы";
                    break;
                case 19:
                    LViewDictionary.ItemsSource = db.Dictionaries.Where(p => p.Categoria == "S").ToList();
                    TBCategoria.Text = "Категория S: Короны, одежда, посохи и т.п.";
                    break;
                case 20:
                    LViewDictionary.ItemsSource = db.Dictionaries.Where(p => p.Categoria == "T").ToList();
                    TBCategoria.Text = "Категория T: Оружие — военное, охотничье и т.п.";
                    break;
                case 21:
                    LViewDictionary.ItemsSource = db.Dictionaries.Where(p => p.Categoria == "U").ToList();
                    TBCategoria.Text = "Категория U: Орудия земледелия и разных ремёсел";
                    break;
                case 22:
                    LViewDictionary.ItemsSource = db.Dictionaries.Where(p => p.Categoria == "V").ToList();
                    TBCategoria.Text = "Категория V: Корзины, мешки, изделия из верёвок и т.п.";
                    break;
                case 23:
                    LViewDictionary.ItemsSource = db.Dictionaries.Where(p => p.Categoria == "W").ToList();
                    TBCategoria.Text = "Категория W: Сосуды — каменные и глиняные";
                    break;
                case 24:
                    LViewDictionary.ItemsSource = db.Dictionaries.Where(p => p.Categoria == "X").ToList();
                    TBCategoria.Text = "Категория X: Хлеб разных видов";
                    break;
                case 25:
                    LViewDictionary.ItemsSource = db.Dictionaries.Where(p => p.Categoria == "Y").ToList();
                    TBCategoria.Text = "Категория Y: Принадлежности письма и игры, музыкальные инструменты";
                    break;
                case 26:
                    LViewDictionary.ItemsSource = db.Dictionaries.Where(p => p.Categoria == "Z").ToList();
                    TBCategoria.Text = "Категория Z: Разные линии и геометрические фигуры";
                    break;
                case 27:
                    LViewDictionary.ItemsSource = db.Dictionaries.Where(p => p.Categoria == "Aa").ToList();
                    TBCategoria.Text = "Категория Aa: Не поддающиеся классификации";
                    break;
            }

        }

        private void BSearh_Click(object sender, RoutedEventArgs e)
        {
            db = new ApplicationContext();
            db.Dictionaries.Load();
            var modified = db.Dictionaries.ToList();
            if (TBSearchGardiner.Text == "" && TBSearchTransliteration.Text == "" && TBSearchUnicode.Text == "" && TBSearchWords.Text == "")
            {
                LViewDictionary.ItemsSource = db.Dictionaries.ToList();
            }
            if (TBSearchGardiner.Text != "")
            {
                modified = modified.Where(p => !string.IsNullOrEmpty(p.GardinerCode) && p.GardinerCode.ToLower().Contains(TBSearchGardiner.Text.ToLower())).ToList();
            }
            if (TBSearchTransliteration.Text != "")
            {
                modified = modified.Where(p => !string.IsNullOrEmpty(p.Transliteration) && p.Transliteration.ToLower().Contains(TBSearchTransliteration.Text.ToLower())).ToList();
            }
            if (TBSearchUnicode.Text != "")
            {
                modified = modified.Where(p => !string.IsNullOrEmpty(p.Glyph) && p.Glyph.ToLower().Contains(TBSearchUnicode.Text.ToLower())).ToList();
            }
            if (TBSearchWords.Text != "")
            {
                modified = modified.Where(p => !string.IsNullOrEmpty(p.Description) && p.Description.ToLower().Contains(TBSearchWords.Text.ToLower())
                || !string.IsNullOrEmpty(p.Notes) && p.Notes.ToLower().Contains(TBSearchWords.Text.ToLower())
                || !string.IsNullOrEmpty(p.Phonogram) && p.Phonogram.ToLower().Contains(TBSearchWords.Text.ToLower())).ToList();
            }
            LViewDictionary.ItemsSource = modified;
        }

        private void BEdit_Click(object sender, RoutedEventArgs e)
        {
            // если ни одного объекта не выделено, выходим
            if (LViewDictionary.SelectedItem == null) return;
            // получаем выделенный объект
            Dictionary dictionary = LViewDictionary.SelectedItem as Dictionary;

            DictionaryWindow dictionaryWindow = new DictionaryWindow(new Dictionary
            {
                Id = dictionary.Id,
                Glyph = dictionary.Glyph,
                Unicode = dictionary.Unicode,
                GardinerCode = dictionary.GardinerCode,
                Transliteration = dictionary.Transliteration,
                Description = dictionary.Description,
                Phonogram = dictionary.Phonogram,
                Notes = dictionary.Notes
            });

            if (dictionaryWindow.ShowDialog() == true)
            {
                // получаем измененный объект
                dictionary = db.Dictionaries.Find(dictionaryWindow.Dictionaries.Id);
                if (dictionary != null)
                {
                    dictionary.Glyph = dictionaryWindow.Dictionaries.Glyph;
                    dictionary.Unicode = dictionaryWindow.Dictionaries.Unicode;
                    dictionary.GardinerCode = dictionaryWindow.Dictionaries.GardinerCode;
                    dictionary.Transliteration = dictionaryWindow.Dictionaries.Transliteration;
                    dictionary.Phonogram = dictionaryWindow.Dictionaries.Phonogram;
                    dictionary.Description = dictionaryWindow.Dictionaries.Description;
                    dictionary.Notes = dictionaryWindow.Dictionaries.Notes;
                    db.Entry(dictionary).State = EntityState.Modified;
                    db.SaveChanges();
                }
            }

        }
    }
}
