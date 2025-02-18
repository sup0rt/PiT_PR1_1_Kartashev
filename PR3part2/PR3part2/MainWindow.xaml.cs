using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
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

namespace PR3part2
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

        private void calculate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double result = 0;
                double value1 = double.Parse(volt.Text);
                double value2 = double.Parse(om.Text);

                if (power.IsChecked == true) 
                {
                    result = value1 / value2;
                    answer.Content = $"Сила тока = {result:F2} A";
                }
                else if (voltage.IsChecked == true)
                {
                    result = value1 * value2;
                    answer.Content = $"Напряжение = {result:F2} V";
                }
                else if (resist.IsChecked == true)
                {
                    result = value1 / value2;
                    answer.Content = $"Сопротивление = {result:F2} Ω";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка ввода данных! Убедитесь, что введены корректные числа.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        
        private void power_Checked(object sender, RoutedEventArgs e)
        {
            lblVolt.Content = "Напряжение (Вольт):";
            lblOm.Content = "Сопротивление (Ом):";
        }

        private void voltage_Checked(object sender, RoutedEventArgs e)
        {
            lblVolt.Content = "Сила тока (Ампер):";
            lblOm.Content = "Сопротивление (Ом):";
        }

        private void resist_Checked(object sender, RoutedEventArgs e)
        {
            lblVolt.Content = "Напряжение (Вольт):";
            lblOm.Content = "Сила тока (Ампер):";
        }
    }
}
