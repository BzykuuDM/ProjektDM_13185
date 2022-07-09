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
        int dzial_id = 1;
        int kraj_id = 1;
        int urlop_id = 1;
        public Dodawanie()
        {
            InitializeComponent();
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

        private void add_Click(object sender, RoutedEventArgs e)
        {
            WorkersEntities db = new WorkersEntities();
            
            switch ((string)dzial.SelectedValue)
            {
                case "Administracja" when (string)stanowisko.SelectedValue == "Kierownik działu":
                    dzial_id = 1;
                    break;
                case "Administracja" when (string)stanowisko.SelectedValue == "Menedżer":
                    dzial_id = 2;
                    break;
                case "Administracja" when (string)stanowisko.SelectedValue == "Pracownik biurowy":
                    dzial_id = 3;
                    break;
                case "Administracja" when (string)stanowisko.SelectedValue == "Wsparcie wewnętrzne":
                    dzial_id = 4;
                    break;
                case "Obsługa klienta" when (string)stanowisko.SelectedValue == "Kierownik działu":
                    dzial_id = 5;
                    break;
                case "Obsługa klienta" when (string)stanowisko.SelectedValue == "Menedżer":
                    dzial_id = 6;
                    break;
                case "Obsługa klienta" when (string)stanowisko.SelectedValue == "Wsparcie klienta":
                    dzial_id = 7;
                    break;
                case "Transport" when (string)stanowisko.SelectedValue == "Kierownik działu":
                    dzial_id = 8;
                    break;
                case "Transport" when (string)stanowisko.SelectedValue == "Menedżer":
                    dzial_id = 9;
                    break;
                case "Transport" when (string)stanowisko.SelectedValue == "Kierowca":
                    dzial_id = 10;
                    break;
                case "Transport" when (string)stanowisko.SelectedValue == "Pracownik magazynowy":
                    dzial_id = 11;
                    break;
            }

            switch ((string)kraje.SelectedValue)
            {
                case "Polska":
                    kraj_id = 1; 
                    break;
                case "Ukraina":
                    kraj_id = 2;
                    break;
                case "Białoruś":
                    kraj_id = 3;
                    break;
                case "Węgry":
                    kraj_id = 4;
                    break;
                case "Czechy":
                    kraj_id = 5;
                    break;
                case "Niemcy":
                    kraj_id = 6;
                    break;
                case "Francja":
                    kraj_id = 7;
                    break;
            }

            switch (dni_urlop.Text)
            {
                case "1":
                    urlop_id = 1;
                    break;
                case "2":
                    urlop_id = 2;
                    break;
                case "3":
                    urlop_id = 3;
                    break;
                case "4":
                    urlop_id = 4;
                    break;
                case "5":
                    urlop_id = 5;
                    break;
                case "6":
                    urlop_id = 6;
                    break;
                case "7":
                    urlop_id = 7;
                    break;
                case "8":
                    urlop_id = 8;
                    break;
                case "9":
                    urlop_id = 9;
                    break;
                case "10":
                    urlop_id = 10;
                    break;
                case "11":
                    urlop_id = 11;
                    break;
                case "12":
                    urlop_id = 12;
                    break;
                case "13":
                    urlop_id = 13;
                    break;
                case "14":
                    urlop_id = 14;
                    break;
                case "15":
                    urlop_id = 15;
                    break;
                case "16":
                    urlop_id = 16;
                    break;
                case "17":
                    urlop_id = 17;
                    break;
                case "18":
                    urlop_id = 18;
                    break;
                case "19":
                    urlop_id = 19;
                    break;
                case "20":
                    urlop_id = 20;
                    break;
                case "21":
                    urlop_id = 21;
                    break;
                case "22":
                    urlop_id = 22;
                    break;
                case "23":
                    urlop_id = 23;
                    break;
                case "24":
                    urlop_id = 24;
                    break;
                case "25":
                    urlop_id = 25;
                    break;
                case "26":
                    urlop_id = 26;
                    break;
            }

            Pracownik worker = new Pracownik()
            {
                dzial_id = dzial_id,
                kraj_id = kraj_id,
                urlop_id = urlop_id,
                
                imie = Imie.Text,
                nazwisko = Nazwisko1.Text,
                nr_tel = nr_tel.Text,
                PESEL = pesel.Text,
            };
            db.Pracownik.Add(worker);
            db.SaveChanges();
            Close();

        }

        private void cancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }


    }
}
