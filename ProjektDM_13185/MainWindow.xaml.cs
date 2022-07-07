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
using System.Collections.ObjectModel;

namespace ProjektDM_13185
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public class tableView
        {
            public string Imie { get; set; }
            public string Nazwisko { get; set; }
            public string NrTelefonu { get; set; }
            public string PESEL { get; set; }
            public string Kraj { get; set; }
            public string Dzial { get; set; }
            public string Stanowisko { get; set; }
            public decimal Wynagrodzenie { get; set; }
            public string DniUrlopowe { get; set; }


            public static tableView From(Pracownik pracownik, Dzial dzial, Kraj_pochodzenia kraj, Dni_urlopowe urlop)
            {
                return new tableView
                {
                    Imie = pracownik.imie,
                    Nazwisko = pracownik.nazwisko,
                    NrTelefonu = pracownik.nr_tel,
                    PESEL = pracownik.PESEL,
                    Kraj = kraj.kraj,
                    Dzial = dzial.dzial1,
                    Stanowisko = dzial.stanowisko,
                    Wynagrodzenie = (decimal)dzial.wyplata,
                    DniUrlopowe = urlop.dni_url,
                };
            }
        }
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void refresh_Click(object sender, RoutedEventArgs e)
        {
            WorkersEntities x = new WorkersEntities();
            var zapytanie = from worker in x.Pracownik
                            join dzial in x.Dzial on worker.dzial_id equals dzial.id
                            join dn_url in x.Dni_urlopowe on worker.urlop_id equals dn_url.id
                            join kraj in x.Kraj_pochodzenia on worker.kraj_id equals kraj.id

                            select new tableView
                            {
                                Imie = worker.imie,
                                Nazwisko = worker.nazwisko,
                                NrTelefonu = worker.nr_tel,
                                PESEL = worker.PESEL,
                                Kraj = kraj.kraj,
                                Dzial = dzial.dzial1,
                                Stanowisko = dzial.stanowisko,
                                Wynagrodzenie = (decimal)dzial.wyplata,
                                DniUrlopowe = dn_url.dni_url,
                            };

            ObservableCollection<tableView> values = new ObservableCollection<tableView>(zapytanie.ToList());
            dataGrid.ItemsSource = values;

        }
    }
}
