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

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private double number1 = 0;
        private double number2 = 0;
        private string operation = "";
        public MainWindow()
        {
            InitializeComponent();

        }

        private void Button0(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10);
                ergeb.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10);
            }
        }

        private void Button1(object sender, RoutedEventArgs e)
        {
            if(operation == "")
            {
                number1 = (number1 * 10) + 1;
                ergeb.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 1;
                ergeb.Text = number2.ToString();
            }

        }

        private void Button2(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 2;
                ergeb.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 2;
                ergeb.Text = number2.ToString();
            }
        }

        private void Button3(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 3;
                ergeb.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 3;
                ergeb.Text = number2.ToString();
            }
        }

        private void Button4(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 4;
                ergeb.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 4;
                ergeb.Text = number2.ToString();
            }
        }

        private void Button5(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 5;
                ergeb.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 5;
                ergeb.Text = number2.ToString();
            }
        }

        private void Button6(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 6;
                ergeb.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 6;
                ergeb.Text = number2.ToString();
            }
        }

        private void Button7(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 7;
                ergeb.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 7;
                ergeb.Text = number2.ToString();
            }
        }

        private void Button8(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 8;
                ergeb.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 8;
                ergeb.Text = number2.ToString();
            }
        }

        private void Button9(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 9;
                ergeb.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 9;
                ergeb.Text = number2.ToString();
            }
        }



        private void Ergebnis(object sender, TextChangedEventArgs e)
        {

        }

        private void gleich(object sender, RoutedEventArgs e)
        {
           
            switch (operation)
            {
                case "+":
                    ergeb.Text = (number1 + number2).ToString();
                    break;
                case "-":
                    ergeb.Text = (number1 - number2).ToString();
                    break;
                case "*":
                    ergeb.Text = (number1 * number2).ToString();
                    break;
                case "/":
                    ergeb.Text = (number1 / number2).ToString();
                    break;
                case "%":
                    ergeb.Text = (number1 % number2).ToString();
                    break;
            }
        }

        private void plus(object sender, RoutedEventArgs e)
        {
            operation = "+";
            ergeb.Text = operation.ToString();
        }

        private void minus_Click(object sender, RoutedEventArgs e)
        {
            operation = "-";
            ergeb.Text = operation.ToString();
        }

        private void geteilt_Click(object sender, RoutedEventArgs e)
        {
            operation = "/";
            ergeb.Text = operation.ToString();
        }

        private void mall(object sender, RoutedEventArgs e)
        {
            operation = "*";
            ergeb.Text = operation.ToString();
        }

        private void mod(object sender, RoutedEventArgs e)
        {
            operation = "%";
            ergeb.Text = operation.ToString();
        }

        private void Cv_Click(object sender, RoutedEventArgs e)
        {
            number1 = 0;
            number2 = 0;
            operation = "";
            ergeb.Text = operation.ToString();
        }

       private void modulo_Click(object sender,RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = 0;
                ergeb.Text = "0";
            }
            else
            {
                number2 = 0;
                ergeb.Text = "0";
            }
        }
    }
}
