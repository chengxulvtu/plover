using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;

namespace Plover
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
            // .NET Core 1.0认证已过时，详情：https://github.com/aspnet/Security/issues/1310
            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = CookieAuthenticationDefaults.AuthenticationScheme;
            })
                    .AddCookieAuthentication(options =>
                    {
                        options.LoginPath = new Microsoft.AspNetCore.Http.PathString("/login");
                    });

            services.AddMvc();
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
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();

            app.UseAuthentication();


            app.UseMvc(routes =>
            {
                routes.MapAreaRoute(
                    name: Constant.ROUTE_NAME_MANAGE,
                    areaName: Constant.AREA_NAME_MANAGE,
                    template: $"{Constant.ROUTE_NAME_MANAGE}/{{controller}}/{{action=Index}}"
                );

                routes.MapAreaRoute(
                    name: Constant.ROUTE_NAME_MEMBER,
                    areaName: Constant.AREA_NAME_MEMBER,
                    //注意下面使用了c#的字符串差值，所有后面占位符部分是2个花括号
                    template: $"{Constant.ROUTE_NAME_MEMBER}/{{controller = Home}}/{{action = Index}}"
                );


                routes.MapRoute(
                name: "default",
                template: "{controller=Home}/{action=Index}/{id?}");


            });

            app.UseMvc();
        }
    }
}