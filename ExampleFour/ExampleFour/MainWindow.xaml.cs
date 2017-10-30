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

namespace ExampleFour
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<string> numberList;
        double a, b;
        double c;
        bool isPoint = false, isOperator = false, isPlus = false, isMinus = false, isMultiply = false, isDivide = false, isZero = false, isPrecent = false;


        public MainWindow()
        {
            InitializeComponent();
            numberList = new List<string>();
        }

        private void OneButton_Click(object sender, RoutedEventArgs e)
        {
            if (!isZero)
            {
                digitsForCalculationTextBlock.Text += "1";
            }
            else
            {
                digitsForCalculationTextBlock.Text = "";
                digitsForCalculationTextBlock.Text += "1";
                isZero = false;
            }
        }

        private void TwoButton_Click(object sender, RoutedEventArgs e)
        {
            if (!isZero)
            {
                digitsForCalculationTextBlock.Text += "2";
            }
            else
            {
                digitsForCalculationTextBlock.Text = "";
                digitsForCalculationTextBlock.Text += "2";
                isZero = false;
            }
        }

        private void ThreeButton_Click(object sender, RoutedEventArgs e)
        {
            if (!isZero)
            {
                digitsForCalculationTextBlock.Text += "3";
            }
            else
            {
                digitsForCalculationTextBlock.Text = "";
                digitsForCalculationTextBlock.Text += "3";
                isZero = false;
            }
        }

        private void ZeroButton_Click(object sender, RoutedEventArgs e)
        {
            if (!isZero)
            {
                digitsForCalculationTextBlock.Text += "0";
            }
            else
            {
                digitsForCalculationTextBlock.Text = "";
                digitsForCalculationTextBlock.Text += "0";
                isZero = false;
            }
        }

        private void FourButton_Click(object sender, RoutedEventArgs e)
        {
            if (!isZero)
            {
                digitsForCalculationTextBlock.Text += "4";
            }
            else
            {
                digitsForCalculationTextBlock.Text = "";
                digitsForCalculationTextBlock.Text += "4";
                isZero = false;
            }
        }

        private void FiveButton_Click(object sender, RoutedEventArgs e)
        {
            if (!isZero)
            {
                digitsForCalculationTextBlock.Text += "5";
            }
            else
            {
                digitsForCalculationTextBlock.Text = "";
                digitsForCalculationTextBlock.Text += "5";
                isZero = false;
            }
        }

        private void SixButton_Click(object sender, RoutedEventArgs e)
        {
            if (!isZero)
            {
                digitsForCalculationTextBlock.Text += "6";
            }
            else
            {
                digitsForCalculationTextBlock.Text = "";
                digitsForCalculationTextBlock.Text += "6";
                isZero = false;
            }
        }

        private void DoubleZeroButton_Click(object sender, RoutedEventArgs e)
        {
            if (!isZero)
            {
                digitsForCalculationTextBlock.Text += "00";
            }
            else
            {
                digitsForCalculationTextBlock.Text = "";
                digitsForCalculationTextBlock.Text += "00";
                isZero = false;
            }
        }

        private void SevenButton_Click(object sender, RoutedEventArgs e)
        {
            if (!isZero)
            {
                digitsForCalculationTextBlock.Text += "7";
            }
            else
            {
                digitsForCalculationTextBlock.Text = "";
                digitsForCalculationTextBlock.Text += "7";
                isZero = false;
            }
        }

        private void EightButton_Click(object sender, RoutedEventArgs e)
        {
            if (!isZero)
            {
                digitsForCalculationTextBlock.Text += "8";
            }
            else
            {
                digitsForCalculationTextBlock.Text = "";
                digitsForCalculationTextBlock.Text += "8";
                isZero = false;
            }
        }

        private void NineButton_Click(object sender, RoutedEventArgs e)
        {
            if (!isZero)
            {
                digitsForCalculationTextBlock.Text += "9";
            }
            else
            {
                digitsForCalculationTextBlock.Text = "";
                digitsForCalculationTextBlock.Text += "9";
                isZero = false;
            }
        }
        private void PointButton_Click(object sender, RoutedEventArgs e)
        {
            if (!isZero)
            {
                if (!isPoint)
                {
                    if (digitsForCalculationTextBlock.Text == "")
                    {
                        digitsForCalculationTextBlock.Text += "0.";
                    }
                    else
                    {
                        digitsForCalculationTextBlock.Text += ".";
                    }
                    isPoint = true;
                }
            }
            else
            {
                if (!isPoint)
                {
                    digitsForCalculationTextBlock.Text = "";
                    if (digitsForCalculationTextBlock.Text == "")
                    {
                        digitsForCalculationTextBlock.Text += "0.";
                    }
                    else
                    {
                        digitsForCalculationTextBlock.Text += ".";
                    }
                    isZero = false;
                    isPoint = true;
                }
            }
        }
        private void PlusButton_Click(object sender, RoutedEventArgs e)
        {
            isPoint = false;
            if (digitsForCalculationTextBlock.Text != "")
            {
                if (!isOperator)
                {
                    numberList.Clear();
                    numberList.Add(digitsForCalculationTextBlock.Text);
                    digitsForCalculationTextBlock.Text = "0";
                    isZero = true;
                    isOperator = true;
                    isPlus = true;
                    operatorsLabel.Content = "+";
                }
                else
                {
                    if (isPlus)
                    {
                        numberList.Add(digitsForCalculationTextBlock.Text);
                        a = Convert.ToDouble(numberList[0]);
                        b = Convert.ToDouble(numberList[1]);
                        digitsForCalculationTextBlock.Text = (a + b).ToString();
                        isPlus = false;
                        isOperator = false;
                        isZero = false;
                        operatorsLabel.Content = "=";
                    }
                    else if (isMinus)
                    {
                        numberList.Add(digitsForCalculationTextBlock.Text);
                        a = Convert.ToDouble(numberList[0]);
                        b = Convert.ToDouble(numberList[1]);
                        digitsForCalculationTextBlock.Text = (a - b).ToString();
                        isMinus = false;
                        isOperator = false;
                        isZero = false;
                        operatorsLabel.Content = "=";
                    }
                    else if (isMultiply)
                    {
                        numberList.Add(digitsForCalculationTextBlock.Text);
                        a = Convert.ToDouble(numberList[0]);
                        b = Convert.ToDouble(numberList[1]);
                        digitsForCalculationTextBlock.Text = (a * b).ToString();
                        isMultiply = false;
                        isOperator = false;
                        isZero = false;
                        operatorsLabel.Content = "=";
                    }
                    else if (isDivide)
                    {
                        numberList.Add(digitsForCalculationTextBlock.Text);
                        a = Convert.ToDouble(numberList[0]);
                        b = Convert.ToDouble(numberList[1]);
                        if (b != 0)
                        {
                            digitsForCalculationTextBlock.Text = (a / b).ToString();
                            isDivide = false;
                            isOperator = false;
                            isZero = false;
                            operatorsLabel.Content = "=";
                        }
                        else
                        {
                            MessageBox.Show("Нельзя делить на ноль!");
                        }
                    }
                    else if (isPrecent)
                    {
                        numberList.Add(digitsForCalculationTextBlock.Text);
                        a = Convert.ToDouble(numberList[0]);
                        b = Convert.ToDouble(numberList[1]);
                        if (b < 100)
                        {
                            c = (a / 100) * b;
                            digitsForCalculationTextBlock.Text = c.ToString();
                        }
                        else
                        {
                            MessageBox.Show("Неправльно введена цифра (1%-100%) , Значение по умолчанию 50%");
                            b = 50;
                            c = (a / 100) * b;
                            digitsForCalculationTextBlock.Text = c.ToString();
                        }
                        isPrecent = false;
                        isOperator = false;
                        isZero = false;
                        operatorsLabel.Content = "=";
                    }
                }
            }
            else
            {
                MessageBox.Show("Не введена цифра!");
            }
        }

        private void EraseButton_Click(object sender, RoutedEventArgs e)
        {
            if (digitsForCalculationTextBlock.Text.Length != 0)
            {
                if (!isDivide)
                {
                    digitsForCalculationTextBlock.Text = digitsForCalculationTextBlock.Text.Substring(0, digitsForCalculationTextBlock.Text.Length - 1);
                }
                else
                {
                    digitsForCalculationTextBlock.Text = digitsForCalculationTextBlock.Text.Substring(0, digitsForCalculationTextBlock.Text.Length - 1);
                    numberList.Remove(numberList.Last());
                }
            }
        }

        private void MinusButton_Click(object sender, RoutedEventArgs e)
        {
            isPoint = false;
            if (digitsForCalculationTextBlock.Text != "")
            {
                if (!isOperator)
                {
                    numberList.Clear();
                    numberList.Add(digitsForCalculationTextBlock.Text);
                    digitsForCalculationTextBlock.Text = "0";
                    isZero = true;
                    isOperator = true;
                    isMinus = true;
                    operatorsLabel.Content = "-";
                }
                else
                {
                    if (isPlus)
                    {
                        numberList.Add(digitsForCalculationTextBlock.Text);
                        a = Convert.ToDouble(numberList[0]);
                        b = Convert.ToDouble(numberList[1]);
                        digitsForCalculationTextBlock.Text = (a + b).ToString();
                        isPlus = false;
                        isOperator = false;
                        isZero = false;
                        operatorsLabel.Content = "=";
                    }
                    else if (isMinus)
                    {
                        numberList.Add(digitsForCalculationTextBlock.Text);
                        a = Convert.ToDouble(numberList[0]);
                        b = Convert.ToDouble(numberList[1]);
                        digitsForCalculationTextBlock.Text = (a - b).ToString();
                        isMinus = false;
                        isOperator = false;
                        isZero = false;
                        operatorsLabel.Content = "=";
                    }
                    else if (isMultiply)
                    {
                        numberList.Add(digitsForCalculationTextBlock.Text);
                        a = Convert.ToDouble(numberList[0]);
                        b = Convert.ToDouble(numberList[1]);
                        digitsForCalculationTextBlock.Text = (a * b).ToString();
                        isMultiply = false;
                        isOperator = false;
                        isZero = false;
                        operatorsLabel.Content = "=";
                    }
                    else if (isDivide)
                    {

                        numberList.Add(digitsForCalculationTextBlock.Text);
                        a = Convert.ToDouble(numberList[0]);
                        b = Convert.ToDouble(numberList[1]);
                        if (b != 0)
                        {
                            digitsForCalculationTextBlock.Text = (a / b).ToString();
                            isDivide = false;
                            isOperator = false;
                            isZero = false;
                            operatorsLabel.Content = "=";
                        }
                        else
                        {
                            MessageBox.Show("Нельзя делить на ноль!");
                        }
                    }
                    else if (isPrecent)
                    {
                        numberList.Add(digitsForCalculationTextBlock.Text);
                        a = Convert.ToDouble(numberList[0]);
                        b = Convert.ToDouble(numberList[1]);
                        if (b < 100)
                        {
                            c = (a / 100) * b;
                            digitsForCalculationTextBlock.Text = c.ToString();
                        }
                        else
                        {
                            MessageBox.Show("Неправльно введена цифра (1%-100%) , Значение по умолчанию 50%");
                            b = 50;
                            c = (a / 100) * b;
                            digitsForCalculationTextBlock.Text = c.ToString();
                        }
                        isPrecent = false;
                        isOperator = false;
                        isZero = false;
                        operatorsLabel.Content = "=";
                    }
                }
            }
            else
            {
                MessageBox.Show("Не введена цифра!");
            }
        }

        private void MultiplyButton_Click(object sender, RoutedEventArgs e)
        {
            isPoint = false;
            if (digitsForCalculationTextBlock.Text != "")
            {
                if (!isOperator)
                {
                    numberList.Clear();
                    numberList.Add(digitsForCalculationTextBlock.Text);
                    digitsForCalculationTextBlock.Text = "0";
                    isZero = true;
                    isOperator = true;
                    isMultiply = true;
                    operatorsLabel.Content = "*";
                }
                else
                {
                    if (isPlus)
                    {
                        numberList.Add(digitsForCalculationTextBlock.Text);
                        a = Convert.ToDouble(numberList[0]);
                        b = Convert.ToDouble(numberList[1]);
                        digitsForCalculationTextBlock.Text = (a + b).ToString();
                        isPlus = false;
                        isOperator = false;
                        isZero = false;
                        operatorsLabel.Content = "=";
                    }
                    else if (isMinus)
                    {
                        numberList.Add(digitsForCalculationTextBlock.Text);
                        a = Convert.ToDouble(numberList[0]);
                        b = Convert.ToDouble(numberList[1]);
                        digitsForCalculationTextBlock.Text = (a - b).ToString();
                        isMinus = false;
                        isOperator = false;
                        isZero = false;
                        operatorsLabel.Content = "=";
                    }
                    else if (isMultiply)
                    {
                        numberList.Add(digitsForCalculationTextBlock.Text);
                        a = Convert.ToDouble(numberList[0]);
                        b = Convert.ToDouble(numberList[1]);
                        digitsForCalculationTextBlock.Text = (a * b).ToString();
                        isMultiply = false;
                        isOperator = false;
                        isZero = false;
                        operatorsLabel.Content = "=";
                    }
                    else if (isDivide)
                    {
                        numberList.Add(digitsForCalculationTextBlock.Text);
                        a = Convert.ToDouble(numberList[0]);
                        b = Convert.ToDouble(numberList[1]);
                        if (b != 0)
                        {
                            digitsForCalculationTextBlock.Text = (a / b).ToString();
                            isDivide = false;
                            isOperator = false;
                            isZero = false;
                            operatorsLabel.Content = "=";
                        }
                        else
                        {
                            MessageBox.Show("Нельзя делить на ноль!");
                        }
                    }
                    else if (isPrecent)
                    {
                        numberList.Add(digitsForCalculationTextBlock.Text);
                        a = Convert.ToDouble(numberList[0]);
                        b = Convert.ToDouble(numberList[1]);
                        if (b < 100)
                        {
                            c = (a / 100) * b;
                            digitsForCalculationTextBlock.Text = c.ToString();
                        }
                        else
                        {
                            MessageBox.Show("Неправльно введена цифра (1%-100%) , Значение по умолчанию 50%");
                            b = 50;
                            c = (a / 100) * b;
                            digitsForCalculationTextBlock.Text = c.ToString();
                        }
                        isPrecent = false;
                        isOperator = false;
                        isZero = false;
                        operatorsLabel.Content = "=";
                    }
                }
            }
            else
            {
                MessageBox.Show("Не введена цифра!");
            }
        }



        private void DivideButton_Click(object sender, RoutedEventArgs e)
        {
            isPoint = false;

            if (digitsForCalculationTextBlock.Text != "")
            {
                if (!isOperator)
                {
                    numberList.Clear();
                    numberList.Add(digitsForCalculationTextBlock.Text);
                    digitsForCalculationTextBlock.Text = "0";
                    isZero = true;
                    isOperator = true;
                    isDivide = true;
                    operatorsLabel.Content = "/";
                }
                else
                {
                    if (isPlus)
                    {
                        numberList.Add(digitsForCalculationTextBlock.Text);
                        a = Convert.ToDouble(numberList[0]);
                        b = Convert.ToDouble(numberList[1]);
                        digitsForCalculationTextBlock.Text = (a + b).ToString();
                        isPlus = false;
                        isOperator = false;
                        isZero = false;
                        operatorsLabel.Content = "=";
                    }
                    else if (isMinus)
                    {
                        numberList.Add(digitsForCalculationTextBlock.Text);
                        a = Convert.ToDouble(numberList[0]);
                        b = Convert.ToDouble(numberList[1]);
                        digitsForCalculationTextBlock.Text = (a - b).ToString();
                        isMinus = false;
                        isOperator = false;
                        isZero = false;
                        operatorsLabel.Content = "=";
                    }
                    else if (isMultiply)
                    {
                        numberList.Add(digitsForCalculationTextBlock.Text);
                        a = Convert.ToDouble(numberList[0]);
                        b = Convert.ToDouble(numberList[1]);
                        digitsForCalculationTextBlock.Text = (a * b).ToString();
                        isMultiply = false;
                        isOperator = false;
                        isZero = false;
                        operatorsLabel.Content = "=";
                    }
                    else if (isDivide)
                    {
                        numberList.Add(digitsForCalculationTextBlock.Text);
                        a = Convert.ToDouble(numberList[0]);
                        b = Convert.ToDouble(numberList[1]);
                        if (b != 0)
                        {
                            digitsForCalculationTextBlock.Text = (a / b).ToString();
                            isDivide = false;
                            isOperator = false;
                            isZero = false;
                            operatorsLabel.Content = "=";
                        }
                        else
                        {
                            MessageBox.Show("На ноль делить нельзя!");
                        }
                    }
                    else if (isPrecent)
                    {
                        numberList.Add(digitsForCalculationTextBlock.Text);
                        a = Convert.ToDouble(numberList[0]);
                        b = Convert.ToDouble(numberList[1]);
                        if (b < 100)
                        {
                            c = (a / 100) * b;
                            digitsForCalculationTextBlock.Text = c.ToString();
                        }
                        else
                        {
                            MessageBox.Show("Неправльно введена цифра (1%-100%) , Значение по умолчанию 50%");
                            b = 50;
                            c = (a / 100) * b;
                            digitsForCalculationTextBlock.Text = c.ToString();
                        }
                        isPrecent = false;
                        isOperator = false;
                        isZero = false;
                        operatorsLabel.Content = "=";
                    }
                }
            }
            else
            {
                MessageBox.Show("Не введена цифра!");
            }
        }

        private void PercentButton_Click(object sender, RoutedEventArgs e)
        {
            isPoint = false;
            if (digitsForCalculationTextBlock.Text != "")
            {
                if (!isOperator)
                {
                    numberList.Clear();
                    numberList.Add(digitsForCalculationTextBlock.Text);
                    digitsForCalculationTextBlock.Text = "0";
                    isZero = true;
                    isOperator = true;
                    isPrecent = true;
                    operatorsLabel.Content = "%";
                }
                else
                {
                    if (isPlus)
                    {
                        numberList.Add(digitsForCalculationTextBlock.Text);
                        a = Convert.ToDouble(numberList[0]);
                        b = Convert.ToDouble(numberList[1]);
                        digitsForCalculationTextBlock.Text = (a + b).ToString();
                        isPlus = false;
                        isOperator = false;
                        isZero = false;
                        operatorsLabel.Content = "=";
                    }
                    else if (isMinus)
                    {
                        numberList.Add(digitsForCalculationTextBlock.Text);
                        a = Convert.ToDouble(numberList[0]);
                        b = Convert.ToDouble(numberList[1]);
                        digitsForCalculationTextBlock.Text = (a - b).ToString();
                        isMinus = false;
                        isOperator = false;
                        isZero = false;
                        operatorsLabel.Content = "=";
                    }
                    else if (isMultiply)
                    {
                        numberList.Add(digitsForCalculationTextBlock.Text);
                        a = Convert.ToDouble(numberList[0]);
                        b = Convert.ToDouble(numberList[1]);
                        digitsForCalculationTextBlock.Text = (a * b).ToString();
                        isMultiply = false;
                        isOperator = false;
                        isZero = false;
                        operatorsLabel.Content = "=";
                    }
                    else if (isDivide)
                    {
                        numberList.Add(digitsForCalculationTextBlock.Text);
                        a = Convert.ToDouble(numberList[0]);
                        b = Convert.ToDouble(numberList[1]);
                        if (b != 0)
                        {
                            digitsForCalculationTextBlock.Text = (a / b).ToString();
                            isDivide = false;
                            isOperator = false;
                            isZero = false;
                            operatorsLabel.Content = "=";
                        }
                        else
                        {
                            MessageBox.Show("Нельзя делить на ноль!");
                        }
                    }
                    else if (isPrecent)
                    {
                        numberList.Add(digitsForCalculationTextBlock.Text);
                        a = Convert.ToDouble(numberList[0]);
                        b = Convert.ToDouble(numberList[1]);
                        if (b < 100)
                        {
                            c = (a / 100) * b;
                            digitsForCalculationTextBlock.Text = c.ToString();
                        }
                        else
                        {
                            MessageBox.Show("Неправльно введена цифра (1%-100%) , Значение по умолчанию 50%");
                            b = 50;
                            c = (a / 100) * b;
                            digitsForCalculationTextBlock.Text = c.ToString();
                        }
                        isPrecent = false;
                        isOperator = false;
                        isZero = false;
                        operatorsLabel.Content = "=";
                    }
                }
            }
            else
            {
                MessageBox.Show("Не введена цифра!");
            }
        }
        private void RootButton_Click(object sender, RoutedEventArgs e)
        {
            isPoint = false;
            if (digitsForCalculationTextBlock.Text != "")
            {
                if (isPlus)
                {
                    numberList.Add(digitsForCalculationTextBlock.Text);
                    a = Convert.ToDouble(numberList[0]);
                    b = Convert.ToDouble(numberList[1]);
                    digitsForCalculationTextBlock.Text = Math.Sqrt((a + b)).ToString();
                    isPlus = false;
                    isOperator = false;
                    isZero = false;
                    operatorsLabel.Content = "sqrt=";
                }
                else if (isMinus)
                {
                    numberList.Add(digitsForCalculationTextBlock.Text);
                    a = Convert.ToDouble(numberList[0]);
                    b = Convert.ToDouble(numberList[1]);
                    digitsForCalculationTextBlock.Text = Math.Sqrt((a - b)).ToString();
                    isMinus = false;
                    isOperator = false;
                    isZero = false;
                    operatorsLabel.Content = "sqrt=";
                }
                else if (isMultiply)
                {
                    numberList.Add(digitsForCalculationTextBlock.Text);
                    a = Convert.ToDouble(numberList[0]);
                    b = Convert.ToDouble(numberList[1]);
                    digitsForCalculationTextBlock.Text = Math.Sqrt((a * b)).ToString();
                    isMultiply = false;
                    isOperator = false;
                    isZero = false;
                    operatorsLabel.Content = "sqrt=";
                }
                else if (isDivide)
                {
                    numberList.Add(digitsForCalculationTextBlock.Text);
                    a = Convert.ToDouble(numberList[0]);
                    b = Convert.ToDouble(numberList[1]);
                    if (b != 0)
                    {
                        digitsForCalculationTextBlock.Text = Math.Sqrt((a / b)).ToString();
                        isDivide = false;
                        isOperator = false;
                        isZero = false;
                        operatorsLabel.Content = "sqrt=";
                    }
                    else
                    {
                        MessageBox.Show("Нельзя делить на ноль!");
                    }
                }
                else if (isPrecent)
                {
                    numberList.Add(digitsForCalculationTextBlock.Text);
                    a = Convert.ToDouble(numberList[0]);
                    b = Convert.ToDouble(numberList[1]);
                    if (b < 100)
                    {
                        c = (a / 100) * b;
                        digitsForCalculationTextBlock.Text = c.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Неправльно введена цифра (1%-100%) , Значение по умолчанию 50%");
                        b = 50;
                        c = (a / 100) * b;
                        digitsForCalculationTextBlock.Text = Math.Sqrt(c).ToString();
                    }
                    isPrecent = false;
                    isOperator = false;
                    isZero = false;
                    operatorsLabel.Content = "sqrt=";
                }
                else
                {
                    numberList.Clear();
                    numberList.Add(digitsForCalculationTextBlock.Text);
                    a = Convert.ToDouble(numberList[0]);
                    digitsForCalculationTextBlock.Text = Math.Sqrt(a).ToString();
                    operatorsLabel.Content = "sqrt=";
                }
            }
            else
            {
                MessageBox.Show("Не введена цифра!");
            }
        }

        private void SquareButton_Click(object sender, RoutedEventArgs e)
        {
            isPoint = false;
            if (digitsForCalculationTextBlock.Text != "")
            {
                if (isPlus)
                {
                    numberList.Add(digitsForCalculationTextBlock.Text);
                    a = Convert.ToDouble(numberList[0]);
                    b = Convert.ToDouble(numberList[1]);
                    digitsForCalculationTextBlock.Text = ((a + b) * (a + b)).ToString();
                    isPlus = false;
                    isOperator = false;
                    isZero = false;
                    operatorsLabel.Content = "=";
                }
                else if (isMinus)
                {
                    numberList.Add(digitsForCalculationTextBlock.Text);
                    a = Convert.ToDouble(numberList[0]);
                    b = Convert.ToDouble(numberList[1]);
                    digitsForCalculationTextBlock.Text = ((a - b) * (a - b)).ToString();
                    isMinus = false;
                    isOperator = false;
                    isZero = false;
                    operatorsLabel.Content = "=";
                }
                else if (isMultiply)
                {
                    numberList.Add(digitsForCalculationTextBlock.Text);
                    a = Convert.ToDouble(numberList[0]);
                    b = Convert.ToDouble(numberList[1]);
                    digitsForCalculationTextBlock.Text = ((a * b) * (a * b)).ToString();
                    isMultiply = false;
                    isOperator = false;
                    isZero = false;
                    operatorsLabel.Content = "=";
                }
                else if (isDivide)
                {
                    numberList.Add(digitsForCalculationTextBlock.Text);
                    a = Convert.ToDouble(numberList[0]);
                    b = Convert.ToDouble(numberList[1]);
                    if (b != 0)
                    {
                        digitsForCalculationTextBlock.Text = ((a / b) * (a / b)).ToString();
                        isDivide = false;
                        isOperator = false;
                        isZero = false;
                        operatorsLabel.Content = "=";
                    }
                    else
                    {
                        MessageBox.Show("Нельзя делить на ноль!");
                    }
                }
                else if (isPrecent)
                {
                    numberList.Add(digitsForCalculationTextBlock.Text);
                    a = Convert.ToDouble(numberList[0]);
                    b = Convert.ToDouble(numberList[1]);
                    if (b < 100)
                    {
                        c = (a / 100) * b;
                        c = c * c;
                        digitsForCalculationTextBlock.Text = c.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Неправльно введена цифра (1%-100%) , Значение по умолчанию 50%");
                        b = 50;
                        c = (a / 100) * b;
                        c = c * c;
                        digitsForCalculationTextBlock.Text = c.ToString();
                    }
                    isPrecent = false;
                    isOperator = false;
                    isZero = false;
                    operatorsLabel.Content = "=";
                }
                else
                {
                    numberList.Clear();
                    numberList.Add(digitsForCalculationTextBlock.Text);
                    a = Convert.ToDouble(numberList[0]);
                    digitsForCalculationTextBlock.Text = (a * a).ToString();
                    operatorsLabel.Content = "=";
                }
            }
            else
            {
                MessageBox.Show("Не введена цифра!");
            }

        }

        private void ExactlyButton_Click(object sender, RoutedEventArgs e)
        {
            isPoint = false;
            if (isPlus)
            {
                numberList.Add(digitsForCalculationTextBlock.Text);
                a = Convert.ToDouble(numberList[0]);
                b = Convert.ToDouble(numberList[1]);
                digitsForCalculationTextBlock.Text = (a + b).ToString();
                isPlus = false;
                isOperator = false;
                isZero = false;
                operatorsLabel.Content = "=";
            }
            else if (isMinus)
            {
                numberList.Add(digitsForCalculationTextBlock.Text);
                a = Convert.ToDouble(numberList[0]);
                b = Convert.ToDouble(numberList[1]);
                digitsForCalculationTextBlock.Text = (a - b).ToString();
                isMinus = false;
                isOperator = false;
                isZero = false;
                operatorsLabel.Content = "=";
            }
            else if (isMultiply)
            {
                numberList.Add(digitsForCalculationTextBlock.Text);
                a = Convert.ToDouble(numberList[0]);
                b = Convert.ToDouble(numberList[1]);
                digitsForCalculationTextBlock.Text = (a * b).ToString();
                isMultiply = false;
                isOperator = false;
                isZero = false;
                operatorsLabel.Content = "=";
            }
            else if (isDivide)
            {
                numberList.Add(digitsForCalculationTextBlock.Text);
                a = Convert.ToDouble(numberList[0]);
                b = Convert.ToDouble(numberList[1]);
                if (b != 0)
                {
                    digitsForCalculationTextBlock.Text = (a / b).ToString();
                    isDivide = false;
                    isOperator = false;
                    isZero = false;
                    operatorsLabel.Content = "=";
                }
                else
                {
                    MessageBox.Show("Нельзя делить на ноль!");
                }
            }
            else if (isPrecent)
            {
                numberList.Add(digitsForCalculationTextBlock.Text);
                a = Convert.ToDouble(numberList[0]);
                b = Convert.ToDouble(numberList[1]);
                if (b < 100)
                {
                    c = (a / 100) * b;
                    digitsForCalculationTextBlock.Text = c.ToString();
                }
                else
                {
                    MessageBox.Show("Неправльно введена цифра (1%-100%) , Значение по умолчанию 50%");
                    b = 50;
                    c = (a / 100) * b;
                    digitsForCalculationTextBlock.Text = c.ToString();
                }
                isPrecent = false;
                isOperator = false;
                isZero = false;
                operatorsLabel.Content = "=";
            }
        }


        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            digitsForCalculationTextBlock.Text = "";

            isPoint = false;
            isOperator = false;
            isPlus = false;
            isMinus = false;
            isMultiply = false;
            isDivide = false;
            isZero = false;
            isPrecent = false;
            operatorsLabel.Content = "";
            a = b = c = 0;
            numberList.Clear();
        }

    }
}
