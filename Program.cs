var builder = WebApplication.CreateBuilder(args);
// Add our service
builder.Services.AddControllersWithViews();
var app = builder.Build();

// Our builder code - features we will use in tha app:
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

app.MapControllerRoute(    
    name: "default",    
    pattern: "{controller=Home}/{action=Index}/{id?}");


// app.MapGet("/", () => "Hello World!");


//app.Run() should always be the last line
app.Run();