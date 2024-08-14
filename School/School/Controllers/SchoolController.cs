using AutoMapper;
using Azure.Core;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;
using School.DBContext;
using School.DTO;
using School.DTO.TokenRelative;
using School.Models;
using Serilog.Filters;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Net;
using System.Security.Claims;
using System.Text;

namespace School.Controllers
{
  // [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class SchoolController : ControllerBase
    {
        private readonly SchoolInfoDbContext _db;
        private readonly IMapper _mapper;
        //private readonly Your_Token_hearController _tokengenerate;
        public SchoolController(SchoolInfoDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
            //_tokengenerate = tokengenerate;

         
        }


        /* ------------------SCHOOL DETAILS-------------------*/

        #region Create School Details
        [AllowAnonymous]
        [HttpPost]
        [Route("create")]
        [ProducesResponseType(typeof(Responses), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<CreateSchoolDetails>> Create(CreateSchoolDetails Dto)
        {
            Logging.AddReqResLog("API-IN", "Create School Details", JsonConvert.SerializeObject(Dto), "info");
            Responses Response = new Responses();
            try
            {
                var DataExist = _db.SchoolInfo.Any(s => s.SchoolName.ToLower().Trim() == Dto.SchoolName.ToLower().Trim() && s.School_Admin_Name.ToLower().Trim() == Dto.School_Admin_Name.ToLower().Trim());
                if (DataExist)
                {
                    Response.ResponseCode = "202"; Response.ResponseMessage = "Accepted But If The Details Is an Already Exist. You can try Different Data";
                    Logging.AddReqResLog("API-OUT", "Create School Details", JsonConvert.SerializeObject(Response), "error");
                    return Ok(Response);
                }
                var SchoolMapping = _mapper.Map<SchoolInfo>(Dto);

                await _db.AddAsync(SchoolMapping);
                await _db.SaveChangesAsync();

                Response.ResponseCode = "200"; Response.ResponseMessage = "If You Have Successfully Created in School Details.  Processing Done!..";
                Logging.AddReqResLog("API-OUT", "Create School Details", JsonConvert.SerializeObject(Response), "info");
                return Ok(Response);

            }
            catch (Exception ex)
            {

                Response.ResponseCode = "500"; Response.ResponseMessage = " When your API Meeting in error for (Internal Server Error).  Now you will Checking in School CREATE API. Reason : " + ex.Message;
                Logging.AddReqResLog("API-OUT", "Create School Details", JsonConvert.SerializeObject(Response), "exc");
                return Ok(Response);
            }

        }

        #endregion

        #region Get School Details

        
        [HttpGet]
        [Route("GetSchool Details")]
        [ProducesResponseType(typeof(Responses), (int)HttpStatusCode.OK)] 
        public async Task<ActionResult<SchoolInfo>> Get()
        {

            //var tokengenerate = _tokengenerate.finaltoken;
            //var authorizationHeaderValue = HttpContext.Request.Headers["Authorization"];

            //if (tokengenerate == authorizationHeaderValue)
            //{
            //}
            //else
            //    {
            //        return Conflict(" your unauthorized");
            //    }


                var alldata = await _db.SchoolInfo.ToListAsync();
            Logging.AddReqResLog("API-IN", "Create School Details", JsonConvert.SerializeObject(alldata), "info");
            Responses Response = new Responses();
            try
            {
                //string authorizationHeaderValue = HttpContext.Request.Headers["Authorization"];

                //if (!string.IsNullOrWhiteSpace(authorizationHeaderValue) && authorizationHeaderValue.StartsWith("bearer "))
                //{
                //    string token = authorizationHeaderValue.Substring("bearer ".Length).Trim();
                    
                //}
                //else
                //{
                   
                //    return Unauthorized();
                //}



                if (alldata == null)
                    {
                        Response.ResponseCode = "204"; Response.ResponseMessage = "No Content. Because, No Data in Database!... You can try later";
                        Logging.AddReqResLog("API-OUT", "Get School Details", JsonConvert.SerializeObject(Response), "error");
                        return Ok(Response);
                    }
                    else
                    {

                        Response.ResponseCode = "200"; Response.ResponseMessage = "Successfully Processed!... see your data";
                        Logging.AddReqResLog("API-IN", "Get School Details", JsonConvert.SerializeObject(Response), "info");
                        return Ok(alldata);
                    }
                
              
            }
            catch (Exception ex)
            {

                Response.ResponseCode = "500"; Response.ResponseMessage = "When your API Meeting in error for (Internal Server Error).  Now you will Checking in School GET API . Reason : " + ex.Message;
                Logging.AddReqResLog("API-OUT", "Get School Details", JsonConvert.SerializeObject(Response), "exc");
                return Ok(Response);
                }
           
           


        }

        #endregion

        /* ------------------TEACHER'S DETAILS-------------------*/
        #region Create Teachers Details
        [AllowAnonymous]
        [HttpPost]
        [Route("Create_Teachers_Details")]
        public IActionResult createTeachersDetails([FromBody] CreateTeachers_DTO DTO)
        {

            Logging.AddReqResLog("API-IN", "Create_School_Details", JsonConvert.SerializeObject(DTO), "info");
            Responses Response = new Responses();
            try
            {
               


                var DataExist = _db.TeachersInformations.Any(s => s.TeachersName.ToLower().Trim() == DTO.TeachersName.ToLower().Trim() && s.Teachers_MobileNo == DTO.Teachers_MobileNo);
                if (DataExist)
                {
                    Response.ResponseCode = "202"; Response.ResponseMessage = "Accepted But If The Details Is an Already Exist. You can try Different Data";
                    Logging.AddReqResLog("API-OUT", "Create Teachers Details", JsonConvert.SerializeObject(Response), "error");
                    return Ok(Response);
                }
                var TeachersMapping = _mapper.Map<TeachersInformation>(DTO);

              _db.AddAsync(TeachersMapping);
              _db.SaveChangesAsync();

                Response.ResponseCode = "200"; Response.ResponseMessage = "If You Have Successfully Created in Teachers Details.  Processing Done!..";
                Logging.AddReqResLog("API-OUT", "Create Teachers Details", JsonConvert.SerializeObject(Response), "info");
                return Ok(new { Response, TeachersMapping });

            }
            catch (Exception ex)
            {

                Response.ResponseCode = "500"; Response.ResponseMessage = " When your API Meeting in error for (Internal Server Error).  Now you will Checking Teachers CREATE API . Reason : " + ex.Message;
                Logging.AddReqResLog("API-OUT", "Create Teachers Details", JsonConvert.SerializeObject(Response), "exc");
                return Ok(Response);
            }
        }

        #endregion

        #region Get  Teachers Details 
        //[Authorize]
        [HttpGet("Get teachers details")]
        public async Task<ActionResult<TeachersInformation>> get()
        {
            var alldata = await _db.TeachersInformations.ToListAsync();
            Logging.AddReqResLog("API-IN", "Get Teachers Details", JsonConvert.SerializeObject(alldata), "info");
            Responses Response= new Responses();
            try
            {
                if (alldata == null)
                {
                    Response.ResponseCode = "204"; Response.ResponseMessage = "No Content. Because, No Data in Database!... You can try later";
                    Logging.AddReqResLog("API-OUT", "Get School Details", JsonConvert.SerializeObject(Response), "error");
                    return Ok(Response);

                }
                else
                {
                    Response.ResponseCode = "200"; Response.ResponseMessage = "Successfully Processed!...If You Can see your data";
                    Logging.AddReqResLog("API-IN", "Get School Details", JsonConvert.SerializeObject(Response), "info");
                    return Ok( alldata);
                }
                

            }
            catch(Exception ex)
            {
                Response.ResponseCode = "500"; Response.ResponseMessage = "When your API Meeting in error for (Internal Server Error).  Now you will Checking in Teachers GET API . Reason : " + ex.Message;
                Logging.AddReqResLog("API-OUT", "Get School Details", JsonConvert.SerializeObject(Response), "exc");
                return Ok(Response);

            }
        }


        #endregion




    }
}
