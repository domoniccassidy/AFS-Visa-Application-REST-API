using AFS_Visa_Application_REST_API.Router;
using Microsoft.OpenApi.Models;
using AFS_Visa_Application_REST_API.Service;
using AFS_Visa_Application_REST_API.Mapping;

namespace AFS_Visa_Application_REST_API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var _allowSpecificOriginsPolicy = "allowSpecificOriginsPolicy";
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddCors(options =>
            {
                options.AddPolicy( _allowSpecificOriginsPolicy,
                                  policy =>
                                  {
                                      policy.WithOrigins("http://localhost:3000").AllowAnyHeader();
                                  });
            });


            builder.Services.AddAuthentication().AddJwtBearer();
            builder.Services.AddAuthorization();

            builder.Services.AddAuthorizationBuilder()
              .AddPolicy("authorised_visa_applicant", policy =>
                    policy
                        .RequireRole("authorised_visa_applicant"));

            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen(c =>
            {
                c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                {
                    Name = "Bearer",
                    BearerFormat = "JWT",
                    Scheme = "bearer",
                    Description = "Specify the authorization token.",
                    In = ParameterLocation.Header,
                    Type = SecuritySchemeType.Http,

                });
                c.AddSecurityRequirement(new OpenApiSecurityRequirement {
                   {
                     new OpenApiSecurityScheme
                     {
                       Reference = new OpenApiReference
                       {
                         Type = ReferenceType.SecurityScheme,
                         Id = "Bearer",
                       }
                     },
                     new string[] { }
                   }
                });
            });


            builder.Services.AddAutoMapper(typeof(MappingProfile));

            builder.ConfigureServices();

            var app = builder.Build();

            app.UseCors(_allowSpecificOriginsPolicy);   
            app.ConfigureVisaApplicationEndpoints();
            app.ConfigureVisaEndpoints();
            app.ConfigureCountryEndpoints();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI(c => c.EnablePersistAuthorization());
            }

            app.Run();
        }
    }
}