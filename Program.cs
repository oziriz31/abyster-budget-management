using budget_management;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllersWithViews();

builder.Host.AddAppSettingsSecretsJson()
               .UseAutofac()
               /*.UseSerilog()*/;
await builder.AddApplicationAsync<AppHostModule>(); 
var app = builder.Build();
await app.InitializeApplicationAsync();
await app.RunAsync();

/*
app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action=Index}/{id?}");
*/
//app.Run();
