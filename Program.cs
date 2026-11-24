using Microsoft.EntityFrameworkCore;
using big_isaac_project.Data;
using Microsoft.AspNetCore.Identity;
using big_isaac_project.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<CharacterContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Identity: the users, and the cookie that remembers who is signed in.
builder.Services.AddIdentity<AppUser, IdentityRole>(options =>
{
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequiredLength = 10;
})
    .AddEntityFrameworkStores<CharacterContext>();
var app = builder.Build();

// Week 12: the Admin role, and who holds it. Runs once, at startup.
using (var scope = app.Services.CreateScope())
{
    await RoleSeeder.SeedAsync(scope.ServiceProvider);
}

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseWhen(context => !context.Request.Path.StartsWithSegments("/api"), pages =>
    pages.UseStatusCodePagesWithReExecute("/Home/Missing"));
    
app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();

// Week 13: a minimal API endpoint. The same kind of answer as a controller
// action, in one statement, with no class around it.
app.MapGet("/api/characters/count", async (CharacterContext db) =>
    new { count = await db.Characters.CountAsync() });

app.Run();
