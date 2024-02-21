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
    /// Логика взаимодействия для AddTrainingPage.xaml
    /// </summary>
    public partial class AddTrainingPage : Page
    {
        public AddTrainingPage()
        {
            InitializeComponent();
            AnimalCb.ItemsSource = ConnectionDB.circus.AnimalCell.Where(i => i.IdTrainer == App.currentUser.ID).ToList();
            TrainingCb.ItemsSource = ConnectionDB.circus.Training.ToList();
        }

        private void AddTrainingBt_Click(object sender, RoutedEventArgs e)
        {
            DB.TrainingSchedule trainingSchedule = new DB.TrainingSchedule();
            trainingSchedule.AnimalCell = AnimalCb.SelectedItem as AnimalCell;
            trainingSchedule.Training = TrainingCb.SelectedItem as Training;
            trainingSchedule.Date = TrainingDateDp.SelectedDate;
            ConnectionDB.circus.TrainingSchedule.Add(trainingSchedule);
            ConnectionDB.circus.SaveChanges();
            NavigationService.Navigate(new TrainingSchedule());
        }
    }
}