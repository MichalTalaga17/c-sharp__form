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

namespace WpfApp1
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(bok_textbox.Text))
            {
                blad.Content = "Prosze wprowadzić bok";
                return;
            }
            if (!double.TryParse(bok_textbox.Text, out double bok) ) {
                blad.Content = "Błąd w formacie liczby";
                return;
            }

            double pole = bok * bok;
            double obwod = bok * 4;

            pole_textbox.Text = pole.ToString();
            obwod_textbox.Text = obwod.ToString();

            blad.Content = "";
                
            }
    }
}