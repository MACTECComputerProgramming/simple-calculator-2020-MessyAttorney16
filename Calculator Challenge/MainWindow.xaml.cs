using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
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

namespace Calculator_Challenge
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

        private void buttonAdd_Click(object sender, RoutedEventArgs e)
        {
            //ADDITION
            double number1 = 0, number2 = 0, total = 0;

            number1 = Convert.ToDouble(textBox1.Text);

            number2 = Convert.ToDouble(textBox2.Text);

            total = number1 + number2;

            label1.Content = total;
        }

        private void buttonSubtract_Click(object sender, RoutedEventArgs e)
        {
            //SUBTRACTION
            double number1 = 0, number2 = 0, total = 0;

            number1 = Convert.ToDouble(textBox1.Text);

            number2 = Convert.ToDouble(textBox2.Text);

            total = number1 - number2;

            label1.Content = total;
        }

        private void buttonMultiply_Click(object sender, RoutedEventArgs e)
        {
            //MULTIPLICATION
            double number1 = 0, number2 = 0, total = 0;

            number1 = Convert.ToDouble(textBox1.Text);

            number2 = Convert.ToDouble(textBox2.Text);

            total = number1 * number2;

            label1.Content = total;
        }

        private void buttonDivide_Click(object sender, RoutedEventArgs e)
        {
            //DIVISION
            double number1 = 0, number2 = 0, total = 0;

            number1 = Convert.ToDouble(textBox1.Text);

            number2 = Convert.ToDouble(textBox2.Text);

            total = number1 / number2;

            label1.Content = total;
        }

        private void buttonModulus_Click(object sender, RoutedEventArgs e)
        {
            //MODULUS
            double number1 = 0, number2 = 0, total = 0;

            number1 = Convert.ToDouble(textBox1.Text);

            number2 = Convert.ToDouble(textBox2.Text);

            total = number1 % number2;

            label1.Content = total;
        }

        private void buttonClear_Click(object sender, RoutedEventArgs e)
        {
            //CLEAR
            label1.Content = "";

            textBox1.Text = "";

            textBox2.Text = "";
        }
    }
}
