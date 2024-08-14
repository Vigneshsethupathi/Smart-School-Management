using System.ComponentModel.DataAnnotations;

namespace School.Models
{
    public class SchoolInfo
    {

        [Key]
        public int SchoolId  { get; set; }
     
        [Required]
        public string SchoolName   { get; set; } = null!;
      
        [Required]
        public string School_Admin_Name { get; set; } = null!;

        [Required]
        public long HeadMaster_MobilNO { get; set; }
       
        [Required]
        public int How_Many_Teachers_Gender_Male { get; set; }
      
        [Required]
        public int How_Many_Teachers_Gender_Female{ get; set; }
      
        public int Total_Teachers { get
            {
                var total = How_Many_Teachers_Gender_Male + How_Many_Teachers_Gender_Female;
                return total;
            } set { } }


        //[Required]
        //public float School_Playground_in_SquareFeet { get; set; }

        [Required]
        public string SchoolLocation { get; set; } = null!;


    }
}
