using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Classes
{
    internal class Models
    {
    }


    public class SchoolData
    {
     
        public int SchoolId { get; set; }
        public string SchoolName { get; set; } = null!;
        public string School_Admin_Name { get; set; } = null!;
        public long HeadMaster_MobilNO { get; set; }
        public int How_Many_Teachers_Gender_Male { get; set; }
        public int How_Many_Teachers_Gender_Female { get; set; }
        public int Total_Teachers { get; set; }
        public string SchoolLocation { get; set; } = null!;

    }
    public class TeachersInformation
    {
        public int TeachersId { get; set; }
        public string TeachersName { get; set; } = null!;
        public int TeachersAge { get; set; }
        public long Teachers_MobileNo { get; set; }
        public required int Gender { get; set; }
        public required string currently_workking_school_Name { get; set; }
        public int which_Class_Teaching { get; set; }
        public required string Joining_Date { get; set; }
        public float Teachers_salary { get; set; }
        public string Staying_Location { get; set; } = null!;


    }


}
