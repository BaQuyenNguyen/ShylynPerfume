using Microsoft.EntityFrameworkCore;
using ShylynPerfumeAPI.Data.Infrastructure.Core;
using ShylynPerfumeAPI.Services.ImpServices;
using ShylynPerfumeAPI.Services.InterfaceServices;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<CoreDataContext>(option =>
{
    option.UseSqlServer(builder.Configuration.GetConnectionString("DbConnection"));
});
builder.Services.AddScoped<ICategoryService, CategoryService>();

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
