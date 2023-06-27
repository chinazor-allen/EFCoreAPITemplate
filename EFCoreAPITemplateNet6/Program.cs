using System.Data;
using Azure.Identity;
using Microsoft.Identity.Web;
using Microsoft.EntityFrameworkCore;

using EFCoreAPITemplateNet6.Data;
using Microsoft.AspNetCore.Authentication.JwtBearer;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// Connect to KeyVault using keyVaultName
var keyVaultUrl = new Uri(builder.Configuration.GetSection("KeyVaultUrl").Value!);
var azureCredential = new DefaultAzureCredential();

builder.Configuration.AddAzureKeyVault(keyVaultUrl, azureCredential);

/*
 * Protecting API
 * See https://learn.microsoft.com/en-us/azure/active-directory/develop/scenario-protected-web-api-app-configuration?tabs=aspnetcore
 */
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddMicrosoftIdentityWebApi(builder.Configuration.GetSection("AzureAd"));


// Database Connection
var databaseConnectionString = builder.Configuration.GetSection("Should be name of dbConnection in KeyVault").Value;

builder.Services.AddDbContext<DatabaseContext>(options => options.UseSqlServer(databaseConnectionString));

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();