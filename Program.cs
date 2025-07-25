
namespace AIDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
            builder.Services.AddOpenApi();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.MapOpenApi();
            }

            app.UseHttpsRedirection();

            
            app.UseStaticFiles(); 

            //Added this comment
            //Add Hi Below in comment
            //Hi

            app.UseAuthorization();
            //hi
            //nohi
            //hi from mangesh2
            //hi from mangesh
            app.MapControllers();
            //bye

            //Hi today from mangesh
            //Hifrom today


            app.Run();
        }
    }
}
