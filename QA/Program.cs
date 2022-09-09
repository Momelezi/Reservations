using Business.Database;
using Business.Database.Contracts;
using Business.Database.Repository;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
var connectionString = builder.Configuration.GetConnectionString("SqlConnection");
builder.Services.AddDbContext<RepositoryContext>(x => x.UseSqlServer(connectionString), ServiceLifetime.Transient);


// repositories
builder.Services.AddScoped<IBookingRepository, BookingRepository>();
builder.Services.AddScoped<IBranchRepository, BranchRepository>();
builder.Services.AddScoped<IComponentsRepository, ComponentsRepository>();
builder.Services.AddScoped<IDesignationRepository, DesignationRepository>();
builder.Services.AddScoped<IDirectorateRepository, DirectorateRepository>();
builder.Services.AddScoped<IEquipmentBookingRepository, EquipmentBookingRepository>();
builder.Services.AddScoped<IEquipmentCategoryRepository, EquipmentCategoryRepository>();
builder.Services.AddScoped<IInterventionTypeBookingRepository, InterventionTypeBookingRepository>();
builder.Services.AddScoped<IInterventionTypeRepository, InterventionTypeRepository>();
builder.Services.AddScoped<IPersonRepository, PersonRepository>();
builder.Services.AddScoped<ITargetAudienceBookingRepository, TargetAudienceBookingRepository>();
builder.Services.AddScoped<ITargetAudienceRepository, TargetAudienceRepository>();
builder.Services.AddScoped<IVenueBookingRepository, VenueBookingRepository>();
builder.Services.AddScoped<IVenueCategoryRepository, VenueCategoryRepository>();
builder.Services.AddScoped<IVenueRepository, VenueRepository>();
builder.Services.AddScoped<IVenueRoomRepository, VenueRoomRepository>();


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

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
