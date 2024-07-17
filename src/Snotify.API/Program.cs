using Snotify.API.Grpc;

var builder = WebApplication.CreateBuilder(args);

//builder.AddBasicServiceDefaults();
//builder.AddApplicationServices();

builder.Services.AddGrpc();

var app = builder.Build();

//app.MapDefaultEndpoints();

app.MapGrpcService<NotificationScheduleService>();

app.Run();
