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

namespace Bankautomat
{
    /// <summary>
    /// Interaktionslogik für MenuWindow.xaml
    /// </summary>
    public partial class MenuWindow : Window
    {

        //MainWindow mainWindowObjekt = new MainWindow();

        public MenuWindow()
        {
            InitializeComponent();
            //Diese Zeilen sind mehr oder weniger überflüssig, da wir direkt die zeilenKomponentinhalte in den string speichern könnten
            //Konto.aktuellerKontoNutzer.vorname = MainWindow.zeilenKomponente[0];
            //Konto.aktuellerKontoNutzer.nachname = MainWindow.zeilenKomponente[1];


            txtBegruessung.Content = "\t \tHallo " + Konto.aktuellerKontoNutzer.vorname + " " + Konto.aktuellerKontoNutzer.nachname + "! Bitte wählen Sie eine gewünschte Funktion aus";
        }
        private void btnAbmelden_Click(object sender, RoutedEventArgs e)
        {
            //Der Nutzer wird gefragt, ob er das Programm beenden möchte, wenn er 'Ja' wählt wird es beendet, bei 'Nein' läuft das Programm weiterhin
            MessageBoxResult result = MessageBox.Show("Möchten Sie sich sicher abmelden?", "Abmelden", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
               MainWindow mainWindowObjekt = new MainWindow();
               mainWindowObjekt.Show();
               this.Close();
            }
        }

        private void btnKontostandAbfragen_Click(object sender, RoutedEventArgs e)
        {
            KontostandWindow kontostandWindow = new KontostandWindow();
            kontostandWindow.Show();
            this.Close();
        }

        private void BtnEinzahlen_Click(object sender, RoutedEventArgs e)
        {
            EinzahlenWindow einzahlenWindow = new EinzahlenWindow();
            einzahlenWindow.Show();
            this.Close();
        }

        private void BtnAuszahlen_Click(object sender, RoutedEventArgs e)
        {
            AuszahlenWindow auszahlenWindow = new AuszahlenWindow();
            auszahlenWindow.Show();
            this.Close();
        }
    }
}
