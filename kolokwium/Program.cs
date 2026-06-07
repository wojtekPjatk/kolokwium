using kolokwium.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
//builder.Services.AddScoped<IDbService, DbService>();
builder.Services.AddDbContext<AppDbContext>(opt =>
{
    //Pobieranie danych z pliku appsettings builder.Configuration.GetConnectionString("DefaultConnection")
    opt.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});


var app = builder.Build();

app.UseHttpsRedirection();

app.MapControllers();

app.Run();