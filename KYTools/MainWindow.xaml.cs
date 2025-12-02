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

namespace KYTools
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

        private void ButtonOpenCidrCalculator_Click(object sender, RoutedEventArgs e)
        {
            CIDRCalWindow CW = new CIDRCalWindow();
            if(CW.ShowDialog() == true)
            {
            }
        }

        private void ButtonDNSChecker_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}