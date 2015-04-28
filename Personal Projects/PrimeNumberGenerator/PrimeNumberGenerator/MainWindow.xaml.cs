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

namespace PrimeNumberGenerator
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

        private void generatePrime_Click(object sender, RoutedEventArgs e)
        {
            Random rand = new Random();
            while(true)
            {
                double n = rand.Next();
                if(IsPrime(n))
                {
                    infoBox.Text += n + " is prime." + "\r\n";
                    return;
                }
                else
                {
                    infoBox.Text += n + " is not prime." + "\r\n";
                }
            }
                
        }

        #region Primality Test from Wikipedia, url@http://en.wikipedia.org/wiki/Primality_test
        public static bool IsPrime(double n)
        {
            if (n <= 3)
            {
                return n > 1;
            }
            else if (n % 2 == 0 || n % 3 == 0)
            {
                return false;
            }
            for (ulong i = 5; i * i <= n; i += 6)
            {
                if (n % i == 0 || n % (i + 2) == 0)
                {
                    return false;
                }
            }
            return true;
        }
        #endregion
    }
}

