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
    /// Логика взаимодействия для ChoiceEntity.xaml
    /// </summary>
    public partial class ChoiceEntity : Page
    {
        public ChoiceEntity()
        {
            InitializeComponent();
        }

        private void PeopleBt_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddEntityPage());
        }

        private void AnimalBt_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddAnimal());
        }
    }
}
