using InBazarAPI.Extention;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

//----------------------------------------------------

builder.Services.AddDbConTextes(builder.Configuration);
builder.Services.AddRepository();

//---------------------------------------------------

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
