using test_crud.Data;
using Microsoft.EntityFrameworkCore;
using test_crud.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

string mysqlConntection = builder.Configuration.GetConnectionString("Default");

builder.Services.AddDbContext<UserContext>(options =>
{

  options.UseMySql(mysqlConntection,
  ServerVersion.AutoDetect(mysqlConntection));

});

builder.Services.AddScoped<IUserRepository, UserRepository>();

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
