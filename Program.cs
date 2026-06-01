using BookstoreApp.Application.Interfaces;
using BookstoreApp.Application.UseCases;
using BookstoreApp.Infrastructure.Persistence;
using BookstoreApp.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlite(builder.Configuration.GetConnectionString("BooksDb")));

builder.Services.AddScoped<IBookRepository, BookRepository>();
builder.Services.AddScoped<GetBookIdQuery>();

builder.Services.AddControllers();

var app =  builder.Build();
app.MapControllers();
app.Run();