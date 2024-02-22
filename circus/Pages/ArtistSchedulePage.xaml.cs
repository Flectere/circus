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
    /// Логика взаимодействия для ArtistSchedulePage.xaml
    /// </summary>
    public partial class ArtistSchedulePage : Page
    {
        public ArtistSchedulePage()
        {
            InitializeComponent();
            if (App.currentUser.IdRole == 2)
                ScheduleLv.ItemsSource = ConnectionDB.circus.ListPerformance.Where(i => i.IdArtist == App.currentUser.ID).ToList();
            else
            {
                ScheduleLv.ItemsSource = ConnectionDB.circus.ListPerformance.ToList();
                AddBt.Visibility = Visibility.Visible;
            }
            DataContext = this;
        }
        private void AddBt_Click(object sender, RoutedEventArgs e)
        {
            if (App.currentUser.IdRole == 2)
                NavigationService.Navigate(new CreateApplication());
            else
                NavigationService.Navigate(new AcceptApplication());
        }

        private void ScheduleLv_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            App.GoEdit = 1;
            App.selectedPerformance = ScheduleLv.SelectedItem as ListPerformance;
            NavigationService.Navigate(new CreateApplication());
        }

        private void RefreshBt_Click(object sender, RoutedEventArgs e)
        {
            ScheduleLv.Items.Refresh();
        }
    }
}
