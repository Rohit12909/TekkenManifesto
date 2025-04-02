using Microsoft.EntityFrameworkCore;
using tekkenManifesto.API.Data;
using tekkenManifesto.API.Repository;
using tekkenManifesto.API.Service;
using tekkenManifesto.API.DTO;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<TekkenContext>(options => 
    options.UseSqlServer(builder.Configuration.GetConnectionString("tekken")));

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Dependency Inject Services
builder.Services.AddScoped<ICharService, CharService>();
builder.Services.AddScoped<IComboService, ComboService>();
builder.Services.AddScoped<IHEService, HeatEngagerService>();
builder.Services.AddScoped<ILauncherService, LauncherService>();
builder.Services.AddScoped<IPunisherService, PunisherService>();
builder.Services.AddScoped<IStanceService, StanceService>();

// Dependency Inject Repositories
builder.Services.AddScoped<ICharRepository, CharRepository>();
builder.Services.AddScoped<IComboRepository, ComboRepository>();
builder.Services.AddScoped<IHERepository, HERepository>();
builder.Services.AddScoped<ILauncherRepository, LauncherRepository>();
builder.Services.AddScoped<IPunisherRepository, PunisherRepository>();
builder.Services.AddScoped<IStanceRepository, StanceRepository>();

//Add AutoMapper
builder.Services.AddAutoMapper(typeof(MappingProfile));

// Add Controllers
builder.Services.AddControllers()
    .AddJsonOptions(options =>
    {
        options.JsonSerializerOptions.ReferenceHandler = System.Text.Json.Serialization.ReferenceHandler.IgnoreCycles;
    });

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.MapControllers();
app.Run();