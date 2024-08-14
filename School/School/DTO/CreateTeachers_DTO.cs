using Microsoft.EntityFrameworkCore.Storage.Json;
using Microsoft.VisualBasic;
using Newtonsoft.Json.Converters;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace School.DTO
{
    public class CreateTeachers_DTO
    {


        [Required]
        public string TeachersName { get; set; } = null!;

        [Required]
        public int TeachersAge { get; set; }

        [Required]
        public long Teachers_MobileNo { get; set; }

        public required int Gender { get; set; }

        public required string currently_workking_school_Name { get; set; }

        [Required]
        public int which_Class_Teaching { get; set; }


        public required string Joining_Date { get; set; }

        [Required]
        public float Teachers_salary { get; set; }

        [Required]
        public string Staying_Location { get; set; } = null!;
    }
}
