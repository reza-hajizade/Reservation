using Microsoft.EntityFrameworkCore;
using Reservation.Infrastructure;


var builder = WebApplication.CreateBuilder(args);


builder.Services.AddDbContext<ReservationDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("SvcDbContext"))
);

var app = builder.Build();





app.Run();
