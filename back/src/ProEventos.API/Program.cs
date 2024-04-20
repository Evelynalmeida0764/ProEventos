using Microsoft.EntityFrameworkCore;
using ProEventos.API.Data;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// public Startup(IConfiguration configuration)
//     {
//             Configuration = configuration;
//     }

//public IConfiguration Configuration {get; }//sla tentei e não deu certo

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<DataContext>(
    context => context.UseSqlite(builder.Configuration.GetConnectionString("Default"))
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

app.Run();
