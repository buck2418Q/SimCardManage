using DTOLayer.Mapping;
using Microsoft.EntityFrameworkCore;
using Repos.Repository;
using Repos.Repository.IRepository;
using SimCardData.Data;
using System;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddAutoMapper(typeof(MappingProfile));



builder.Services.AddScoped<IAdminRepository, AdminRepository>();
builder.Services.AddScoped<IDeviceRepository, DeviceRepository>();

builder.Services.AddScoped<IProviderRepository, ProviderRepository>();

//builder.Services.AddScoped<ISimCardPlanRepository, ISimCardPlanRepository>();
//builder.Services.AddScoped<ISimRepository, ISimRepository>();

builder.Services.AddScoped<IUserRepository,UserRepository>();





builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("conectionToDb")) );
builder.Services.AddControllers();
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
