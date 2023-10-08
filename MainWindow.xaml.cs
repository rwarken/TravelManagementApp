using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
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
using System.Xaml;
using static TravelManagementApp.MainWindow;

namespace TravelManagementApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public void btnDestination_Click(object sender, RoutedEventArgs e)
        {
            datagridDestination.Columns.Clear();
            datagridDestination.Items.Refresh();

            List<Destination> destination = new List<Destination>();

            datagridDestination.ItemsSource = new ObservableCollection<Destination>
            {
                new Destination() { Id = 1, Country = "Portugal", City = "Lisboa", Visited = true },
                new Destination() { Id = 2, Country = "Portugal", City = "Porto", Visited = false },
                new Destination() { Id = 3, Country = "Espanha", City = "Barcelona", Visited = true },
                new Destination() { Id = 4, Country = "Hungria", City = "Budapeste", Visited = false },
                new Destination() { Id = 5, Country = "Croacia", City = "Zagreb", Visited = true }
            };
        }

        private void btnTypeOfAccomodation_Click(object sender, RoutedEventArgs e)
        {
            datagridTypeOfAccomodation.Columns.Clear();
            datagridTypeOfAccomodation.Items.Refresh();

            List<TypeOfAccomodation> typeOfAccomodation = new List<TypeOfAccomodation>();
            typeOfAccomodation.Add(new TypeOfAccomodation() { Id = 1, Type = "Apartment", CompanyName = "Booking", Name = "Apartment XYZ" });
            typeOfAccomodation.Add(new TypeOfAccomodation() { Id = 2, Type = "Apartment", CompanyName = "Novasol", Name = "123 Apartment" });
            typeOfAccomodation.Add(new TypeOfAccomodation() { Id = 3, Type = "Apartment", CompanyName = "Airbnb", Name = "Another Apartment" });
            typeOfAccomodation.Add(new TypeOfAccomodation() { Id = 4, Type = "Hotel", CompanyName = "Booking", Name = "Hotel dos Tantas" });
            typeOfAccomodation.Add(new TypeOfAccomodation() { Id = 5, Type = "Hotel", CompanyName = "Booking", Name = "Hotel Meia Boca" });

            datagridTypeOfAccomodation.ItemsSource = typeOfAccomodation;
        }

        private void btnShowChosenOptions_Click(object sender, RoutedEventArgs e)
        {
            var destination = datagridDestination.SelectedItem as Destination;
            var typeOfAccomodation = datagridTypeOfAccomodation.SelectedItem as TypeOfAccomodation;

            MessageBox.Show(destination.Id + " / " + destination.Country + " / " + destination.City + " / " + destination.Visited);
            MessageBox.Show(typeOfAccomodation.Id + " / " + typeOfAccomodation.Type + " / " + typeOfAccomodation.CompanyName + " / " + typeOfAccomodation.Name);
        }
    }
}
