using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Threading;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private DispatcherTimer timer;
        private Brush originalBorderBrush;
        private Thickness originalBorderThickness;
        public MainWindow()
        {
            InitializeComponent();

            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(3); // Revert brush back after 2 seconds
            timer.Tick += Timer_Tick;
        }



        private void createaccount_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("currently unavailable \n try again");
        }

        private void Submit_Click(object sender, RoutedEventArgs e)
        {
        //    var username = "Vignesh";
        //    var password = "Logan";
         string username= User.Text;
            string Password = pass.Password;


            if(username=="Vignesh" && Password == "Logan")
            {
                
                User.BorderBrush=Brushes.Green;
                User.BorderThickness = new Thickness(3);
                pass.BorderBrush = Brushes.Green;
                pass.BorderThickness = new Thickness(3);
                timer.Start();
                MessageBox.Show("Successfully Login");
                SchoolDetails schoolDetails = new SchoolDetails();
                schoolDetails.Show();
                this.Hide();
            }

            if (username == "Vignesh" && Password != "Logan")
            {
               
                User.BorderBrush=Brushes.Green;
                User.BorderThickness = new Thickness(3);
                pass.BorderBrush = Brushes.Red;
                pass.BorderThickness = new Thickness(3);
                timer.Start();
                MessageBox.Show("Username Ok \nPassword did Not match ");
            }
            if (username != "Vignesh" && Password == "Logan")
            {
               
                User.BorderBrush = Brushes.Red;
                User.BorderThickness = new Thickness(3);
                pass.BorderBrush = Brushes.Green;
                pass.BorderThickness = new Thickness(3);
                timer.Start();
                MessageBox.Show("Password Ok \nUsername did Not match ");
            }

            if (username != "Vignesh" && Password != "Logan")
            {
               
                User.BorderBrush = Brushes.Red;
                User.BorderThickness = new Thickness(3);
                pass.BorderBrush = Brushes.Red;
                pass.BorderThickness = new Thickness(3);
                timer.Start();
                MessageBox.Show("Username and password is Required \nWrong Username \nWrong Password");
                  

            }

        }
        private void Timer_Tick(object? sender, EventArgs e)
        {
            User.BorderBrush = originalBorderBrush;
            pass.BorderBrush = originalBorderBrush;
            User.BorderThickness = originalBorderThickness;
            pass.BorderThickness = originalBorderThickness;
            timer.Stop();

        }

        private void User_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(User.Text != "")
            {
                User_Placeholder.Visibility = Visibility.Hidden;
            }
            else
            {
                User_Placeholder.Visibility = Visibility.Visible;
            }
        }



        private void pass_TextChanged(object sender, RoutedEventArgs e)
        {
            if (pass.Password != "")
            {
                PassWord_Placeholder.Visibility = Visibility.Hidden;
            }
            else
            {
                PassWord_Placeholder.Visibility = Visibility.Visible;
            }
        }


    }
}