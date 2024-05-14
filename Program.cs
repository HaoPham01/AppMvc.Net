using App.Services;
using App.ExtendMethods;

var builder = WebApplication.CreateBuilder(args);

//Add RazorPages
builder.Services.AddRazorPages();
// Add services to the container.
builder.Services.AddControllersWithViews();
//Add Service
builder.Services.AddSingleton<ProductService, ProductService>();
builder.Services.AddSingleton<PlanetService, PlanetService>();

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
app.AddStatusCodePage(); // Tuy bien Response loi 400 - 599

app.UseRouting();

app.UseAuthentication(); //xac dinh danh tinh
app.UseAuthorization(); //xac thuc quyen truy cap

app.MapAreaControllerRoute(
    name: "product",
    pattern: "{controller=Home}/{action=Index}/{id?}",
    areaName:"ProductManage"
    
);

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"
    );
app.MapRazorPages();

app.Run();
