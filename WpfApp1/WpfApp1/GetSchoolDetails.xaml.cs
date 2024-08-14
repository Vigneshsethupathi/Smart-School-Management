using Newtonsoft.Json;
using RestSharp;
using System.Net;
using System.Windows;
using System.Windows.Input;
using WpfApp1.Classes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for GetSchoolDetails.xaml
    /// </summary>
    public partial class GetSchoolDetails : Window
    {
        public GetSchoolDetails()
        {
            InitializeComponent();
            GetSchool(null, null);
        }


        private async void GetSchool(object sender, RoutedEventArgs e)  // get school details------------------------>
        {
            try
            {
                var ApiControllerUrl = "https://localhost:7022/api/School/";
                var cleint = new RestClient(ApiControllerUrl);

                var request = new RestRequest("GetSchool Details", Method.Get);
                request.AddHeader("Content-type", "application/json");


                var response = await cleint.ExecuteAsync(request);
                var responseData = response.Content;

                if (response.StatusCode == HttpStatusCode.OK)
                {

                    List<SchoolData> sdata = JsonConvert.DeserializeObject<List<SchoolData>>(responseData);
                    SchoolGetValues.ItemsSource = sdata;

                }

                //List<SchoolData> people = JsonConvert.DeserializeObject<List<SchoolData>>(response.Content);



                //// Set the ItemsSource of the DataGrid to the list of Person objects

                //SchoolGetValues.ItemsSource = people;


            }

            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }


        }
        private void Back_Button_School_Get(object sender, RoutedEventArgs e)
        {
            SchoolDetails schoolDetails = new SchoolDetails();
            this.Close();
            schoolDetails.Show();

            schoolDetails.TeacherContent.Visibility = Visibility.Hidden;
            schoolDetails.PencilLogo.Visibility = Visibility.Hidden;
            schoolDetails.SchoolContent.Visibility = Visibility.Visible;
            schoolDetails.schoolMenu.Visibility = Visibility.Visible;

        }

        private void Cancel_Button_School_Get(object sender, RoutedEventArgs e)
        {
            SchoolDetails schoolDetails = new SchoolDetails();
            this.Close();
            schoolDetails.Show();
        }



        private void Logout_Icon_GetPage(object sender, MouseButtonEventArgs e)
        {
            SchoolDetails schoolData = new SchoolDetails();
            this.Close();
            schoolData.Show();
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
        private void Image_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            string password = "0000";
            if (pass.Password == password)
            {
                EnterPassword.Visibility = Visibility.Hidden;
                blurimage.Visibility = Visibility.Hidden;
                GetSchoolDataPage.Visibility = Visibility.Visible;

            }
            else
            {
                MessageBox.Show("password wrong");

            }

        }
        private void Back_Button_teacher_Get(object sender, RoutedEventArgs e)
        {

            SchoolDetails schoolDetails = new SchoolDetails();
            this.Close();
            schoolDetails.Show();

            schoolDetails.TeacherContent.Visibility = Visibility.Hidden;
            schoolDetails.PencilLogo.Visibility = Visibility.Hidden;
            schoolDetails.SchoolContent.Visibility = Visibility.Visible;
            schoolDetails.schoolMenu.Visibility = Visibility.Visible;
        }

        private void Image_MouseLeftButtonDownTeacher(object sender, MouseButtonEventArgs e)
        {
            string password = "0000";
            if (pass.Password == password)
            {
                EnterPassword.Visibility = Visibility.Hidden;
                blurimage.Visibility = Visibility.Hidden;
                

            }
            else
            {
                MessageBox.Show("password wrong");

            }
        }
    }
}
