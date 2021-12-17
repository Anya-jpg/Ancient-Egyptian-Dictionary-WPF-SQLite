using EgyptianDictionary_SQLite.Windows;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace EgyptianDictionary_SQLite.Windows
{
    public partial class RegistrationWindow : Window
    {
        ApplicationContext db;
        public RegistrationWindow()
        {
            InitializeComponent();
        }

        private void BRegistration_Click(object sender, RoutedEventArgs e)
        {
            db = new ApplicationContext();
            db.Users.Load();
            db.Clients.Load();
            db.Translators.Load();
            if (TBLogin.Text == "" || TBPassword.Password == "" || TBName.Text == "" || CBRole.SelectedItem == null || CBGender.SelectedItem == null)
            {
                MessageBox.Show("Не все данные заполнены!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (db.Users.Select(Item => Item.Id).Contains(TBLogin.Text))
            {
                MessageBox.Show("Такой логин уже существует в системе!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            string g = "м";
            byte role = 1;
            if (CBGender.SelectedItem == CBMale) g = "м";
            if (CBGender.SelectedItem == CBFemale) g = "ж";
            if (CBRole.SelectedItem == CBUser) role = 1;
            if (CBRole.SelectedItem == CBTranslator) role = 2;
            string photo = "𓁛";
            if (TBPhoto.Text != "") photo = TBPhoto.Text;
            User newUser = new User()
            {
                Id = TBLogin.Text,
                Password = TBPassword.Password,
                RoleId = role,
            };
            db.Users.Add(newUser);
            if (CBRole.SelectedItem == CBUser)
            {
                Client newClient = new Client()
                {
                    UserId = TBLogin.Text,
                    Name = TBName.Text,
                    Gender = g,
                    Avatar = photo,
                };
                db.Clients.Add(newClient);
            }
            if (CBRole.SelectedItem == CBTranslator)
            {
                Translator newTranslator = new Translator()
                {
                    UserId = TBLogin.Text,
                    Name = TBName.Text,
                    Gender = g,
                    Avatar = photo,
                    Education = TBEducation.Text,
                    Experience = TBExperience.Text,
                };
                db.Translators.Add(newTranslator);
            }
            db.SaveChanges();
            MessageBox.Show("Вы успешно зарегистрированы!");
            new LoginWindow().Show();
            this.Close();
        }

        private void BCancel_Click(object sender, RoutedEventArgs e)
        {
            new LoginWindow().Show();
            this.Close();
        }

        private void CBRole_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (CBRole.SelectedItem == CBTranslator)
            {
                TBEducation.IsEnabled = true;
                TBExperience.IsEnabled = true;
            }
            if (CBRole.SelectedItem == CBUser)
            {
                TBEducation.IsEnabled = false;
                TBExperience.IsEnabled = false;
            }
        }
        private void BMinimize_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }
        private void BClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void MainWindow_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }
    }
}
