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
    
    public delegate void INPUT_WERTE(string name1, string vorName, string geburtsOrt, string geburtsTag, bool ModerW2);
    public delegate void INPUT_BOOL(bool ModerW);
    public delegate void INPUT_GB(int gb);
    /// <summary>
    /// Interaktionslogik für persDaten.xaml
    /// </summary>
    public partial class persDaten : Window
    {
        public event INPUT_WERTE OnClick;
        public event INPUT_BOOL BoolClick;
        public event INPUT_GB GBClick;
        public persDaten()
        {
            InitializeComponent();
        }

        public void btn_save_Click(object sender, RoutedEventArgs e)
        {
            if(OnClick != null)
            {
                OnClick(txtbx_name.Text,
                        txtbx_vorname.Text,
                        txtbx_geburtsort.Text,
                        date_birthday.Text, (bool) radiobtn_M.IsChecked);
                if (BoolClick != null)
                {
                    BoolClick((bool)radiobtn_M.IsChecked);
                }
            }
            
        }

        private void radiobtn_W_Checked_1(object sender, RoutedEventArgs e)
        {

        }

        private void radiobtn_M_Checked(object sender, RoutedEventArgs e)
        {

        }
    }
}
