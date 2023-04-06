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
using System.IO;

namespace Bankautomat
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>

    public partial class MainWindow : Window
    {
        FileStream filestream;
        StreamReader reader;

        //public Konto aktuellerKontoNutzer = new Konto();

        private static readonly string dateiname = Directory.GetCurrentDirectory() + "\\Konten.txt";

        public string zeile;
        public static string[] zeilenKomponente;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void kontenEinlesen()
        {
            filestream = new FileStream(dateiname, FileMode.Open);
            reader = new StreamReader(filestream);
        }

        private void BtnInformation_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Dieses Projekt wurde von Hesham Osman und Maurice Hofmann erstellt.", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        public void btnBestaetigung_Click(object sender, RoutedEventArgs e)
        {
            kontenEinlesen();

            while (reader.EndOfStream == false)
            {
                zeile = reader.ReadLine();
                zeilenKomponente = zeile.Split('#');

                Konto.aktuellerKontoNutzer.vorname = zeilenKomponente[0];
                Konto.aktuellerKontoNutzer.nachname = zeilenKomponente[1];
                Konto.aktuellerKontoNutzer.kontostand = Convert.ToDouble(zeilenKomponente[2]);
                Konto.aktuellerKontoNutzer.pin = zeilenKomponente[3];

                string benutzername = Konto.aktuellerKontoNutzer.vorname + Konto.aktuellerKontoNutzer.nachname;

                string benutzernameEingabe = txtBenutzername.Text;
                string pinEingabe = txtPIN.Password;

                if(benutzernameEingabe == benutzername && pinEingabe == Konto.aktuellerKontoNutzer.pin)
                {
                    MenuWindow menuWindow = new MenuWindow();
                    menuWindow.Show();
                    this.Close();
                    reader.Close();
                    return;
                }
            }
            MessageBox.Show("Passwort fehlgeschlagen! Bitte versuchen Sie es erneut.", "Passwort fehlgeschlagen", MessageBoxButton.OK, MessageBoxImage.Warning);
            reader.Close();
            txtPIN.Password = "";
        }

        private void btnNeuesKonto_Click(object sender, RoutedEventArgs e)
        {
            NeuesKontoFormularWindow neuesKontoFormularWindow = new NeuesKontoFormularWindow();
            neuesKontoFormularWindow.Show();
            this.Close();
        }
    }
}
