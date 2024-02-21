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
using circus.DB;

namespace circus.Pages
{
    /// <summary>
    /// Логика взаимодействия для CreateTaskPage.xaml
    /// </summary>
    public partial class CreateTaskPage : Page
    {
        public CreateTaskPage()
        {
            InitializeComponent();
            List<User> users = new List<User>();
            users = ConnectionDB.circus.User.Where(i => i.ID != App.currentUser.ID && i.IdRole == 4).ToList();
            UserCb.ItemsSource = users;
            DataContext = this;
        }
        private void FinishTaskBt_Click(object sender, RoutedEventArgs e)
        {
            if (NameTaskTb.Text.Length != 0 && UserCb.SelectedItem != null)
            {
                User user = UserCb.SelectedItem as User;
                DB.Task task = new DB.Task();
                task.Name = NameTaskTb.Text;
                task.Comment = CommentTb.Text;
                task.done = false;
                task.IdUser = user.ID;
                ConnectionDB.circus.Task.Add(task);
                ConnectionDB.circus.SaveChanges();
                NavigationService.Navigate(new TasksPage());
            }
            else
            {
                MessageBox.Show("Заполните все поля.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
