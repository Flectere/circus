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
    /// Логика взаимодействия для TrainingSchedule.xaml
    /// </summary>
    public partial class TrainingSchedule : Page
    {
        public TrainingSchedule()
        {
            InitializeComponent();
            if (App.currentUser.IdRole == 3)
            {
                TrainingsLv.ItemsSource = ConnectionDB.circus.TrainingSchedule.Where(i => i.AnimalCell.IdTrainer == App.currentUser.ID && i.done == false).ToList();
                AddBt.Visibility = Visibility.Visible;
            }
            else
                TrainingsLv.ItemsSource = ConnectionDB.circus.TrainingSchedule.ToList();

            DataContext = this;
        }

        private void TrainingsLv_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void AddBt_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddTrainingPage());
        }

        private void CompleteBt_Click(object sender, RoutedEventArgs e)
        {
            DB.TrainingSchedule selectedTraining = TrainingsLv.SelectedItem as DB.TrainingSchedule;
            selectedTraining.done = true;
            ConnectionDB.circus.SaveChanges();
            TrainingsLv.ItemsSource = ConnectionDB.circus.TrainingSchedule.Where(i => i.AnimalCell.IdTrainer == App.currentUser.ID && i.done == false).ToList();
        }
    }
}