using Microsoft.EntityFrameworkCore;
using School.DTO;
using School.DTO.TokenRelative;
using School.Models;

namespace School.DBContext
{
    public class SchoolInfoDbContext:DbContext
    {
        public SchoolInfoDbContext(DbContextOptions<SchoolInfoDbContext>options) : base(options)
        {   
        }
        public DbSet<SchoolInfo> SchoolInfo { get; set; } //<----------School Information DB
        //public DbSet<UserModel> UserModels { get; set; }//<----------Authentication user table
        public DbSet<TeachersInformation> TeachersInformations { get; set; }//<----------Teachers Informations table
        public DbSet<Gender> Genders { get; set; } //<----------Gender table


    }
   
}
