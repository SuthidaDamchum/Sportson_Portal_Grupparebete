using Microsoft.EntityFrameworkCore;
using SportsonView.API.Core.Interfaces;
using SportsonView.API.Core.Services;
using SportsonView.API.Data;
using SportsonView.API.Data.Interfaces;
using SportsonView.API.Profiles;
using SportsonView.API.Repositories;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddCors();
builder.Services.AddSwaggerGen();

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddAutoMapper(cfg => cfg.AddProfile<NewsArticleProfile>());
builder.Services.AddAutoMapper(cfg => cfg.AddProfile<ImportantDateProfile>());

builder.Services.AddScoped<INewsArticleService, NewsArticleService>();
builder.Services.AddScoped<INewsArticleRepository, NewsArticleRepository>();
builder.Services.AddScoped<IImportantDateRepository, ImportantDateRepository>();
builder.Services.AddScoped<IImportantDatesService, ImportantDateService>();
builder.Services.AddScoped<FileService>();

var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseRouting();
app.UseCors(options =>
    options.AllowAnyOrigin()
    .AllowAnyMethod()
    .AllowAnyHeader()
);

app.UseAuthentication();
app.UseAuthorization();
app.UseHttpsRedirection();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});

app.MapControllers();
app.Run();

