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
    /// Логика взаимодействия для EnterTaskPage.xaml
    /// </summary>
    public partial class EnterTaskPage : Page
    {
        public EnterTaskPage()
        {
            InitializeComponent();
            NameTaskTb.Text = App.selectedTask.Comment;
            DataContext = this;
        }

        private void FinishTaskBt_Click(object sender, RoutedEventArgs e)
        {
            App.selectedTask.Comment = CommentTb.Text;
            App.selectedTask.done = true;
            ConnectionDB.circus.SaveChanges();
            NavigationService.Navigate(new TasksPage());
        }
    }
}
