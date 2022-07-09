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
using System.Windows.Shapes;
using System.Collections.ObjectModel;

namespace ProjektDM_13185
{
    /// <summary>
    /// Logika interakcji dla klasy Dodawanie.xaml
    /// </summary>
    public partial class Dodawanie : Window
    {
        public Dodawanie()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, RoutedEventArgs e)
        {

        }

        private void cancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void dzial_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            List<string> lista = new List<string>();

            switch (dzial.SelectedIndex)
            {
                case 0:
                    lista.AddRange(new List<string>()
                    {
                        "Kierownik działu",
                        "Menedżer",
                        "Pracownik biurowy",
                        "Wsparcie wewnętrzne",
                    });
                    break;
                case 1:
                    lista.AddRange(new List<string>()
                    {
                        "Kierownik działu",
                        "Menedżer",
                        "Wsparcie klienta",                       
                    });
                    break;
                case 2:
                    lista.AddRange(new List<string>()
                    {
                        "Kierownik działu",
                        "Menedżer",
                        "Kierowca",
                        "Pracownik magazynowy"
                    });
                    break;
            }

            ObservableCollection<string> x = new ObservableCollection<string>(lista);
            stanowisko.IsEnabled = true;
            stanowisko.ItemsSource = null;
            stanowisko.ItemsSource = x;
        }
    }
}
