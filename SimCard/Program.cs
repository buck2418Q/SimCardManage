using Microsoft.EntityFrameworkCore;
using SimCardData.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services(IServiceCollection)
builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("conectionToDb")));

var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
