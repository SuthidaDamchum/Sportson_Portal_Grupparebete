using System.Text.Json.Serialization;
using Swashbuckle.AspNetCore.SwaggerUI;
using SportsonView.API.Core.Interfaces;
using SportsonView.API.Core.Services;
using SportsonView.API.Data.Interfaces;
using SportsonView.API.Repos;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers()

.AddJsonOptions(options =>
 {

     options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
 });

builder.Services.AddCors();

builder.Services.AddSwaggerGen();

builder.Services.AddScoped<INewsArticleService, NewsArticleService>();
builder.Services.AddScoped<INewsArticleRepo, NewsArticleRepo>();


var app = builder.Build();

app.UseRouting();


app.UseCors(options =>
    options.AllowAnyOrigin()
    .AllowAnyMethod()
    .AllowAnyHeader()
);


app.UseAuthentication();
app.UseAuthorization();



app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});


app.UseSwagger();


app.UseSwaggerUI();



app.Run();
