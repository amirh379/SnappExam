using FluentValidation;
using Infrastructure.Persistence.Ef;
using Microsoft.EntityFrameworkCore;
using SnappExam.Core.Application.Commands;
using SnappExam.Core.Application.CommandValidators;
using SnappExam.Infrastructure.Configuration.Extentions;

var builder = WebApplication.CreateBuilder(args);
var configuration = builder.Configuration;


builder.Services.AddMemoryCache();

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//builder.Services.AddDbContext<ApplicationDbContext>(option => option.UseSqlServer(configuration.GetConnectionString("SqlServer")));

builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(AddProductCommand).Assembly));
builder.Services.AddDependencyInjectionService(configuration);
builder.Services.AddValidatorsFromAssemblyContaining<AddProductCommandValidator>();



var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseResponseCaching();


app.MapControllers();

app.Run();
