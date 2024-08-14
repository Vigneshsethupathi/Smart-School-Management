using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using School.DBContext;
using School.DTO.TokenRelative;
using School.Mapping;
using Serilog;
using Swashbuckle.AspNetCore.Filters;
using System.Configuration;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
#region CORS Implement
builder.Services.AddCors(options =>
{
    options.AddPolicy("defaultpolicy", x => x.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());
});
#endregion

#region DB Configure

builder.Services.AddDbContext<SchoolInfoDbContext>(options=>options.UseSqlServer(
 builder.Configuration.GetConnectionString("DefaultConnection")));

#endregion

#region Mapping Configure

builder.Services.AddAutoMapper(typeof(SchoolMapping));

#endregion

#region Serilog Configure

Log.Logger = new LoggerConfiguration()
          .MinimumLevel.Information()
          .Enrich.FromLogContext()
          .ReadFrom.Configuration(builder.Configuration)
          .CreateLogger();
builder.Logging.ClearProviders();
builder.Logging.AddSerilog(Log.Logger);
builder.Host.UseSerilog(Log.Logger);

#endregion

//#region Authenticate cofigure

//var _jwtsettings = builder.Configuration.GetSection("JwtSettings");
//builder.Services.Configure<JwtSettings>(_jwtsettings);

////------------authenticate valid---------------
//var AuthKey = builder.Configuration.GetValue<string>("JwtSettings:SecretKey");

//builder.Services.AddAuthentication(item =>
//{
//    item.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
//    item.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
//}).AddJwtBearer(x =>
//{       
//    x.RequireHttpsMetadata = true;
//    x.SaveToken = true;
//    x.TokenValidationParameters = new TokenValidationParameters()
//    {
//        ValidateIssuerSigningKey = true,
//        IssuerSigningKey=new SymmetricSecurityKey(Encoding.UTF8.GetBytes(AuthKey)),
//        ValidateIssuer=false,
//        ValidateAudience=false, 

//    };

//});

//#endregion

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

# region Swagger use Authorization

builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "Your API", Version = "v1" });

    // Add JWT Authentication
    c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        Description = "JWT Authorization header using the Bearer scheme",
        Name = "Authorization",
        In = ParameterLocation.Header,
        Type = SecuritySchemeType.Http,
        Scheme = "bearer"
    });
    c.AddSecurityRequirement(new OpenApiSecurityRequirement{

        {
            new OpenApiSecurityScheme{

                    Reference=new OpenApiReference{

                        Type = ReferenceType.SecurityScheme,
                        Id = "Bearer"
                    }
                },
                new string[]{}
            }

    });
});

#endregion

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();
