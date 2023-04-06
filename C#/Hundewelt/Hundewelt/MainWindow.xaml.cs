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

namespace Hundewelt
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            drpdwn_rasse.Items.Add("Labrador");
            drpdwn_rasse.Items.Add("Mops");
            drpdwn_rasse.Items.Add("Golden Retriever");
            drpdwn_rasse.Items.Add("Pitbull");
            drpdwn_rasse.Items.Add("Pudel");
        }

        hund DerBoy = new hund();

        private void btn_anlegen_Click(object sender, RoutedEventArgs e)
        {
            DerBoy.name = txtbx_name.Text;
            DerBoy.age = Convert.ToInt32(txtbx_age.Text);
            DerBoy.race = drpdwn_rasse.Text;
            if(rdbtn_mnl.IsChecked == true)
            {
                DerBoy.gender = Convert.ToString(rdbtn_mnl.Content);
            }
            else if (rdbtn_wbl.IsChecked == true)
            {
                DerBoy.gender = Convert.ToString(rdbtn_wbl.Content);
            }
            lstbx_values.Items.Add(DerBoy.name);
        }

        private void btn_bellen_Click(object sender, RoutedEventArgs e)
        {
            lbl_ausgabe.Content = lstbx_values.SelectedItem + DerBoy.Bellen();
        }

        private void btn_fressen_Click(object sender, RoutedEventArgs e)
        {
            lbl_ausgabe.Content = lstbx_values.SelectedItem + DerBoy.Fressen();
        }

        private void lstbx_values_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            btn_bellen.Visibility = Visibility.Visible;
            btn_fressen.Visibility = Visibility.Visible;
        }
    }
}
