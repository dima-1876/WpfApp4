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

namespace WpfApp4.View.Pages.Main_Page
{
    /// <summary>
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void test_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ButtonState == MouseButtonState.Pressed)
            {

            }
        }

        private void BtnTest1_Click(object sender, RoutedEventArgs e)
        {
            BtnTest1.Visibility= Visibility.Hidden;
        }

        private void Btn2_Click(object sender, RoutedEventArgs e)
        {
            Btn2.Visibility = Visibility.Hidden;
        }
        private void Btn3_Click(object sender, RoutedEventArgs e)
        {
            Btn3.Visibility = Visibility.Hidden;
        }
        private void Btn4_Click(object sender, RoutedEventArgs e)
        {
            Btn4.Visibility = Visibility.Hidden;
        }
        private void Btn5_Click(object sender, RoutedEventArgs e)
        {
            Btn5.Visibility = Visibility.Hidden;
        }
        private void Btn6_Click(object sender, RoutedEventArgs e)
        {
            Btn6.Visibility = Visibility.Hidden;
        }
        private void Btn7_Click(object sender, RoutedEventArgs e)
        {
            Btn7.Visibility = Visibility.Hidden;
        }
        private void Btn8_Click(object sender, RoutedEventArgs e)
        {
            Btn8.Visibility = Visibility.Hidden;
        }
        private void Btn9_Click(object sender, RoutedEventArgs e)
        {
            Btn9.Visibility = Visibility.Hidden;
        }
        private void Btn10_Click(object sender, RoutedEventArgs e)
        {
            Btn10.Visibility = Visibility.Hidden;
        }
        private void Btn11_Click(object sender, RoutedEventArgs e)
        {
            Btn11.Visibility = Visibility.Hidden;
        }
        private void Btn12_Click(object sender, RoutedEventArgs e)
        {
            Btn12.Visibility = Visibility.Hidden;
        }
        private void Btn13_Click(object sender, RoutedEventArgs e)
        {
            Btn13.Visibility = Visibility.Hidden;
        }
        private void Btn14_Click(object sender, RoutedEventArgs e)
        {
            Btn14.Visibility = Visibility.Hidden;
        }
    }
}
