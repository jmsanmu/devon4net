using Devon4Net.Application.WebAPI.Configuration.Application;
using Devon4Net.Infrastructure.Logger;
using Devon4Net.Infrastructure.Middleware.Middleware;
using Devon4Net.Infrastructure.Swagger;

var builder = WebApplication.CreateBuilder(args);

builder.WebHost.InitializeDevonFw();

#region services
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.SetupDevonfw(builder.Configuration);
builder.Services.SetupMiddleware(builder.Configuration);
builder.Services.SetupLog(builder.Configuration);
builder.Services.SetupSwagger(builder.Configuration);
builder.Services.AddGrpc();
#endregion

var app = builder.Build();

#region devon app
app.SetupDevonfw(builder.Services);
#endregion

app.UseHttpsRedirection();
app.MapControllers();

app.Run();