global using FastEndpoints;
using FastEndpoints.Swagger;
using Microsoft.AspNetCore.Authentication.JwtBearer;

var bld = WebApplication.CreateBuilder();
bld.Services
   .AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
   .AddJwtBearer(
       o =>
       {
           o.Authority = $"https://{bld.Configuration["Auth0:Domain"]}/";
           o.Audience = bld.Configuration["Auth0:Audience"];
       });
bld.Services
   .AddAuthorization()
   .AddFastEndpoints()
   .SwaggerDocument();

var app = bld.Build();
app.UseAuthentication()
   .UseAuthorization()
   .UseFastEndpoints()
   .UseSwaggerGen();
app.Run();