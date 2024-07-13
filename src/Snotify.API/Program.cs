using Microsoft.AspNetCore.Mvc;
using Snotify.Application.Services.Notifiers;
using Snotify.Application.Services.Notifiers.EmailNotifiers;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Logging.AddConsole();

builder.Services.AddKeyedSingleton<INotifier, EmailNotifierV1>("email:v1");
builder.Services.AddKeyedSingleton<INotifier, EmailNotifierV2>("email:v2");

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapGet("/v1/email", ([FromServices] IServiceProvider provider) =>
{
	var version = 1;
	Snotify.Domain.ValueObjects.Channel channel = Snotify.Domain.ValueObjects.Channel.EMAIL;

	var test = provider.GetRequiredKeyedService<INotifier>($"{channel.Name.ToLower()}:v{version}");

	return Results.Ok();
})
.WithName("GetEmailV1")
.WithOpenApi();

app.MapGet("/v2/email", ([FromServices] IServiceProvider provider) =>
{
	var version = 2;
	Snotify.Domain.ValueObjects.Channel channel = Snotify.Domain.ValueObjects.Channel.EMAIL;

	var test = provider.GetRequiredKeyedService<INotifier>($"{channel.Name.ToLower()}:v{version}");

	return Results.Ok();
})
.WithName("GetEmailV2")
.WithOpenApi();

app.Run();
