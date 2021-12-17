using EgyptianDictionary_SQLite.Windows;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace EgyptianDictionary_SQLite.Pages
{

    public partial class ProfileTranslatorPage : Page
    {
        ApplicationContext db;

        public ProfileTranslatorPage()
        {
            db = new ApplicationContext();
            db.Users.Load();
            db.Clients.Load();
            db.Translators.Load();
            List<Translation> translations = db.Translations.ToList();
            List<Translator> translators = db.Translators.ToList();
            List<Client> clients = db.Clients.ToList();
            List<Role> roles = db.Roles.ToList();
            InitializeComponent();
            for (int t = 0; t < translations.Count; t++)
            {
                for (int i = 0; i < clients.Count; i++)
                {
                    if (translations[t].ClientId == clients[i].Id)
                    {
                        translations[t].ClientName = clients[i].Name;
                    }
                }
            }
            int translatorCurrent = 0;
            int translatorCount = 0;
            string roleCurrent = "";
            for (int t = 0; t < translators.Count; t++)
            {
                if (translators[t].UserId == App.CurrentUser.Id)
                {
                    translatorCurrent = translators[t].Id;
                    translatorCount = t;
                }

            }
            for (int r = 0; r < roles.Count; r++)
            {
                if (roles[r].Id == App.CurrentUser.RoleId)
                {
                    roleCurrent = roles[r].Name;
                }
            }
            TBType.Text = roleCurrent;
            TBLogin.Text = App.CurrentUser.Id;
            TBPassword.Text = App.CurrentUser.Password;
            TBName.Text = translators[translatorCount].Name;
            if (translators[translatorCount].Gender == "м") CBGender.SelectedItem = CBMale;
            else CBGender.SelectedItem = CBFemale;
            TBPhoto.Text = translators[translatorCount].Avatar;
            TBEducation.Text = translators[translatorCount].Education;
            TBExperience.Text = translators[translatorCount].Experience;
            LViewNow.ItemsSource = translations.Where(p => p.TranslatorId == translatorCurrent && p.Result == null).ToList();
            LViewDone.ItemsSource = translations.Where(p => p.TranslatorId == translatorCurrent && p.Result != null).ToList();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int index = int.Parse(((Button)e.Source).Uid);

            GridCursor.Margin = new Thickness(10 + (440 * index), 0, 0, 0);

            switch (index)
            {
                case 0:
                    GridNow.Visibility = Visibility.Visible;
                    GridDone.Visibility = Visibility.Collapsed;
                    break;
                case 1:
                    GridNow.Visibility = Visibility.Collapsed;
                    GridDone.Visibility = Visibility.Visible;
                    break;
            }
        }
        private void BTranslation_Click(object sender, RoutedEventArgs e)
        {
            var currentTranslation = (sender as Button).DataContext as Translation;
            new TranslationWindow(currentTranslation).Show();

        }


        private void BEdit_Click(object sender, RoutedEventArgs e)
        {
            TBPassword.IsReadOnly = false;
            TBName.IsReadOnly = false;
            TBPhoto.IsReadOnly = false;
            TBEducation.IsReadOnly = false;
            TBExperience.IsReadOnly = false;
            CBGender.IsEnabled = true;
            BEdit.Visibility = Visibility.Collapsed;
            BSave.Visibility = Visibility.Visible;
        }
        private void BSave_Click(object sender, RoutedEventArgs e)
        {
            db = new ApplicationContext();
            db.Users.Load();
            db.Clients.Load();
            db.Translators.Load();
            List<Translator> translators = db.Translators.ToList();
            if (TBPassword.Text == "" || TBName.Text == "" || CBGender.SelectedItem == null || TBEducation.Text == "" || TBExperience.Text == "")
            {
                MessageBox.Show("Не все данные были введены!");
                return;
            }
            int translatorCurrent = 0;
            for (int t = 0; t < translators.Count; t++)
            {
                if (translators[t].UserId == App.CurrentUser.Id)
                {
                    translatorCurrent = t;
                }

            }
            App.CurrentUser.Password = TBPassword.Text;
            translators[translatorCurrent].Name = TBName.Text;
            translators[translatorCurrent].Avatar = TBPhoto.Text;
            translators[translatorCurrent].Education = TBEducation.Text;
            translators[translatorCurrent].Experience = TBExperience.Text;
            db.SaveChanges();
            MessageBox.Show("Информация о пользователе обновлена!");
            TBPassword.IsReadOnly = true;
            TBName.IsReadOnly = true;
            TBPhoto.IsReadOnly = true;
            CBGender.IsEnabled = false;
            TBEducation.IsReadOnly = true;
            TBExperience.IsReadOnly = true;
            BEdit.Visibility = Visibility.Visible;
            BSave.Visibility = Visibility.Collapsed;
        }
        private void BDelete_Click(object sender, RoutedEventArgs e)
        {
            db = new ApplicationContext();
            db.Users.Load();
            db.Clients.Load();
            db.Translators.Load();
            List<Translation> translations = db.Translations.ToList();
            List<Translator> translators = db.Translators.ToList();
            MessageBoxResult dialogResult = MessageBox.Show("Вы действительно хотите удалить этот аккаунт и все связанные с ним переводы?", "Внимание!", MessageBoxButton.YesNo);
            if (dialogResult == MessageBoxResult.Yes)
            {
                int translatorCount = 0;
                int translatorCurrent = 0;
                for (int t = 0; t < translators.Count; t++)
                {
                    if (translators[t].UserId == App.CurrentUser.Id)
                    {
                        translatorCount = t;
                        translatorCurrent = translators[t].Id;
                    }

                }
                for (int t = 0; t < translations.Count; t++)
                {
                    if (translations[t].TranslatorId == translatorCurrent)
                    {
                        db.Translations.Remove(translations[t]);
                    }

                }
                db.Users.Remove(App.CurrentUser);
                db.Translators.Remove(translators[translatorCount]);
                db.SaveChanges();
                MessageBox.Show("Аккаунт удален");
                var exe = Process.GetCurrentProcess().MainModule.FileName;
                Process.Start(exe);
                Application.Current.Shutdown();
            }
            else if (dialogResult == MessageBoxResult.No)
            {
                return;
            }
        }
    }
}
