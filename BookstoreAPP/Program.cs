using BookstoreAPP.Services;
using Microsoft.EntityFrameworkCore;
using ShoppingCartSystem.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddSingleton<IMessageQueue>(sp =>
{
	var config = sp.GetRequiredService<IConfiguration>();
	var hostname = config["RabbitMQ:HostName"];
	var username = config["RabbitMQ:UserName"];
	var password = config["RabbitMQ:Password"];
	return new RabbitMQMessageQueue(hostname, username, password);
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
