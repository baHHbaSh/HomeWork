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

namespace HomeWork
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
        private double SomeMathFunc(double x, double y)
        {
            return 1/Math.Tan((x-y)/Math.Pow(x+2, 1/3) + Math.Abs(2*x));
        }

        private void Calculate(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(X.Text, out double x) && double.TryParse(Y.Text, out double y))
            {
                double MathResult = SomeMathFunc(x, y);
                Result.Content = $"Результат: {MathResult}";
            }
        }
        private void TwoCalculate(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(X.Text, out double x) && double.TryParse(Y.Text, out double y))
            {
                bool MathResult = x >= -2 && x <= 3 && y >= 2 && y <= 5 || x >= 3 && x <= 5 && y >= 2 && y <= 3;
                TwoResult.Content = $"Результат: {MathResult}";
            }
        }
    }
}