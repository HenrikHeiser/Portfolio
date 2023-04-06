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

namespace Bankautomat
{
    /// <summary>
    /// Interaktionslogik für KontostandWindow.xaml
    /// </summary>
    public partial class KontostandWindow : Window
    {
        //MainWindow mainWindowObjekt = new MainWindow();

        public KontostandWindow()
        {
            InitializeComponent();
            
            double kontostand = Konto.aktuellerKontoNutzer.KontostandAbfragen();
            txtBetrag.Text = Convert.ToString(kontostand) + " €";
        }

        private void BtnAbmelden_Click(object sender, RoutedEventArgs e)
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

        private void BtnZurueck_Click(object sender, RoutedEventArgs e)
        {
            MenuWindow menuWindow = new MenuWindow();
            menuWindow.Show();
            this.Close();
        }
    }
}
