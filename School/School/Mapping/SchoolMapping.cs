using AutoMapper;
using School.DTO;
using School.Models;

namespace School.Mapping
{
    public class SchoolMapping:Profile
    {
        public SchoolMapping()
        {
            CreateMap<SchoolInfo, CreateSchoolDetails>().ReverseMap();
            CreateMap<TeachersInformation, CreateTeachers_DTO>().ReverseMap();
            
          
        }
    }

   
}
