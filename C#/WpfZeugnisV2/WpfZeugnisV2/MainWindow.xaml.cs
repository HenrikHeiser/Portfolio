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

namespace WpfZeugnisV2
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        public void eintragenListe(string name, string vorName, string geburtsOrt, string geburtsTag, bool ModerW)
        {
            label_infos.Content = (name, " ", vorName, "\n", geburtsOrt, geburtsTag);
                if (ModerW == true)
            {
                label_infos.Content = label_infos.Content + "Männlich";
            }
            else
            {
                label_infos.Content = label_infos.Content + "Weiblich";
            }
            
        }
        
       /* public void eintragenListe2(bool ModerW)
        {
            if (ModerW == true)
            {
                label_ModerW.Content = "Männlich";
            }
            else
            {
                label_ModerW.Content = "Weiblich";
            }
        }
       */
        private void eintragenListe3(string name, string vorName, string geburtsOrt, string Datum)
        {
            label_erstellDaten.Content = (name, " ", vorName, "\n", geburtsOrt, Datum);
        }
        private void btn_pers_daten_Click(object sender, RoutedEventArgs e)
        {
            persDaten form = new persDaten();
            form.OnClick += eintragenListe;
           // form.BoolClick += eintragenListe2;
            form.Show();
        }

        private void btn_erstell_daten_Click(object sender, RoutedEventArgs e)
        {
            erstellDaten form = new erstellDaten();
            form.OnClickV2 += eintragenListe3;
            form.Show();
        }

        private void btn_kompetenzen_Click(object sender, RoutedEventArgs e)
        {
            Kompetenzen form = new Kompetenzen();
            form.Show();
        }

        private void btn_aubildungsInfos_Click(object sender, RoutedEventArgs e)
        {
            Ausbildungsinfo form = new Ausbildungsinfo();
            form.Show();
        }
    }
}
