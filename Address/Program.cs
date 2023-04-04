using Address.Commands.Cities;
using Address.Commands.Countries;
using Address.Commands.Regions;
using Address.Commands.Streets;
using Address.Context;
using FluentValidation;
using FluentValidation.AspNetCore;
using MediatR;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<ApplicationDbContext>();
builder.Services.AddMediatR(Assembly.GetExecutingAssembly())
    ;
builder.Services.AddFluentValidationAutoValidation();
builder.Services.AddScoped<IValidator<CreateCountryCommand>, CreateCountryValidator>();
builder.Services.AddScoped<IValidator<UpdateCountryCommand>, UpdateCountryValidator>();
builder.Services.AddScoped<IValidator<CreateRegionCommand>, CreateRegionValidator>();
builder.Services.AddScoped<IValidator<UpdateRegionCommand>, UpdateRegionValidator>();
builder.Services.AddScoped<IValidator<CreateCityCommand>, CreateCityValidator>();
builder.Services.AddScoped<IValidator<UpdateCityCommand>, UpdateCityValidator>();
builder.Services.AddScoped<IValidator<CreateStreetCommand>, CreateStreetValidator>();
builder.Services.AddScoped<IValidator<UpdateCityCommand>, UpdateCityValidator>();

builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
