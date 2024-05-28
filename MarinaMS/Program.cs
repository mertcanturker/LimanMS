
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Authorization;
using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddDbContext<Context>();
builder.Services.AddIdentity<AppUser, AppRole>().AddEntityFrameworkStores<Context>(); // Sonradan eklendi
builder.Services.AddControllersWithViews();
//builder.Services.AddMvc(config =>
//{
//    var policy = new AuthorizationPolicyBuilder()
//    .RequireAuthenticatedUser()
//    .Build();
//    config.Filters.Add(new AuthorizeFilter(policy));
//}); // SONRADAN
//builder.Services.ConfigureApplicationCookie(options =>
//{
//    options.LoginPath = "/Login/Index";
//});
builder.Services.AddScoped<IJurnalService, JurnalManager>();
builder.Services.AddScoped<IJurnalDal, EfJurnalDal>();
builder.Services.AddScoped<ITekneService, TekneManager>();
builder.Services.AddScoped<ITekneDal, EfTekneDal>();

//route


// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}



app.UseHttpsRedirection();
app.UseStaticFiles();

 //app.UseAuthentication(); 

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapControllerRoute(
    name: "/kayit",
    pattern: "{controller=Kayit}/{action=Index}/{id?}");
app.MapControllerRoute(
    name: "/takip",
    pattern: "{controller=Takip}/{action=Index}/{id?}");
app.MapControllerRoute(
    name: "/jurnal",
    pattern: "{controller=Jurnal}/{action=Index}/{id?}");

app.Run();
