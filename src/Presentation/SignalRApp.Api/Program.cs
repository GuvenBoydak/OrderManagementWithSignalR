using SignalRApp.Api.Extensions;
using SignalRApp.Api.Hubs;
using SignalRApp.Application.Extensions;
using SignalRApp.Persistence.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddApiDıService().AddApplicationService().AddPersistenceServices(builder.Configuration);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(SignalRConstant.PolicyName);

app.UseHttpsRedirection();

app.MapControllers();

app.MapHub<SignalRHub>(SignalRConstant.EndpoindName);

app.Run();
