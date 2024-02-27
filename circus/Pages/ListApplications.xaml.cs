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
    /// Логика взаимодействия для ListApplications.xaml
    /// </summary>
    public partial class ListApplications : Page
    {
        public static List<ListPerformance> list = ConnectionDB.circus.ListPerformance.ToList();
        public ListApplications()
        {
            InitializeComponent();
            ApplicationLv.ItemsSource = DB.ConnectionDB.circus.Application.Where(i => i.done == false).ToList();
        }
        
        private void ApplicationLv_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (App.GoEditOld == 0)
            {
                App.selectedApplication = ApplicationLv.SelectedItem as DB.Application;
                App.selectedApplication.done = true;
                DB.ListPerformance listPerformance = new DB.ListPerformance();
                listPerformance.Date = App.selectedApplication.Date;
                listPerformance.IdArtist = App.selectedApplication.idUser;
                listPerformance.NamePerformance = App.selectedApplication.NamePerformance;
                DB.ConnectionDB.circus.ListPerformance.Add(listPerformance);
                DB.ConnectionDB.circus.SaveChanges();
                NavigationService.Navigate(new ListApplications());
            }
            else
            {
                App.selectedApplication = ApplicationLv.SelectedItem as DB.Application;
                App.selectedApplication.done = true;
                App.selectedPerformance.NamePerformance = App.selectedApplication.NamePerformance;
                App.selectedPerformance.Date = App.selectedApplication.Date;
                DB.ConnectionDB.circus.SaveChanges();
                App.GoEditOld = 0;
                NavigationService.Navigate(new ListApplications());
            }
            
        }
    }
}
