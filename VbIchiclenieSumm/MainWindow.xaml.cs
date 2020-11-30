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

namespace VbIchiclenieSumm
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

        public static double Usl(int j)
        {
            double factorial = 1;
            for (int i = 2; i <= j; i++)
            {
                factorial *= i;
            }
            return factorial;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                bool check = int.TryParse(Box1.Text, out _) && double.TryParse(Box2.Text, out _);
                if (check)
                {
                    double sum = 0;
                    var a = int.Parse(Box1.Text);
                    var x = int.Parse(Box2.Text);
                    for (int i = 1; i <= a; i++)
                    
                    {
                        sum += -(Math.Sqrt(x + 1) * Math.Pow(x, i) / Usl(i));
                    }
                    Result.Text = $"Сумма {a} рядов = {1 + sum}";
                }
                else Result.Text = "Введены некорректные данные";
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
    }
}
