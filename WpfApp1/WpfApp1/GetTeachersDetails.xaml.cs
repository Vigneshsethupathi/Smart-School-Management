using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WpfApp1.Classes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for GetTeachersDetails.xaml
    /// </summary>
    public partial class GetTeachersDetails : Window
    {
        public GetTeachersDetails()
        {
            InitializeComponent();
            GetTeachers(null, null);
        }

        private void pass_TextChanged(object sender, RoutedEventArgs e)
        {
            if (Pass.Password != "")
            {
                
                Pass_Placeholder.Visibility = Visibility.Hidden;
            }
            else
            {
               
                Pass_Placeholder.Visibility = Visibility.Visible;
            }
        }

        private async void GetTeachers(object sender, RoutedEventArgs e)  // get school details------------------------>
        {
            try
            {
                var ApiControllerUrl = "https://localhost:7022/api/School/";
                var cleint = new RestClient(ApiControllerUrl);

                var request = new RestRequest("Get teachers details", Method.Get);
                request.AddHeader("Content-type", "application/json");


                var response = await cleint.ExecuteAsync(request);
                var responseData = response.Content;

                if (response.StatusCode == HttpStatusCode.OK)
                {

                    List<TeachersInformation> sdata = JsonConvert.DeserializeObject<List<TeachersInformation>>(responseData);
                    TeachersGetValues.ItemsSource = sdata;

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
        private void Back_Button_teacher_Get(object sender, RoutedEventArgs e)
        {

            SchoolDetails schoolDetails = new SchoolDetails();
            this.Close();
            schoolDetails.Show();

            schoolDetails.TeacherContent.Visibility = Visibility.Visible;
            schoolDetails.PencilLogo.Visibility = Visibility.Hidden;
            schoolDetails.SchoolContent.Visibility = Visibility.Hidden;
            schoolDetails.schoolMenu.Visibility = Visibility.Visible;
        }

        private void Image_MouseLeftButtonDownTeacher(object sender, MouseButtonEventArgs e)
        {
            string password = "0000";
            if (Pass.Password == password)
            {
                EnterPasswordTeacher.Visibility = Visibility.Hidden;
                blurimage.Visibility = Visibility.Hidden;
                TeachersGetValues.Visibility = Visibility.Visible;

            }
            else
            {
                MessageBox.Show("password wrong");

            }
        }

        private void Logout_Icon_GetPage(object sender, MouseButtonEventArgs e)
        {
            SchoolDetails schoolData = new SchoolDetails();
            this.Close();
            schoolData.Show();
        }

        private void Cancel_Button_School_Get(object sender, RoutedEventArgs e)
        {
            SchoolDetails schoolDetails = new SchoolDetails();
            this.Close();
            schoolDetails.Show();
        }
    }
}
