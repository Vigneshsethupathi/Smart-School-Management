using System.ComponentModel.DataAnnotations;

namespace School.DTO
{
    public class Gender
    {
        [Key]
        public int Id { get; set; }
        public string type { get; set; }
    }
}
