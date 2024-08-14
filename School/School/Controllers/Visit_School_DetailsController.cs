using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using School.DBContext;
using School.DTO;
using School.Models;

namespace School.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Visit_School_DetailsController : ControllerBase
    {
        private readonly SchoolInfoDbContext _db;
       
        public Visit_School_DetailsController(SchoolInfoDbContext db)
        {
            _db=db;
            
        }

        /*---------------------- Merge School and Teachers -----------------*/

        #region School Full Details
        //[Authorize]
        [HttpGet("School Full Details")]

        public IActionResult SchoolFullDetails(string Enter_SchoolName)
        {
            var SchoolData = _db.SchoolInfo.ToList();
            var teachersData = _db.TeachersInformations.ToList();
            var GenderData = _db.Genders.ToList();
            Logging.AddReqResLog("API-IN", "School Full Details", JsonConvert.SerializeObject(new { SchoolData, teachersData }), "info");
            Responses Response = new Responses();
            try
            {


                var School_Details = SchoolData.FindAll(y => y.SchoolName.ToLower().Trim().Replace(" ", "") == Enter_SchoolName.ToLower().Trim().Replace(" ", ""));
                var teachersDetails = teachersData.FindAll(x => x.currently_workking_school_Name.ToLower().Trim().Replace(" ", "") == Enter_SchoolName.ToLower().Trim().Replace(" ", ""));

                var Teachers_Details = from TD in teachersDetails
                                       join TG in GenderData on TD.Gender equals TG.Id
                                       select new
                                       {
                                           Teacher_Name = TD.TeachersName,
                                           ID = TD.TeachersId,
                                           Age = TD.TeachersAge,
                                           MobileNo = TD.Teachers_MobileNo,
                                           Gender = TG.type,
                                           Teching_Class = TD.which_Class_Teaching,
                                           Join_Date = TD.Joining_Date,
                                           Salary = TD.Teachers_salary,
                                           Stay_Location = TD.Staying_Location,

                                       };
                if(School_Details.Count==0 || Teachers_Details==null)
                {
                    Response.ResponseCode = "204"; Response.ResponseMessage = "This Name Not Exist in database. Enter Correct SchoolName";
                    Logging.AddReqResLog("API-OUT", "School Full Details", JsonConvert.SerializeObject(Response), "error");
                    return Ok(Response);
                }
            
                return Ok(new { School_Details, Teachers_Details });
            }
            catch (Exception ex)
            {

                Response.ResponseCode = "500"; Response.ResponseMessage = " When your API Meeting in error for (Internal Server Error).  Now you will Checking in SchoolFullDetails API. Reason : " + ex.Message;
                Logging.AddReqResLog("API-OUT", "School Full Details", JsonConvert.SerializeObject(Response), "exc");
                return Ok(Response);
            }





        }



        #endregion
    }
}
