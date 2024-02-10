var builder = WebApplication.CreateBuilder(args);// sets up need info to run program

// Add services to the container.
builder.Services.AddControllersWithViews(); //tells the program to use mvc & coding by convention

var app = builder.Build();

//Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
   app.UseExceptionHandler("/Home/Error");
   //The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
   app.UseHsts();
}

app.UseHttpsRedirection(); //take user to https if they accidentally type http
app.UseStaticFiles(); // so we can use css and js

app.UseRouting();// controller/action/id //allows us to point user where we want based off request (in alternative to direct paths)

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");// if user does not type anything in then default to the home controller and user action

app.Run();
