using BankAccountService.Infrastructure;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.AddServiceDefaults();

// Add services to the container.

var connectionString = builder.Configuration.GetConnectionString("TestDb") ?? throw new InvalidOperationException("Connection string 'TestDb' not found.");

ConfigurationManager configuration = builder.Configuration;

builder.Services.AddDbContext<BankAccountServiceDbContext>(x => x.UseSqlServer(connectionString, builder =>
{
    builder.EnableRetryOnFailure(1, TimeSpan.FromSeconds(5), null);
}));

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.MapDefaultEndpoints();

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
