using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using WebApiUpload.Models;
using System.Reflection;
using System.IO;

namespace WebApiUploadImage
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ELAVONTESTContext>(options => options.UseSqlServer("ElavonTest"));
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
            services.AddCors(o => o.AddPolicy("AllowAll",
                builder =>
                {
                    builder.AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader()
                    .AllowCredentials();
                }
                ));
            services.Configure<IISServerOptions>(options =>
            {
                options.AutomaticAuthentication = false;
            });
            services.Configure<IISOptions>(options => {
                options.ForwardClientCertificate = false;
            });/*
            services.AddSwaggerGen(c => {
                c.SwaggerDoc("v1", new Info
                {
                    Version = "v1",
                    Title = "Microformas-Elavon Services API",
                    Description = "Api para comunicar SGSMicroformas con SGSElavon",
                    TermsOfService = "None",
                    Contact = new Contact
                    {
                        Name = "J. Daniel Ojeda S.",
                        Email = "jdojeda@microformas.com.mx",
                        Url = "http://sgse.microformas.com.mx"
                    },
                });
                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlPath = Path.Combine(PlatformServices.Default.Application.ApplicationBasePath, xmlFile);
                c.IncludeXmlComments(xmlPath);
                c.OperationFilter<FileUploadOperation>();
            });*/
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            /*
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json","Upload Files Api");
            });*/
            app.UseCors("AllowAll");
            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
