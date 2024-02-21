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
    /// Логика взаимодействия для TasksPage.xaml
    /// </summary>
    public partial class TasksPage : Page
    {
        public static List<User> employee { get; set; }
        public static List<DB.Task> examsSort { get; set; }
        public TasksPage()
        {
            InitializeComponent();
            if (App.currentUser.IdRole == 4)
                TasksLv.ItemsSource = ConnectionDB.circus.Task.Where(i => i.IdUser == App.currentUser.ID && i.done == false).ToList();
            else
            {
                TasksLv.ItemsSource = ConnectionDB.circus.Task.ToList();
                AddBt.Visibility = Visibility.Visible;
            }
                
                DataContext = this;
        }

        private void TasksLv_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            App.selectedTask = (DB.Task)TasksLv.SelectedItem;
            NavigationService.Navigate(new EnterTaskPage());
        }
    }
}
