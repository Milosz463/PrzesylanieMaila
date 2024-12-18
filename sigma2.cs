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

namespace WpfApp19
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string koszt;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (poczt.IsChecked == true) {
                cena.Text = koszt + "1zł";
                zdj.Source = new BitmapImage(new Uri("pocztowka.png", UriKind.Relative));
            }
            else if (lis.IsChecked == true)
            {
                cena.Text = koszt + "1.5zł";
                zdj.Source = new BitmapImage(new Uri("list.png", UriKind.Relative));
            }
           else if (pacz.IsChecked == true)
            {
                cena.Text = koszt + "10zł";
                zdj.Source = new BitmapImage(new Uri("paczka.png", UriKind.Relative));
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
          string  pocztowy=kod.Text;
            int kodPocztowy;
            if (!int.TryParse(pocztowy, out kodPocztowy)) {
                MessageBox.Show("W kodzie pocztowym nie moga byc litery");
                    }
            else
            {

                int dlugosc;
                dlugosc = kodPocztowy.ToString().Length;
            if (dlugosc == 5)
            {
                MessageBox.Show("Dane przesylki zostaly wprowadzone");
            }
            else if (dlugosc < 5 || dlugosc > 5)
            {
                MessageBox.Show("Nieprawidlowa liczba cyfr w kodzie pocztowym");
            }
        }


    }
    }
}
