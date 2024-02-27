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
    /// Логика взаимодействия для ListOfAnimals.xaml
    /// </summary>
    public partial class ListOfAnimals : Page
    {
        public ListOfAnimals()
        {
            InitializeComponent();
            TasksLv.ItemsSource = DB.ConnectionDB.circus.AnimalCell.ToList();
        }
        private void AddBt_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ChoiceEntity());
        }

        private void EmployeesBt_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ListOfemployeesPage());
        }
    }
}
