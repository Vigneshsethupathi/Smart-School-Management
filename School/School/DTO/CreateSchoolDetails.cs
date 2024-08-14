using System.ComponentModel.DataAnnotations;

namespace School.DTO
{
    public class CreateSchoolDetails
    {




        [Required]
        public string SchoolName { get; set; } = null!;

        [Required]
        public string School_Admin_Name { get; set; } = null!;

        [Required]
        public long HeadMaster_MobilNO { get; set; }

        [Required]
        public int How_Many_Teachers_Gender_Male { get; set; }

        [Required]
        public int How_Many_Teachers_Gender_Female { get; set; }

        //[Required]
        //public float School_Playground_in_SquareFeet { get; set; }

        [Required]
        public string SchoolLocation { get; set; } = null!;


    }
}
