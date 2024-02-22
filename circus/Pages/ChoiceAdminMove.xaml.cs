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
    /// Логика взаимодействия для ChoiceAdminMove.xaml
    /// </summary>
    public partial class ChoiceAdminMove : Page
    {
        public ChoiceAdminMove()
        {
            InitializeComponent();
        }

        private void TaskBt_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new TasksPage());
        }

        private void ScheduleTrainingBt_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new TrainingSchedule());
        }

        private void ScheduleArtistBt_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ListApplications());
        }

        private void AnimalOrHumanBt_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ChoiceEntity());
        }
    }
}