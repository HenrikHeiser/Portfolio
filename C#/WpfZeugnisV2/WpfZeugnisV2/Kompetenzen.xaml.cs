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

namespace WpfZeugnisV2
{
    /// <summary>
    /// Interaktionslogik für Kompetenzen.xaml
    /// </summary>
    public partial class Kompetenzen : Window
    {
        private void FileStream(string note)
        {
            FileStream notenDatei;
            notenDatei = new FileStream(@"C:\Users\HEISERH\Desktop\Zeugnis.txt", FileMode.Append);
            StreamWriter stift = new StreamWriter(notenDatei);
            stift.Write(note);
            stift.Close();
            notenDatei.Close();
        }
        public Kompetenzen()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            string note = "Kompetenz 1;Sehr Gut;\n";
            FileStream(note);
        }

        private void btn_1_2_Click(object sender, RoutedEventArgs e)
        {
            string note = "Kompetenz 1;Gut;\n";
            FileStream(note);
        }

        private void btn_1_3_Click(object sender, RoutedEventArgs e)
        {
            string note = "Kompetenz 1;Befriedigend;\n";
            FileStream(note);
        }

        private void btn_1_4_Click(object sender, RoutedEventArgs e)
        {
            string note = "Kompetenz 1;Ausreichend;\n";
            FileStream(note);
        }

        private void btn_1_5_Click(object sender, RoutedEventArgs e)
        {
            string note = "Kompetenz 1;Mangelhaft;\n";
            FileStream(note);
        }

        private void btn_2_1_Click(object sender, RoutedEventArgs e)
        {
            string note = "Kompetenz 2;Sehr Gut;\n";
            FileStream(note);
        }

        private void btn_2_2_Click(object sender, RoutedEventArgs e)
        {
            string note = "Kompetenz 2;Gut;\n";
            FileStream(note);
        }

        private void btn_2_3_Click(object sender, RoutedEventArgs e)
        {
            string note = "Kompetenz 2;Befriedigend;\n";
            FileStream(note);
        }

        private void btn_2_4_Click(object sender, RoutedEventArgs e)
        {
            string note = "Kompetenz 2;Ausreichend;\n";
            FileStream(note);
        }

        private void btn_2_5_Click(object sender, RoutedEventArgs e)
        {
            string note = "Kompetenz 2;Mangelhaft;\n";
            FileStream(note);
        }

        private void btn_3_1_Click(object sender, RoutedEventArgs e)
        {
            string note = "Kompetenz 3;Sehr Gut;\n";
            FileStream(note);
        }

        private void btn_3_2_Click(object sender, RoutedEventArgs e)
        {
            string note = "Kompetenz 3;Gut;\n";
            FileStream(note);
        }

        private void btn_3_3_Click(object sender, RoutedEventArgs e)
        {
            string note = "Kompetenz 3;Befriedigend;\n";
            FileStream(note);
        }

        private void btn_3_4_Click(object sender, RoutedEventArgs e)
        {
            string note = "Kompetenz 3;Ausreichend;\n";
            FileStream(note);
        }

        private void btn_3_5_Click(object sender, RoutedEventArgs e)
        {
            string note = "Kompetenz 3;Mangelhaft;\n";
            FileStream(note);
        }

        private void btn_4_1_Click(object sender, RoutedEventArgs e)
        {
            string note = "Kompetenz 4;Sehr Gut;\n";
            FileStream(note);
        }

        private void btn_4_2_Click(object sender, RoutedEventArgs e)
        {
            string note = "Kompetenz 4;Gut;\n";
            FileStream(note);
        }

        private void btn_4_3_Click(object sender, RoutedEventArgs e)
        {
            string note = "Kompetenz 4;Befriedigend;\n";
            FileStream(note);
        }

        private void btn_4_4_Click(object sender, RoutedEventArgs e)
        {
            string note = "Kompetenz 4;Ausreichend;\n";
            FileStream(note);
        }

        private void btn_4_5_Click(object sender, RoutedEventArgs e)
        {
            string note = "Kompetenz 4;Mangelhaft;\n";
            FileStream(note);
        }

        private void btn_5_1_Click(object sender, RoutedEventArgs e)
        {
            string note = "Kompetenz 5;Sehr Gut;\n";
            FileStream(note);
        }

        private void btn_5_2_Click(object sender, RoutedEventArgs e)
        {
            string note = "Kompetenz 5;Gut;\n";
            FileStream(note);
        }

        private void btn_5_3_Click(object sender, RoutedEventArgs e)
        {
            string note = "Kompetenz 5;Befriedigend;\n";
            FileStream(note);
        }

        private void btn_5_4_Click(object sender, RoutedEventArgs e)
        {
            string note = "Kompetenz 5;Ausreichend;\n";
            FileStream(note);
        }

        private void btn_5_5_Click(object sender, RoutedEventArgs e)
        {
            string note = "Kompetenz 5;Mangelhaft;\n";
            FileStream(note);
            
        }
    }
}
