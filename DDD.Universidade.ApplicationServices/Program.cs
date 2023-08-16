using DDD.Infra.MemoryDb.Interfaces;
using DDD.Infra.MemoryDb.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//IOC - Dependency Injection
builder.Services.AddScoped<IAlunoRepository, AlunoRepository>();

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
