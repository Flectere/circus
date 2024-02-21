using circus.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace circus.Pages
{
    /// <summary>
    /// Логика взаимодействия для AuthPage.xaml
    /// </summary>
    public partial class AuthPage : Page
    {
       
        public AuthPage()
        {
            InitializeComponent();
        }

        private void EnterBt_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string login = LoginTb.Text.Trim().ToLower();
                string password = PasswordPb.Password.Trim().ToLower();
                App.currentUser = ConnectionDB.circus.User.FirstOrDefault(i => i.Login == login && i.Password == password);
                if (App.currentUser.IdRole == 4)
                {
                    NavigationService.Navigate(new TasksPage());
                }
                else if (App.currentUser.IdRole == 1)
                {
                    NavigationService.Navigate(new ChoiceAdminMove());
                }
                else
                {
                    MessageBox.Show("Такого пользователя не существует.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                
            }
            catch
            {
                MessageBox.Show("Произошла ошибка, попробуйте снова.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
