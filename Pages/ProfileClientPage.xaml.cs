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
    /// <summary>
    /// Логика взаимодействия для ProfileClientPage.xaml
    /// </summary>
    public partial class ProfileClientPage : Page
    {
        ApplicationContext db;
        public ProfileClientPage()
        {
            InitializeComponent();
            db = new ApplicationContext();
            db.Users.Load();
            db.Clients.Load();
            db.Translators.Load();
            List<Translation> translations = db.Translations.ToList();
            List<Translator> translators = db.Translators.ToList();
            List<Client> clients = db.Clients.ToList();
            List<Role> roles = db.Roles.ToList();
            for (int t = 0; t < translations.Count; t++)
            {
                for (int i = 0; i < translators.Count; i++)
                {
                    if (translations[t].TranslatorId == translators[i].Id)
                    {
                        translations[t].TranslatorName = translators[i].Name;
                    }
                }
            }
            int clientCurrent = 0;
            int clientCount = 0;
            string roleCurrent = "";
            for (int c = 0; c < clients.Count; c++)
            {
                if (clients[c].UserId == App.CurrentUser.Id)
                {
                    clientCurrent = clients[c].Id;
                    clientCount = c;
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
            TBName.Text = clients[clientCount].Name;
            TBPhoto.Text = clients[clientCount].Avatar;
            if (clients[clientCount].Gender == "м") CBGender.SelectedItem = CBMale;
            else CBGender.SelectedItem = CBFemale;
            CBTranslator.ItemsSource = translators;
            LViewSend.ItemsSource = translations.Where(p => p.ClientId == clientCurrent && p.Result == null).ToList();
            LViewResult.ItemsSource = translations.Where(p => p.ClientId == clientCurrent && p.Result != null).ToList();

        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int index = int.Parse(((Button)e.Source).Uid);

            GridCursor.Margin = new Thickness(10 + (295 * index), 0, 0, 0);

            switch (index)
            {
                case 0:
                    GridCreate.Visibility = Visibility.Visible;
                    GridSend.Visibility = Visibility.Collapsed;
                    GridResult.Visibility = Visibility.Collapsed;
                    break;
                case 1:
                    GridCreate.Visibility = Visibility.Collapsed;
                    GridSend.Visibility = Visibility.Visible;
                    GridResult.Visibility = Visibility.Collapsed;
                    break;
                case 2:
                    GridCreate.Visibility = Visibility.Collapsed;
                    GridSend.Visibility = Visibility.Collapsed;
                    GridResult.Visibility = Visibility.Visible;
                    break;
            }
        }

        private void BCreate_Click(object sender, RoutedEventArgs e)
        {
            db = new ApplicationContext();
            db.Users.Load();
            db.Clients.Load();
            db.Translators.Load();
            List<Translator> translators = db.Translators.ToList();
            List<Client> clients = db.Clients.ToList();
            if (TBText.Text == "" || TBTask.Text == "" || CBTranslator.SelectedItem == null)
            {
                MessageBox.Show("Не все данные были введены!");
                return;
            }
            byte translator = 0;
            for (int i = 0; i < translators.Count; i++)
            {
                if (CBTranslator.SelectedItem == translators[i])
                {
                    translator = translators[i].Id;
                }
            }
            byte clientCurrent = 0;
            for (int c = 0; c < clients.Count; c++)
            {
                if (clients[c].UserId == App.CurrentUser.Id)
                {
                    clientCurrent = clients[c].Id;
                }
            }
            Translation newTranslation = new Translation()
            {
                OriginalText = TBText.Text,
                Task = TBTask.Text,
                TranslatorId = translator,
                ClientId = clientCurrent,
            };
            db.Translations.Add(newTranslation);
            db.SaveChanges();
            MessageBox.Show("Заявка успешно отправлена!");
        }

        private void BEdit_Click(object sender, RoutedEventArgs e)
        {
            TBPassword.IsReadOnly = false;
            TBName.IsReadOnly = false;
            TBPhoto.IsReadOnly = false;
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
            List<Client> clients = db.Clients.ToList();
            if (TBPassword.Text == "" || TBName.Text == "" || CBGender.SelectedItem == null)
            {
                MessageBox.Show("Не все данные были введены!");
                return;
            }
            int clientCurrent = 0;
            for (int c = 0; c < clients.Count; c++)
            {
                if (clients[c].UserId == App.CurrentUser.Id)
                {
                    clientCurrent = c;
                }

            }
            App.CurrentUser.Password = TBPassword.Text;
            clients[clientCurrent].Name = TBName.Text;
            clients[clientCurrent].Avatar = TBPhoto.Text;
            if (CBGender.SelectedItem == CBMale) clients[clientCurrent].Gender = "м";
            else if (CBGender.SelectedItem == CBFemale) clients[clientCurrent].Gender = "ж";
            db.SaveChanges();
            MessageBox.Show("Информация о пользователе обновлена!");
            TBPassword.IsReadOnly = true;
            TBName.IsReadOnly = true;
            TBPhoto.IsReadOnly = true;
            CBGender.IsEnabled = false;
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
            List<Client> clients = db.Clients.ToList();
            MessageBoxResult dialogResult = MessageBox.Show("Вы действительно хотите удалить этот аккаунт и все связанные с ним переводы?", "Внимание!", MessageBoxButton.YesNo);
            if (dialogResult == MessageBoxResult.Yes)
            {
                int clientCount = 0;
                int clientCurrent = 0;
                for (int c = 0; c < clients.Count; c++)
                {
                    if (clients[c].UserId == App.CurrentUser.Id)
                    {
                        clientCount = c;
                        clientCurrent = clients[c].Id;
                    }

                }
                for (int t = 0; t < translations.Count; t++)
                {
                    if (translations[t].ClientId == clientCurrent)
                    {
                        db.Translations.Remove(translations[t]);
                    }

                }
                db.Users.Remove(App.CurrentUser);
                db.Clients.Remove(clients[clientCount]);
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

