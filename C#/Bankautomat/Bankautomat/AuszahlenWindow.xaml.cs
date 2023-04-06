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
using System.IO;

namespace Bankautomat
{
    /// <summary>
    /// Interaktionslogik für AuszahlenWindow.xaml
    /// </summary>
    public partial class AuszahlenWindow : Window
    {
        public AuszahlenWindow()
        {
            InitializeComponent();
        }

        private void BtnAuszahlen_Click(object sender, RoutedEventArgs e)
        {
            double betrag = Convert.ToDouble(txtBetrag.Text);

            string dateiname = Directory.GetCurrentDirectory() + "\\Konten.txt";

            List<string> zwischenSpeicherListe = File.ReadAllLines(dateiname).ToList();

            int index = 0;
            foreach (string zeile in zwischenSpeicherListe)
            {
                Konto.aktuellerKontoNutzer.vorname = MainWindow.zeilenKomponente[0];
                Konto.aktuellerKontoNutzer.nachname = MainWindow.zeilenKomponente[1];
                Konto.aktuellerKontoNutzer.kontostand = Convert.ToDouble(MainWindow.zeilenKomponente[2]);
                Konto.aktuellerKontoNutzer.pin = MainWindow.zeilenKomponente[3];

                if (zeile.Contains(Konto.aktuellerKontoNutzer.vorname) && zeile.Contains(Konto.aktuellerKontoNutzer.nachname))
                {
                    zwischenSpeicherListe.RemoveAt(index);

                    Konto.aktuellerKontoNutzer.kontostand = Konto.aktuellerKontoNutzer.Auszahlen(betrag);

                    zwischenSpeicherListe.Add(Konto.aktuellerKontoNutzer.vorname + "#" + Konto.aktuellerKontoNutzer.nachname + "#" + Konto.aktuellerKontoNutzer.kontostand + "#" + Konto.aktuellerKontoNutzer.pin);
                    File.WriteAllLines(dateiname, zwischenSpeicherListe);
                    MessageBox.Show("Ihr Betrag wurde erfolgreich ausgezahlt.\n\nSie werden nun abgemeldet.", "Auszahlung erfolgreich");

                    MainWindow mainWindow = new MainWindow();
                    mainWindow.Show();
                    this.Close();

                    break;
                }
                index++;
            }
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            MenuWindow menuWindow = new MenuWindow();
            menuWindow.Show();
            this.Close();
        }
    }
}
