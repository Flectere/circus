using circus.DB;
using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace circus.Pages
{
    /// <summary>
    /// Логика взаимодействия для AddEntityPage.xaml
    /// </summary>
    public partial class AddEntityPage : Page
    {
        public AddEntityPage()
        {
            InitializeComponent();
            RoleCb.ItemsSource = ConnectionDB.circus.Role.ToList();
        }

        private void AddEmployeeBt_Click(object sender, RoutedEventArgs e)
        {
            User user = new User();
            
            user.Role = RoleCb.SelectedItem as Role;
            user.LastName = LastNameTb.Text;
            user.FirstName = NameTb.Text;
            user.Login = LoginTb.Text;
            user.Password = PasswordTb.Text;

            ConnectionDB.circus.User.Add(user);
            ConnectionDB.circus.SaveChanges();
            NavigationService.Navigate(new ChoiceAdminMove());
        }
    }
}
