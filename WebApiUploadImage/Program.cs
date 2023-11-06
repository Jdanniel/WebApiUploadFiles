using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using System;
using System.IO;
using System.Reflection;
using WebApiUpload.Configs;
using WebApiUpload.Interfaces;
using WebApiUpload.Models;
using WebApiUpload.Services;

var builder = WebApplication.CreateBuilder(args);

var configuration = builder.Configuration;
// Add services to the container.
builder.Services.AddControllers();

builder.Services.AddCors(o => {
    o.AddPolicy("CorsPolicy",
        builder =>
        builder
        .AllowAnyOrigin()
        .AllowAnyMethod()
        .AllowAnyHeader());
});
builder.Services.AddAntiforgery(options =>
{
    options.FormFieldName = "AntiforgeryFieldname";
    options.HeaderName = "X-CSRF-TOKEN-HEADERNAME";
    options.SuppressXFrameOptionsHeader = false;
});
builder.Services.AddScoped<IRandomServices, RandomServices>();
builder.Services.AddTransient<IAwsServices, AwsServices>();
builder.Services.Configure<GetnetConfig>(configuration.GetSection("GetnetConfig"));
builder.Services.AddDbContext<GetnetUatContext>(options => options.UseSqlServer(configuration.GetConnectionString("ElavonTest")));
builder.Services.AddSwaggerGen(doc =>
{
    doc.SwaggerDoc("v1", new OpenApiInfo { Title = "Getnet - App - Images", Version = "v1" });

    var xmlPath = Path.Combine(AppContext.BaseDirectory, $"{Assembly.GetExecutingAssembly().GetName().Name}.xml");
    doc.IncludeXmlComments(xmlPath);
});
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseSwagger();

app.UseSwaggerUI(options =>
{
    string swaggerJsonBasePath = string.IsNullOrWhiteSpace(options.RoutePrefix) ? "." : "..";
    options.SwaggerEndpoint($"{swaggerJsonBasePath}/swagger/v1/swagger.json", "Getnet - App - Images V1");
});

app.UseRouting();

app.UseCors("CorsPolicy");

app.Use(async (context, next) =>
{
    context.Response.GetTypedHeaders().CacheControl =
        new Microsoft.Net.Http.Headers.CacheControlHeaderValue()
        {
            Public = false,
            MaxAge = TimeSpan.FromSeconds(10)
        };
    context.Response.Headers[Microsoft.Net.Http.Headers.HeaderNames.Vary] =
        new string[] { "Accept-Encoding" };
    await next();
});

app.UseAuthorization();

app.MapControllers();

app.Run();
