using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using TwitterAPIStreamApp.Data;
using TwitterAPIStreamApp.Models;


var builder = WebApplication.CreateBuilder(args);

//builder.Services.AddDbContext<TwitterAPIStreamAppContext>(options =>
//    options.UseSqlServer(builder.Configuration.GetConnectionString("TwitterAPIStreamAppContext") ?? throw new InvalidOperationException("Connection string 'TwitterAPIStreamAppContext' not found.")));

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Added the below code to test - Microsoft.EntityFrameworkCore.InMemory - needed to use in memory
builder.Services.AddDbContext<TweetsContext>(options =>
{
    options.UseInMemoryDatabase("Tweets");
});

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
