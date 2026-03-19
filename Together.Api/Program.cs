using Together.Application.Services;
using Together.Application;
using Together.Infrastructure;

var builder = WebApplication.CreateBuilder(args);
{
    // Add services to the container.
    builder.Services.AddControllers();
    //注入物件(沒注入測試會有System.InvalidOperationException: Unable to resolve service for type)
    //builder.Services.AddScoped<IEventService, EventService>();
    //重構成以下寫法,落實clean arch
    builder.Services.AddApplication().AddService();
}

var app = builder.Build();
{
    app.UseHttpsRedirection();
    app.MapControllers();
    app.Run();
}