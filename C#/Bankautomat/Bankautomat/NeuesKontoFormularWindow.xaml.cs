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
    /// Interaktionslogik für NeuesKontoFormularWindow.xaml
    /// </summary>
    public partial class NeuesKontoFormularWindow : Window
    {
        public NeuesKontoFormularWindow()
        {
            InitializeComponent();
        }

        private void BtnAnlegen_Click(object sender, RoutedEventArgs e)
        {
            string dateiname = Directory.GetCurrentDirectory() + "\\Konten.txt";
            FileStream fileStream = new FileStream(dateiname, FileMode.Append);
            StreamWriter streamWriter = new StreamWriter(fileStream);


            Konto neuesKonto = new Konto(txtVorname.Text, txtNachname.Text, txtPIN.Password);

            string pinVerify = txtPINVerify.Password;

            if (neuesKonto.pin == pinVerify)
            {
                streamWriter.WriteLine(neuesKonto.vorname + "#" + neuesKonto.nachname + "#" + "0" + "#" + neuesKonto.pin);
                streamWriter.Close();
                fileStream.Close();

                txtVorname.Text = "";
                txtNachname.Text = "";
                txtPIN.Password = "";
                txtPINVerify.Password = "";
                MessageBox.Show("Das Konto wurde erfolgreich angelegt", "Konto angelegt");

                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Die Passwörter stimmen nicht überein! \nBitte überprüfen Sie Ihre Eingaben", "Fehlermeldung");
            }
        }

        private void BtnAbbrechen_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void CheckTextBoxes(object sender, KeyEventArgs e)
        {
            if (txtVorname.Text != "" && txtNachname.Text != "" && txtPIN.Password != "" && txtPINVerify.Password != "")
            {
                BtnAnlegen.IsEnabled = true;
            }
        }
    }
}
