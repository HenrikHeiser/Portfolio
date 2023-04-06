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

namespace WpfZeugnisV2
{
    public delegate void INPUT_WERTEV2(string name1, string vorName, string geburtsOrt, string Datum);
    /// <summary>
    /// Interaktionslogik für erstellDaten.xaml
    /// </summary>
    public partial class erstellDaten : Window
    {
        public event INPUT_WERTEV2 OnClickV2;
        public erstellDaten()
        {
            InitializeComponent();
        }

        private void btn_save_Click(object sender, RoutedEventArgs e)
        {
            if(OnClickV2 != null)
            {
                OnClickV2(txtbx_ausbilder.Text, txtbx_ausstellungsOrt.Text, txtbx_leitungKBA.Text, date_ausstellungsDatum.Text);
            }
            
        }
    }
}
