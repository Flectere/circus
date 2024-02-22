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
    /// Логика взаимодействия для ListApplications.xaml
    /// </summary>
    public partial class ListApplications : Page
    {
        public ListApplications()
        {
            InitializeComponent();
            ApplicationLv.ItemsSource = DB.ConnectionDB.circus.Application.Where(i => i.done == false).ToList();
        }
        
        private void ApplicationLv_SelectionChanged(object sender, SelectionChangedEventArgs e)
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
    }
}
