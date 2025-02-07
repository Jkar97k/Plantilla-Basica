using api_basica.Interfaces.http;
using api_basica.Interfaces.Repository;
using api_basica.Interfaces.Services;
using api_basica.Interfaces.Utilities;
using api_basica.Repository.Base;
using api_basica.Repository.Context;
using api_basica.Repository.Models;
using api_basica.Repository.Repos;
using api_basica.Services.httpServices;
using api_basica.Services.master;
using api_basica.Utilities.AutoMapper;
using api_basica.Utilities.Http;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//database
builder.Services.AddDbContext<CentroMedicoContext>((DbContextOptionsBuilder options) =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("SqlConnections"));
});

//services
builder.Services.AddKeyedScoped<IPacienteSevices, PacienteSevices>("pacienteskey1");
builder.Services.AddKeyedScoped<IPacienteSevices, PacienteSevices>("pacienteskey2");
builder.Services.AddKeyedScoped<IPostHttpService, PostHttpService>("PostServices");

//repository
builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
builder.Services.AddScoped<IPacienteRepository, PacienteRepository>();

//mappers
builder.Services.AddAutoMapper(typeof(MappingProfile));
builder.Services.AddScoped<IMapperAdapter, MapperAdapter>();

//http
//builder.Services.AddScoped<IHttpService, HttpService>();

builder.Services.AddHttpClient<IHttpService, HttpService>(uri => 
{
    uri.BaseAddress = new Uri(builder.Configuration["BaseUrlPost"]);
});

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
