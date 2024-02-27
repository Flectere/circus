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
    /// Логика взаимодействия для ListOfemployeesPage.xaml
    /// </summary>
    public partial class ListOfemployeesPage : Page
    {
        public ListOfemployeesPage()
        {
            InitializeComponent();
            TasksLv.ItemsSource = DB.ConnectionDB.circus.User.ToList();
        }

        private void AddBt_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ChoiceEntity());
        }

        private void AnimalBt_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ListOfAnimals());
        }
    }
}
