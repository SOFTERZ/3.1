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

namespace _3._1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        public static double Factorial(int n)
        {
            double res = 1;
            for (int i = 2; i <= n; i++)
            {
                res *= i;
            }
            return res;
        }

        private void Calculate_Click(object sender, RoutedEventArgs e)
        {
            double Z, Zr;
            Zr = 1;
            int k = int.Parse(BlockCount.Text);
            bool Check = int.TryParse(BlockCount.Text, out _);
            if (Check)
            {
                for (int n = -3; n <= k; n++)
                {
                    Z = (n + 2) * Math.Abs(n - 4) / Factorial(n + 3);
                    if (Z == 0) continue;
                    if ((n + 3) <= 0) continue;
                    Zr *= Z;
                }
                Result.Text = Convert.ToString(Zr);
            }
            else Result.Text = "Введено недопустимое значение k";

        }
    }
}