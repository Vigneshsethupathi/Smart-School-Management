using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;
using School.DBContext;
using School.DTO;
using School.DTO.TokenRelative;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace School.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Your_Token_hearController : ControllerBase
    {
        //private readonly JwtSettings _jwtSettings;
        //private readonly SchoolInfoDbContext _db;
        //public List<UserLogin> finaltoken = new List<UserLogin>();
 
        //public Your_Token_hearController(SchoolInfoDbContext db, IOptions<JwtSettings> options)
        //{
        //    _db = db;
        //    _jwtSettings = options.Value;

        //}
        //#region token generete
        //[AllowAnonymous]
        //[HttpPost("Authenticate")]
        //public IActionResult CreateToken([FromBody] UserLogin user)
        //{
        //    Logging.AddReqResLog("API-IN", "Authenticate", JsonConvert.SerializeObject(user), "info");
        //    Responses Response = new Responses();
        //    try
        //    {

        //        var userdb = _db.UserModels.FirstOrDefault(x => x.UserName.Trim() == user.UserName.Trim() && x.Password.Trim() == user.Password.Trim());
        //        if (userdb == null)
        //        {
        //            Response.ResponseCode = "400"; Response.ResponseMessage = "Enter Correct UserName and Password";
        //            Logging.AddReqResLog("API-OUT", "School Full Details", JsonConvert.SerializeObject(Response), "error");
                   
        //            return Unauthorized(Response);
        //        }
        //        var tokenhandler = new JwtSecurityTokenHandler();
        //        var secretkey = Encoding.UTF8.GetBytes(_jwtSettings.SecretKey);
        //        var tokendescripter = new SecurityTokenDescriptor
        //        {
        //            Subject = new ClaimsIdentity(new Claim[]
        //                {
        //                new Claim(ClaimTypes.Name, userdb.UserName),
        //                }),
        //            Expires = DateTime.Now.AddHours(1),
        //            SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(secretkey), SecurityAlgorithms.HmacSha256)
        //        };
        //        var token = tokenhandler.CreateToken(tokendescripter);
        //        string finaltoken = " Get Your Token : " + tokenhandler.WriteToken(token);
        //        return Ok(finaltoken);
        //    }
        //    catch (Exception ex)
        //    {

        //        Response.ResponseCode = "500"; Response.ResponseMessage = " When your API Meeting in error for (Internal Server Error).  Now you will Checking in TokenGenerate API. Reason : " + ex.Message;
        //        Logging.AddReqResLog("API-OUT", "Authenticate", JsonConvert.SerializeObject(Response), "exc");
        //        return Ok(Response);
        //    }
        //}


        //#endregion
    }
}
