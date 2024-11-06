using SWD392_Assignment.Data.Models;
using SWD392_Assignment.Data.Repository.IRepository;
using SWD392_Assignment.Data.Repository;

namespace ESS_Store.WebApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddRazorPages();
            builder.Services.AddDbContext<SWD392_Group2_ESStoreContext>();
            builder.Services.AddScoped<IManageCustomerRepository, ManageCustomerRepository>();
            builder.Services.AddScoped<IManageRole, ManageRole>();
            builder.Services.AddScoped<IManageOrderRepository, ManageOrder>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapRazorPages();

            app.Run();
        }
    }
}