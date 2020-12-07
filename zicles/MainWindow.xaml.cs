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

namespace zicles
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int n = int.Parse(input.Text);
                if (Summa.IsChecked == true)
                {
                    int S = 0;
                    int i = 1;
                    while (i <= n)
                    {
                        S += i;
                        i++;
                    }
                    Result.Text = "Сумма чисел от 1 до " + n + " равна:" + S;
                }
                else
                {
                    int P = 1;
                    int i = 1;
                    while (i <= n)
                    {
                        P *= i;
                        i++;
                    }
                    Result.Text = "Факториал " + n + " равен:" + P;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                int n = int.Parse(input.Text);
                if (Summa.IsChecked == true)
                {
                    int S = 0;
                    int i = 1;
                    do
                    {
                        S += i;
                        i++;
                    }
                    while (i <= n);
                    Result.Text = "Сумма чисел от 1 до " + n + " равен:" + S;
                }
                else
                {
                    int P = 1;
                    int i = 1;
                    do
                    {
                        P *= i;
                        i++;
                    }
                    while (i <= n);
                    Result.Text = "Факториал " + n + " равна:" + P;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            try
            {
                int n = int.Parse(input.Text);
                if (Summa.IsChecked == true)
                {
                    int S = 0;
                    for (int i = 1; i <= n; i++) S += i;
                    Result.Text = "Сумма чисел от 1 до " + n + " равна:" + S;
                }
                else
                {
                    int P = 1;
                    for (int i = 1; i <= n; i++) P *= i;
                    Result.Text = "Факториал " + n + " равен:" + P;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
