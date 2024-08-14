using Newtonsoft.Json;
using RestSharp;
using System.Net;
using System.Runtime.Intrinsics.Arm;
using System.Windows;
using System.Windows.Controls;
using WpfApp1.Classes;






namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for SchoolDetails.xaml
    /// </summary>
    public partial class SchoolDetails : Window
    {

        public SchoolDetails()
        {
            InitializeComponent();

        }



        private void Logout(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }



        //<-----------  SchoolDetails------------->

        #region SchoolDetails

        private void About_Us_School(object sender, RoutedEventArgs e)
        {
            PencilLogo.Visibility = Visibility.Hidden;
            TeacherContent.Visibility = Visibility.Hidden;
            SchoolContent.Visibility = Visibility.Visible;

        }


        // Create School Details---------------------->
        #region Create School Details
        private void Upload_School_Click_1(object sender, RoutedEventArgs e)// Create Shool Details-----------------> 
        {
            TeacherContent.Visibility = Visibility.Hidden;
            SchoolContent.Visibility = Visibility.Hidden;
            schoolMenu.Visibility = Visibility.Hidden;
            CreateSchoolDetails.Visibility = Visibility.Visible;
        }

        private void Back_Button(object sender, RoutedEventArgs e)
        {
            CreateSchoolDetails.Visibility = Visibility.Hidden;
            TeacherContent.Visibility = Visibility.Hidden;
            PencilLogo.Visibility = Visibility.Hidden;
            SchoolContent.Visibility = Visibility.Visible;
            schoolMenu.Visibility = Visibility.Visible;

        }


        private void Cancel_Button(object sender, RoutedEventArgs e)
        {
            CreateSchoolDetails.Visibility = Visibility.Hidden;
            schoolMenu.Visibility = Visibility.Visible;
            PencilLogo.Visibility = Visibility.Visible;
        }

        private async void Submit(object sender, RoutedEventArgs e)
        {
            try
            {
                var options = "https://localhost:7022/api/School/"; // Dummy API endpoint
                var client = new RestClient(options);

                //var request = new RestRequest(Method.Post);
                var request = new RestRequest("create", Method.Post);
                request.AddHeader("Content-Type", "application/json");

                var postData = new
                {
                    schoolName = TxtSchoolName.Text,
                    school_Admin_Name = TxtSchoolAdmin.Text,
                    headMaster_MobilNO = Int64.Parse(TxtMobileNO.Text),
                    how_Many_Teachers_Gender_Male = int.Parse(TxtMale.Text),
                    how_Many_Teachers_Gender_Female = int.Parse(TxtFemale.Text),
                    schoolLocation = TxtschoolLocation.Text

                };
                request.AddJsonBody(postData);
                var response = await client.ExecuteAsync(request); // Use asynchronous method

                if (response.StatusCode == HttpStatusCode.Created)
                {
                    var content = response.Content;
                    MessageBox.Show("Data submitted successfully!");
                }
                else
                {
                    MessageBox.Show($"Request failed with status code {response.StatusCode}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
        #endregion




        #endregion





        //<-----------  Teachers Details Details------------->

        #region Teachers Details Details

        private void About_Us_Teachers(object sender, RoutedEventArgs e)
        {
            PencilLogo.Visibility = Visibility.Collapsed;
            TeacherContent.Visibility = Visibility.Visible;
            SchoolContent.Visibility = Visibility.Hidden;

        }



        // Create Teachers Details--------------------------->


        #region Create Teachers Details  


        private void Upload_Teacher_Click(object sender, RoutedEventArgs e)
        {
            SchoolContent.Visibility = Visibility.Hidden;
            TeacherContent.Visibility = Visibility.Hidden;
            schoolMenu.Visibility = Visibility.Hidden;
            CreateTeachersdetails.Visibility = Visibility.Visible;
            this.Height = 700;



        }

        private void Back_Button_Teachers(object sender, RoutedEventArgs e)
        {


            CreateTeachersdetails.Visibility = Visibility.Hidden;
            SchoolContent.Visibility = Visibility.Hidden;
            SchoolContent.Visibility = Visibility.Visible;
            schoolMenu.Visibility = Visibility.Visible;
            this.Height = 500;

        }

        private void Cancel_Button_Teachers(object sender, RoutedEventArgs e)
        {
            CreateTeachersdetails.Visibility = Visibility.Hidden;
            schoolMenu.Visibility = Visibility.Visible;
            PencilLogo.Visibility = Visibility.Visible;
            this.Height = 500;

        }

        private async void Submit_Button_Teachers(object sender, RoutedEventArgs e)
        {
            try
            {
                var options = "https://localhost:7022/api/School/"; // Dummy API endpoint
                var client = new RestClient(options);

                //var request = new RestRequest(Method.Post);
                var request = new RestRequest("Create_Teachers_Details", Method.Post);
                request.AddHeader("Content-Type", "application/json");
                var selectedItem = TxtTeachersgenders.SelectedItem as ComboBoxItem;
                int Tgender;

                if (selectedItem != null)
                {
                    string content = selectedItem.Content.ToString();

                    if (content == "Male")
                    {
                        Tgender = 1;
                    }
                    else if (content == "Female")
                    {
                        Tgender = 2;
                    }
                    else
                    {
                        Tgender = 3;
                    }
                }
                else
                {
                    // Handle case where no item is selected
                    Tgender = 0; // Or any other default value
                }
                var TeachersData = new
                {
                    TeachersName = TxtTeachersName.Text,
                    TeachersAge = int.Parse(TxtTeacherAge.Text),
                    Teachers_MobileNo = Int64.Parse(TxtTeachermobileNo.Text),
                    Gender = Tgender,
                    currently_workking_school_Name = TxtTeacherworkingSchName.Text,
                    which_Class_Teaching = int.Parse(TeachingClass.Text),
                    Joining_Date = TxtDateJoin.Text,
                    Teachers_salary = int.Parse(TxtTeacherSalary.Text),
                    Staying_Location = TxtTeacherLocation.Text
                    // Add more data as needed
                };
                request.AddJsonBody(TeachersData);
                var response = await client.ExecuteAsync(request); // Use asynchronous method

                if (response.StatusCode == HttpStatusCode.OK)
                {
                    var content = response.Content;
                    MessageBox.Show("Data submitted successfully!");
                }
                else
                {
                    MessageBox.Show($"Request failed with status code {response.StatusCode}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }  // Create Teachers Details--------------------------->
        #endregion

        #region Get Teachers Details


        #endregion

        #endregion










        private void GetSchoolDetails(object sender, RoutedEventArgs e)
        {
          GetSchoolDetails page3= new GetSchoolDetails();
            this.Close();
            page3.Show();
           
          
        }

        private void getTeacherinfo_Click(object sender, RoutedEventArgs e)
        {
            GetTeachersDetails page3 = new GetTeachersDetails();
            this.Close();
            page3.Show();
        }

        private void deleteschool_Click(object sender, RoutedEventArgs e)
        {

        }


    }


}

