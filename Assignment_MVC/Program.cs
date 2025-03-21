using Microsoft.AspNetCore.Http;

namespace Assignment_MVC
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllersWithViews();
            var app = builder.Build();

            // app.MapGet("/Home", () => "Hello World!");

            app.UseRouting();

            #region MyRegion

            ////app.Use(async (context, next) =>
            ////{
            ////    Endpoint endpoint = context.GetEndpoint();

            ////    if (endpoint is not null)
            ////        await context.Response.WriteAsync("Your Requested Page Not Found.");


            ////    await next();

            ////});

            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapGet("/Home", async context =>
            //    {
            //        await context.Response.WriteAsync("You Are At Home Page.");
            //    });

            //    endpoints.MapGet("/Product", async context =>
            //    {
            //        await context.Response.WriteAsync("You Are At Product Page.");
            //    });

            //    endpoints.MapGet("/Product/{id:int?}", async context =>
            //    {
            //        var idData = context.Request.RouteValues["id"];

            //        if (idData is not null)
            //        {
            //            int id = Convert.ToInt32(context.Request.RouteValues["id"]);
            //            await context.Response.WriteAsync($"Your Requested Product with id => {id} ");
            //        }


            //    });

            //    endpoints.MapGet("/Books/{id}/{auther:alpha:minlength(3):maxlength(10)}", async context =>
            //    {
            //        int id = Convert.ToInt32(context.Request.RouteValues["id"]);
            //        string auther = context.Request.RouteValues["auther"].ToString();
            //        await context.Response.WriteAsync($"Your Requested Product with id => {id} Author => {auther} ");
            //    });
            //});

            ////app.Run(async (HttpContext) =>
            ////{
            ////    await HttpContext.Response.WriteAsync("Your Requested Page Not Found.");

            ////}); 
            #endregion

            app.MapControllerRoute(

                name:"default",
                pattern:"/{Controller=Home}/{Action=Index}",
                defaults: new { Controller = "Home" , Action ="Index"}

            );

            app.Run();
        }
    }
}
