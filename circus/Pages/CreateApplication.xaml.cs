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
    /// Логика взаимодействия для CreateApplication.xaml
    /// </summary>
    public partial class CreateApplication : Page
    {
        public CreateApplication()
        {
            InitializeComponent();
            if (App.GoEdit == 1)
            {
                NamePageTb.Text = "ИЗМЕНИТЬ ДАННЫЕ";
                NameTb.Text = App.selectedPerformance.NamePerformance;
                TrainingDateDp.SelectedDate = App.selectedPerformance.Date;
            }
            else if (App.GoEdit == 0)
                NamePageTb.Text = "ОТПРАВИТЬ ЗАЯВКУ";
        }

        private void AddTrainingBt_Click(object sender, RoutedEventArgs e)
        {
            if (App.GoEdit == 0)
            {
                DB.Application application = new DB.Application();
                application.Date = TrainingDateDp.SelectedDate;
                application.NamePerformance = NameTb.Text;
                application.idUser = App.currentUser.ID;
                application.done = false;
                DB.ConnectionDB.circus.Application.Add(application);
                DB.ConnectionDB.circus.SaveChanges();
                NavigationService.Navigate(new ArtistSchedulePage());
            }
            else if (App.GoEdit == 1)
            {
                DB.Application application = new DB.Application();
                application.Date = TrainingDateDp.SelectedDate;
                application.NamePerformance = NameTb.Text;
                application.idUser = App.currentUser.ID;
                application.done = false;
                DB.ConnectionDB.circus.Application.Add(application);
                DB.ConnectionDB.circus.SaveChanges();
                App.GoEdit = 0;
                App.GoEditOld = 1;
                NavigationService.Navigate(new ArtistSchedulePage());
            }
        }

        private void GoBackBt_Click(object sender, RoutedEventArgs e)
        {
            App.GoEdit = 0;
            NavigationService.Navigate(new ArtistSchedulePage());
        }
    }
}
