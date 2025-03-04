using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using RoleBaseAuthAndCrud.data;
using RoleBaseAuthAndCrud.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<ApplicationDbContext>(
    options => options.UseSqlServer(builder.Configuration.GetConnectionString("dbcs"))
);

builder.Services.AddIdentity<User, IdentityRole>()
    .AddEntityFrameworkStores<ApplicationDbContext>()
    .AddDefaultTokenProviders();

var app = builder.Build();

// Seed roles and admin user
using(var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    await RoleInitializer.SeedRolesAndAdmin(services);
}

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

// Role Initializer class to seed roles and an admin user
public static class RoleInitializer
{
    public static async Task SeedRolesAndAdmin(IServiceProvider serviceProvider)
    {
        var roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
        var userManager = serviceProvider.GetRequiredService<UserManager<User>>();

        string[] roles = { "Admin", "User" };
        //if(roles != null && roles.Any())
        //{
            foreach (var role in roles)
            {
                if (!await roleManager.RoleExistsAsync(role))
                {
                    await roleManager.CreateAsync(new IdentityRole(role));
                }
            }
        //}


        string adminEmail = "Admin@gmail.com";
        string adminPassword = "Admin@1234";

        if(await userManager.FindByEmailAsync(adminEmail) == null)
        {
            var adminUser = new User
            {
                UserName = "admin",
                Email = adminEmail,
                Gender = "Male",
                Address = "admin address"
            };

            var result = await userManager.CreateAsync(adminUser, adminPassword);
            if (result.Succeeded)
            {
                await userManager.AddToRoleAsync(adminUser, "Admin");
            }
        }
    }
}