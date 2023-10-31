using Microsoft.EntityFrameworkCore;
using ShopThoiTrang.BackEnd.Databases;
using ShopThoiTrang.BackEnd.IRepositories;
using ShopThoiTrang.BackEnd.Repositories;
using ShopThoiTrang.BackEnd.UnitOfWorks;

var builder = WebApplication.CreateBuilder(args);
var configuration = builder.Configuration;

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<MainDbContext>(options => {
    // options.UseSqlServer(configuration.GetConnectionString("sqlserver"));
    options.UseSqlServer(configuration.GetConnectionString("sqlserverHC"));
    // options.UseMySQL(configuration.GetConnectionString("mysql"));
});

builder.Services.AddTransient<IProductRepository, ProductRepository>();
builder.Services.AddTransient<IUnitOfWork, UnitOfWork>();

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
