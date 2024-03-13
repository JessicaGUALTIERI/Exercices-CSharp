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

namespace TP_SubscriptionToNewspaper
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataBase.Initialize();
        }

        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            if (NamesAreSet() && SubscriptionDurationIsSet())
            {
                User user = new User()
                {
                    LastName = LastNameValue.Text,
                    FirstName = FirstNameValue.Text,
                    Duration = SetDurationTime(),
                    Newsletter = NewsletterAgreement()
                };
                DataBase.Users.Add(user);
                MessageBox.Show("Your subscription has been sent !");
                ReinitializeForm();
            }
            else
            {
                MessageBox.Show("Error : some elements are missing...");
            }
        }

        private void DisplayButton_Click(object sender, RoutedEventArgs e)
        {
            DataBaseDisplayed.Text = "";
            foreach (User user in DataBase.Users)
            {
                DataBaseDisplayed.Text += user.LastName + " " + user.FirstName + " Duration : " + user.Duration + " Newsletter : " + user.Newsletter + "\n";
            }
        }

        private void ReinitializeForm()
        {
            LastNameValue.Text = "";
            FirstNameValue.Text = "";
            OneMonth.IsChecked = false;
            SixMonth.IsChecked = false;
            OneYear.IsChecked = false;
            NewsletterCheckBox.IsChecked = false;
        }

        private bool NamesAreSet()
        {
            return LastNameValue.Text != "" && FirstNameValue.Text != "";
        }

        private bool SubscriptionDurationIsSet()
        {
            return OneMonth.IsChecked == true || SixMonth.IsChecked == true || OneYear.IsChecked == true;
        }

        private bool NewsletterAgreement()
        {
            return NewsletterCheckBox.IsChecked == true;
        }

        private SubscriptionDuration SetDurationTime()
        {
            if (OneMonth.IsChecked == true)
            {
                return SubscriptionDuration.OneMonth;
            } else if (SixMonth.IsChecked == true)
            {
                return SubscriptionDuration.SixMonth;
            } else
            {
                return SubscriptionDuration.OneYear;
            }
        }
    }
}