using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing.Constraints;
using Microsoft.Extensions.DependencyInjection;

namespace Lesson06
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                  name: "areas",
                  template: "{area:exists}/{controller=AdminHome}/{action=Index}/{id?}"
                );
            });


            app.UseMvc(routes =>
            {
                routes.MapRoute(
                         name: "Default", // Route name
                         template: "{controller}/{action}/{id?}", // URL with parameters
                         defaults: new { controller = "Home", action = "Index", id= 1} // Defaults
                      );


                /*
                 
                            app.UseMvc(routes =>
                            {
                                routes.MapRoute(
                                name: "Default1", // Route name
                                template: "{controller=Home}/{action=Index}/{id:range(10,100)=12}" // Template 
                            );

                       // 1. Default ASP.NET MVC route
                       routes.MapRoute(
                           name: "Default", // Route name
                           template: "{controller}/{action}/{id?}", // URL with parameters
                           defaults: new { controller = "Home", action = "Index" } // Defaults
                       );

                       //Examples
                       //    root/
                       //    root/ControllerName/
                       //    root/ControllerName/ActionMethodName
                       //    root/ControllerName/ActionMethodName/parameterValue

                       //    root/
                       //    root/Home/
                       //    root/Home/Index
                       //    root/Home/Index/12

                       //    Invalid
                       //    root/ControllerName/ActionMethodName/parameterValue/parameterValue
                       //    root/parameterValue


                       //    root/Home/Index/12/33
                       //    root/12


                       // 2. Route with a required id as parameter
                       routes.MapRoute(
                           name: "Default", // Route name
                           template: "{controller}/{action}/{id}", // URL with parameters
                           defaults: new { controller = "Home", action = "Index"} // Defaults
                       );


                       // 3. Route with id as an optional segment and “100” as default value
                       routes.MapRoute(
                           name: "Default", // Route name
                           template: "{controller}/{action}/{id}", // URL with parameters
                           defaults: new { controller = "Home", action = "Index", id = 100} // Defaults
                       );

                       //4. Setup a Route that has an id as the third optional segment that accepts only integers as value. 
                       //Is there more than one way of doing it?

                       //routes.MapRoute(
                           name: "IntRouteConstraint", // Route name
                           template: "{controller}/{action}/{id?}", // URL with parameters
                           defaults: new { controller = "Home", action = "Index" }, // Defaults
                           constraints: new { id = new IntRouteConstraint() }
                       );

                       routes.MapRoute(
                           name: "RegExConstraint", // Route name
                           template: "{controller}/{action}/{id?}", // URL with parameters
                           defaults: new { controller = "Home", action = "Index"}, // Defaults
                           constraints: new { id =  @"\d+" }
                       );


                       //5. Setup a Route that has an id as the third optional segment that accepts only integers between 10 and 100
                       routes.MapRoute(
                           name: "Default", // Route name
                           template: "{controller}/{action}/{id?}/", // URL with parameters
                           defaults: new { controller = "Home", action = "Index"}, // Defaults
                           constraints : new { id = new RangeRouteConstraint(1, 100) } // Constraints
                       );



                       // 6. 
                       // Setup a Route that accepts any number of segments
                       routes.MapRoute(
                          name: "Default", // Route name
                          template: "{controller}/{action}/{id?}/{*catchall}", // URL with parameters
                          defaults: new { controller = "Home", action = "Index" } // Defaults
                       );



                       // 7. 
                       //host/shop/books/
                       //host/shop/books/programming/asp-net-mvc
                       //host/shop/movies/action
                       //host/shop/movies/drama/the-shining

                       routes.MapRoute(
                          name: "Shop", // Route name
                          template: "shop/{controller}/{category}/{title}", // URL with parameters
                          defaults: new { action = "Index", category = UrlParameter.Optional, title = UrlParameter.Optional } // Defaults
                       );




                        */
                //   routes.MapRoute(
                //       name: "default", // Route name
                //       template: "{controller}/{action}/{id?}", // with parameter
                //       defaults: new { controller = "Home", action = "Index" } // Defaults
                //   );

                //   routes.MapRoute(
                //    name: "Books", // Route name
                //    template: "{controller}/{action}/{category}/{title}", // URL with parameters
                //    defaults: new { controller = "Home", action = "Index" } // Defaults
                //);


            });

        }
    }
}
