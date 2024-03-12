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

namespace TP_Testboutons
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

        private void incrementorMinus_Click(object sender, RoutedEventArgs e)
        {
            int toReturn = int.Parse(incrementorResult.Text);
            toReturn--;
            incrementorResult.Text = toReturn.ToString();
        }

        private void incrementorPlus_Click(object sender, RoutedEventArgs e)
        {
            int toReturn = int.Parse(incrementorResult.Text);
            toReturn++;
            incrementorResult.Text = toReturn.ToString();
        }

        private void calculatorPlus_Click(object sender, RoutedEventArgs e)
        {
            int numberOneInt = int.Parse(numberOne.Text);
            int numberTwoInt = int.Parse(numberTwo.Text);
            calculatorResult.Text = (numberOneInt + numberTwoInt).ToString();
        }

        private void calculatorMinus_Click(object sender, RoutedEventArgs e)
        {
            int numberOneInt = int.Parse(numberOne.Text);
            int numberTwoInt = int.Parse(numberTwo.Text);
            calculatorResult.Text = (numberOneInt - numberTwoInt).ToString();
        }

        private void calculatorDivide_Click(object sender, RoutedEventArgs e)
        {
            int numberOneInt = int.Parse(numberOne.Text);
            int numberTwoInt = int.Parse(numberTwo.Text);
            if (numberOneInt == 0 || numberTwoInt == 0)
            {
                MessageBox.Show("Impossible to divide by zero ! Try again !");
            } else 
            {
                calculatorResult.Text = (numberOneInt / numberTwoInt).ToString();
            }
        }

        private void calculatorMultiply_Click(object sender, RoutedEventArgs e)
        {
            int numberOneInt = int.Parse(numberOne.Text);
            int numberTwoInt = int.Parse(numberTwo.Text);
            calculatorResult.Text = (numberOneInt * numberTwoInt).ToString();
        }

        private void randomNumberGenerate_Click(object sender, RoutedEventArgs e)
        {
            int numberMinimum = int.Parse(randomMinimum.Text);
            int numberMaximum = int.Parse(randomMaximum.Text);
            numberMaximum += 1;
            Random random = new Random();
            int randomNumberGenerated = random.Next(numberMinimum, numberMaximum);
            randomNumber.Text = randomNumberGenerated.ToString();
        }
    }
}