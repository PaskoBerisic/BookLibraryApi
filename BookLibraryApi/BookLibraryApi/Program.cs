using ApplicationCore.Interfaces;
using ApplicationCore.Interfaces.Entity;
using ApplicationCore.Services;
using BookLibraryApi.TokenCheckMiddleware;
using Infrastructure.Data;
using Infrastructure.Options;
using Infrastructure.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddCors(options => {
    options.AddPolicy("AllowMyOrigin",
    builder => builder
    .WithOrigins("*")
    .AllowAnyHeader()
    .AllowAnyMethod()
    .Build());
});

ConfigurationManager Configuration = builder.Configuration;

builder.Services.AddControllers().AddNewtonsoftJson(options => options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());
builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
//builder.Services.AddScoped(typeof(IBookLibraryService), typeof(BookLibraryService));

builder.Services.AddScoped<IAuthorService, AuthorService>();
builder.Services.AddScoped<IBookService, BookService>();
builder.Services.AddScoped<ICountryService, CountryService>();
builder.Services.AddScoped<IGenreService, GenreService>();
builder.Services.AddScoped<ILanguageService, LanguageService>();
builder.Services.AddScoped<IOrderService, OrderService>();
builder.Services.AddScoped<IPublisherService, PublisherService>();
builder.Services.AddScoped<IUserBasketService, UserBasketService>();
builder.Services.AddScoped<IUserService, UserService>();

builder.Services.AddDbContext<BookLibraryContext>();
builder.Services.AddScoped<BookLibraryContext>();

// JWT
builder.Services.AddScoped<IUserServiceJWT, UserServiceJWT>();
builder.Services.Configure<AuthSettingsJWT>(Configuration.GetSection("AuthSettings"));
builder.Services.AddScoped<ITokenServiceJWT, TokenServiceJWT>();
builder.Services.AddScoped<TokenCheckMiddleware>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseMiddleware<TokenCheckMiddleware>();

app.UseHttpsRedirection();
app.UseCors("AllowMyOrigin");

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
