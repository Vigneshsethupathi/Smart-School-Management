using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace School.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Genders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    type = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SchoolInfo",
                columns: table => new
                {
                    SchoolId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SchoolName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    School_Admin_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HeadMaster_MobilNO = table.Column<long>(type: "bigint", nullable: false),
                    How_Many_Teachers_Gender_Male = table.Column<int>(type: "int", nullable: false),
                    How_Many_Teachers_Gender_Female = table.Column<int>(type: "int", nullable: false),
                    Total_Teachers = table.Column<int>(type: "int", nullable: false),
                    School_Playground_in_SquareFeet = table.Column<float>(type: "real", nullable: false),
                    SchoolLocation = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SchoolInfo", x => x.SchoolId);
                });

            migrationBuilder.CreateTable(
                name: "TeachersInformations",
                columns: table => new
                {
                    TeachersId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeachersName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TeachersAge = table.Column<int>(type: "int", nullable: false),
                    Teachers_MobileNo = table.Column<long>(type: "bigint", nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    currently_workking_school_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    which_Class_Teaching = table.Column<int>(type: "int", nullable: false),
                    Joining_Date = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Teachers_salary = table.Column<float>(type: "real", nullable: false),
                    Staying_Location = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeachersInformations", x => x.TeachersId);
                });

            migrationBuilder.CreateTable(
                name: "UserModels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserModels", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Genders");

            migrationBuilder.DropTable(
                name: "SchoolInfo");

            migrationBuilder.DropTable(
                name: "TeachersInformations");

            migrationBuilder.DropTable(
                name: "UserModels");
        }
    }
}
