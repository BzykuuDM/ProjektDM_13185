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
        private int ID = 0;
        public class tableView
        {
            public int ID { get; set; }
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
                    ID = pracownik.id,
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
                                ID = worker.id,
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
        private void dataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (dataGrid.SelectedIndex >= 0)
            {
                if (dataGrid.SelectedItems.Count >= 0)
                {
                    if (dataGrid.SelectedItems[0].GetType() == typeof(tableView))
                    {
                        tableView data = (tableView)dataGrid.SelectedItems[0];
                        ID = data.ID;
                    }
                }
            }
        }

        private void delete_Click(object sender, RoutedEventArgs e)
        {
            WorkersEntities x = new WorkersEntities();
            tableView data = dataGrid.SelectedItem as tableView;
            var zapytanie = from worker in x.Pracownik
                            where worker.id == ID
                            select worker;

            Pracownik usun = zapytanie.SingleOrDefault();
            if(delete != null)
            {
                IList<tableView> tableViews = dataGrid.ItemsSource as IList<tableView>;
                if(tableViews != null)
                {
                    x.Pracownik.Remove(usun);
                    x.SaveChanges();
                    tableViews.Remove(data);
                }
                dataGrid.ItemsSource = null;
                dataGrid.ItemsSource = tableViews;
            }
            

        }


    }
}
