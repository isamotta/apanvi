using Apanvi.API.Repositories;
using System.Text.Json.Serialization;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using Apanvi.API.Context;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers().AddJsonOptions(options =>
    options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter()));
builder.Services.AddTransient<IAnimalRepository, AnimalRepository>();
builder.Services.AddTransient<IUserRepository, UserRepository>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//builder.Services.AddDbContext(options => options.ConnectionString = Configuration.GetConnectionString("DefaultConnection"));
builder.Services.AddDbContext<ConnectionContext>(
    o => o.UseNpgsql(builder.Configuration.GetConnectionString("ApanviDb"))
    );
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

//app.Seed();

app.Run();
