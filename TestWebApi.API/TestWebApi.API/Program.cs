using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using TestWebApi.API.Data;
using TestWebApi.API.Model;
using TestWebApi.API.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddIdentity<ApplicationUser, IdentityRole>()
    .AddEntityFrameworkStores<BookDbContext>()
    .AddDefaultTokenProviders();

builder.Services.AddDbContext<BookDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("BookDbConnection"));
});

builder.Services.AddControllers().AddNewtonsoftJson();

builder.Services.AddTransient<IBookRepository, BookRepository>();
builder.Services.AddTransient<IAccountRepository, AccountRepository>();

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

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
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
