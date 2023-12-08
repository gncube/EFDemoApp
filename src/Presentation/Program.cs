using Application;
using Infrastructure;

var builder = WebApplication.CreateBuilder(args);
{
    builder.Services
        .AddApplication()
        .AddInfrastructure(builder.Configuration);
}



var app = builder.Build();
{
    app.UseHttpsRedirection();
    app.Run();
}



