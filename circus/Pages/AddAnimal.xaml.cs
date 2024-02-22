using System;
using circus.DB;
using System.Collections.Generic;
using System.Data.Common;
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
    /// Логика взаимодействия для AddAnimal.xaml
    /// </summary>
    public partial class AddAnimal : Page
    {
        public AddAnimal()
        {
            InitializeComponent();
            GenderCb.ItemsSource = ConnectionDB.circus.Gender.ToList();
            TrainerCb.ItemsSource = ConnectionDB.circus.User.Where(i => i.Role.Name == "Дрессировщик").ToList();
        }

        private void AddAnimalBt_Click(object sender, RoutedEventArgs e)
        {
            AnimalCell cell = new AnimalCell();
            cell.User = TrainerCb.SelectedItem as User;
            cell.Name = NameTb.Text;
            cell.Age = int.Parse(AgeTb.Text);
            cell.FavoriteFood = FoodTb.Text;
            cell.Weight = int.Parse(WeightTb.Text);
            cell.Gender = GenderCb.SelectedItem as Gender;
            ConnectionDB.circus.AnimalCell.Add(cell);
            ConnectionDB.circus.SaveChanges();
            NavigationService.Navigate(new ChoiceAdminMove());
        }
    }
}
