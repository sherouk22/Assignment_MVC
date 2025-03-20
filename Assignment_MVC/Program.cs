namespace Assignment_MVC
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();

            // app.MapGet("/Home", () => "Hello World!");

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/Home", async context =>
                {
                    await context.Response.WriteAsync("You Are At Home Page.");
                });

                endpoints.MapPost("/Product", async context =>
                {
                    await context.Response.WriteAsync("You Are At Product Page.");
                });
            });

            app.Run();
        }
    }
}
