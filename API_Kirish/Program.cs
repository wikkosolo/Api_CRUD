using API_Kirish.BL.Services;
using API_Kirish.Data;
using API_Kirish.Data.Interfaces;
using API_Kirish.Data.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<CarDbContext>(options 
    =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("LocalDb")));

builder.Services.AddTransient<ICarInterface, CarRepository>();
builder.Services.AddTransient<ICarService, CarService>();
builder.Services.AddTransient<IBrendsInterface, BrendsRepository>();
builder.Services.AddTransient<IBrendService, BrendService>();

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
