using ApplicationCore.Interfaces;
using ApplicationCore.Interfaces.Entity;
using ApplicationCore.Services;
using Infrastructure.Data;
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
builder.Services.AddControllers().AddNewtonsoftJson(options => options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());
builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
builder.Services.AddScoped(typeof(IBookLibraryService), typeof(BookLibraryService));
builder.Services.AddScoped(typeof(IAuthorService), typeof(AuthorService));
builder.Services.AddScoped(typeof(IBookService), typeof(BookService));
builder.Services.AddScoped(typeof(ICountryService), typeof(CountryService));
builder.Services.AddScoped(typeof(IGenreService), typeof(GenreService));
builder.Services.AddScoped(typeof(ILanguageService), typeof(LanguageService));
builder.Services.AddScoped(typeof(IOrderService), typeof(OrderService));
builder.Services.AddScoped(typeof(IPublisherService), typeof(PublisherService));
builder.Services.AddScoped(typeof(IUserBasketService), typeof(UserBasketService));
builder.Services.AddScoped(typeof(IUserService), typeof(UserService));

builder.Services.AddDbContext<BookLibraryContext>();
builder.Services.AddScoped<BookLibraryContext>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseCors("AllowMyOrigin");

app.UseAuthorization();

app.MapControllers();

app.Run();
