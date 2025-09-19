using System.Text;
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

namespace Projekt1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        public void Akcja(object sender, RoutedEventArgs e)
        {
           string tekst1 = jeden.Text;

           dwa.Text = tekst1;
        }

        private void Zapisz(object sender, RoutedEventArgs e)
        {
            string tekst = jeden.Text;
            // File.WriteAllText("log.txt", tekst);
            File.AppendAllText("log.txt", tekst);

        }
    }
}