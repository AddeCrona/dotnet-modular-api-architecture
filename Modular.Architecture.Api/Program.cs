using Microsoft.OpenApi.Models;
using Modular.Architecture.Api.Extensions;
using Modular.Architecture.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http.Json;
using System.Text.Json;
using Modular.Architecture.Core;
using AutoMapper;
using Modular.Architecture.Api;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers(options => options.UseNamespaceRouteToken());

builder.Services.Configure<JsonOptions>(options => {
    options.SerializerOptions.PropertyNamingPolicy = JsonNamingPolicy.CamelCase;
    options.SerializerOptions.AllowTrailingCommas = true;
});

// Auto Mapper Configurations
var mapperConfig = new MapperConfiguration(mc =>
{
    mc.AddProfile(new AutoMapperProfile());
});

IMapper mapper = mapperConfig.CreateMapper();
builder.Services.AddSingleton(mapper);


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c => {
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "Modular Ecom Api", Version = "v1" });
    c.EnableAnnotations();
});

builder.Services.AddDbContext<ApplicationDbContext>(options => {
    options.UseSqlServer("name=ConnectionStrings:DefaultConnection");
    options.UseLazyLoadingProxies();
}, ServiceLifetime.Transient);

builder.Services.AddTransient(typeof(IAsyncRepository<>), typeof(EfRepository<>));

// Register all Modules.
builder.Services.RegisterModules();

var app = builder.Build();

app.UseHttpLogging();

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
