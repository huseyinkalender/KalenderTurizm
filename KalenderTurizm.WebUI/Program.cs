using KalenderTurizm.Business.Abstract;
using KalenderTurizm.Business.AutoMapper;
using KalenderTurizm.Business.Concrete;
using KalenderTurizm.DataAccess.Abstract;
using KalenderTurizm.DataAccess.Concrete;
using KalenderTurizm.DataAccess.Concrete.EntityFrameworkCore.Context;
using KalenderTurizm.Entities.Concrete;
using KalenderTurizm.WebUI.BasketTransaction.BasketModels;
using KalenderTurizm.WebUI.BasketTransaction;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();


builder.Services.AddDbContext<KalenderTurizmContext>();
builder.Services.AddIdentity<AppUser, AppRole>().AddEntityFrameworkStores<KalenderTurizmContext>();
builder.Services.AddAutoMapper(typeof(MapperProfile));


builder.Services.AddScoped<ICityDal, CityDal>();
builder.Services.AddScoped<ICityService, CityManager>();
builder.Services.AddScoped<ICategoryDal, CategoryDal>();
builder.Services.AddScoped<ICategoryService, CategoryManager>();
builder.Services.AddScoped<IAuthService, AuthManager>();
builder.Services.AddScoped<ITourService, TourManager>();
builder.Services.AddScoped<ITourDal, TourDal>();
builder.Services.AddScoped<IPlaceToVisitService, PlaceToVisitManager>();
builder.Services.AddScoped<IPlaceToVisitDal, PlaceToVisitDal>();
builder.Services.AddScoped<IHotelService, HotelManager>();
builder.Services.AddScoped<IHotelDal, HotelDal>();
builder.Services.AddScoped<IShipService, ShipManager>();
builder.Services.AddScoped<IShipDal, ShipDal>();
builder.Services.AddScoped<IFlightTicketService, FlightTicketManager>();
builder.Services.AddScoped<IFlightTicketDal, FlightTicketDal>();
builder.Services.AddTransient<IBasketTransaction,BasketTransaction>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=KalenderTurizm}/{action=Index}/{id?}");

app.Run();
