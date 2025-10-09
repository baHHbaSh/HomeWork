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
            return Math.Pow(1-Math.Tan(x), 1/Math.Tan(x))+Math.Cos(x-y);
        }

        private void Calculate(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(X.Text, out double x) && double.TryParse(Y.Text, out double y))
            {
                double MathResult = SomeMathFunc(x, y);
                Result.Content = $"Результат: {MathResult}";
            }
        }
    }
}