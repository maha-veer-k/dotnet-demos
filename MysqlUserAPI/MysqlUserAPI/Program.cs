using Microsoft.EntityFrameworkCore;
using MysqlUserAPI.Data;
using MysqlUserAPI.Repository;
using MysqlUserAPI.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.\

string ConnString = builder.Configuration.GetConnectionString("UserDbString");
//Add service to connect database
builder.Services.AddDbContext<UserDbContext>(options => 
            options.UseMySql(ConnString, ServerVersion.AutoDetect(ConnString)));

builder.Services.AddTransient<IUserRepository, UserRepository>();
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
