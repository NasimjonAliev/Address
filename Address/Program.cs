using Address.Commands.Cities;
using Address.Commands.Countries;
using Address.Commands.Regions;
using Address.Commands.Streets;
using Address.Context;
using Address.Services;
using FluentValidation;
using FluentValidation.AspNetCore;
using MediatR;
using Microsoft.AspNetCore.Authentication;
using Microsoft.OpenApi.Models;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<ApplicationDbContext>();
builder.Services.AddMediatR(Assembly.GetExecutingAssembly());
builder.Services.AddFluentValidationAutoValidation();

builder.Services.AddScoped<IValidator<CreateCountryCommand>, CreateCountryValidator>();
builder.Services.AddScoped<IValidator<UpdateCountryCommand>, UpdateCountryValidator>();
builder.Services.AddScoped<IValidator<CreateRegionCommand>, CreateRegionValidator>();
builder.Services.AddScoped<IValidator<UpdateRegionCommand>, UpdateRegionValidator>();
builder.Services.AddScoped<IValidator<CreateCityCommand>, CreateCityValidator>();
builder.Services.AddScoped<IValidator<UpdateCityCommand>, UpdateCityValidator>();
builder.Services.AddScoped<IValidator<CreateStreetCommand>, CreateStreetValidator>();
builder.Services.AddScoped<IValidator<UpdateCityCommand>, UpdateCityValidator>();
builder.Services.AddScoped<IUserService, UserService>();

builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddAuthentication("BasicAuthentication")
    .AddScheme<AuthenticationSchemeOptions, BasicAuthenticationHandler>("BasicAuthentication", null);

builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "BasicAuth", Version = "v1" });
    c.AddSecurityDefinition("basic", new OpenApiSecurityScheme
    {
        Name = "Authorization",
        Type = SecuritySchemeType.Http,
        Scheme = "basic",
        In = ParameterLocation.Header,
        Description = "Basic Authorization header using the Bearer scheme."
    });
    c.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    {
                          new OpenApiSecurityScheme
                            {
                                Reference = new OpenApiReference
                                {
                                    Type = ReferenceType.SecurityScheme,
                                    Id = "basic"
                                }
                            },
                            new string[] {}
                    }
                });
});  

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
