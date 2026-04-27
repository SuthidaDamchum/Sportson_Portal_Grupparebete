using Azure.Identity;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using SportsonView.API.Core.Interfaces;
using SportsonView.API.Core.Services;
using SportsonView.API.Data;
using SportsonView.API.Data.Entities;
using SportsonView.API.Data.Interfaces;
using SportsonView.API.Profiles;
using SportsonView.API.Repositories;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(options =>
{
    options.AddPolicy("LocalFrontend", policy =>
    {
        policy.SetIsOriginAllowed(origin => new Uri(origin).Host == "localhost")
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});



// JWT Configuration
var jwtKey = builder.Configuration["Jwt:Key"];
var jwtIssuer = builder.Configuration["Jwt:Issuer"];
var jwtAudience = builder.Configuration["Jwt:Audience"];

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = true,
            ValidateAudience = true,
            ValidateLifetime = true,
            ValidateIssuerSigningKey = true,
            ValidIssuer = jwtIssuer,
            ValidAudience = jwtAudience,
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtKey!))
        };
    });

if (!builder.Environment.IsDevelopment())
{
    var keyVaultUri = new Uri("https://sportson.vault.azure.net/");

    builder.Configuration.AddAzureKeyVault(
        keyVaultUri,
        new DefaultAzureCredential());
}

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddAutoMapper(cfg => cfg.AddProfile<NewsArticleProfile>());
builder.Services.AddAutoMapper(cfg => cfg.AddProfile<ImportantDateProfile>());

builder.Services.AddScoped<INewsArticleService, NewsArticleService>();
builder.Services.AddScoped<INewsArticleRepository, NewsArticleRepository>();
builder.Services.AddScoped<IImportantDateRepository, ImportantDateRepository>();
builder.Services.AddScoped<IImportantDatesService, ImportantDateService>();
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<FileService>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

/* Vi kan inte hasha lösenord i UserConfiguration.cs eftersom det körs varje gång vi migrerar, vilket skulle resultera i olika hashvärden varje gång.
Det orsakar problem för migration och seedning av användare, eftersom de hashade lösenorden inte skulle matcha de som används i autentiseringstester.
Därför har jag hashat lösenorden en gång och lagt in de hashade värdena direkt i UserConfiguration.cs. 
Detta gör att vi kan ha fasta hashvärden för våra seedade användare, hindrar att lösenorden ändras vid varje migration. */
using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();

    db.Database.Migrate();

    if (!db.Users.Any())
    {
        db.Users.Add(new User
        {
            Username = "alice",
            Email = "alice@example.com",
            Store = "Göteborg",
            Password = BCrypt.Net.BCrypt.HashPassword("starshipalice")
        });

        db.Users.Add(new User
        {
            Username = "hardcorebob",
            Email = "bob@example.com",
            Store = "Kiruna",
            Password = BCrypt.Net.BCrypt.HashPassword("bobthebuilder")
        });

        db.SaveChanges();
    }
}

app.UseHttpsRedirection();
app.UseCors("LocalFrontend");
app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();

app.Run();