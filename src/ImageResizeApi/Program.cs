using Models;
using Services.Effect;
using Services.PlugIns;
using Services.ResizeService;

var builder = WebApplication.CreateBuilder(args);

builder.Configuration.AddJsonFile("appsettings.Development.json",
        optional: true,
        reloadOnChange: true);

// Add services to the container.
//Plugin
/// To switch to AdobePlugin
builder.Services.AddSingleton<IPlugin, AdobePlugin>();
/// To switch to LuminarPlugin
//builder.Services.AddSingleton<IPlugin, LuminarPlugin>();

//Services
builder.Services.AddSingleton<IEffectsServices, EffectsServices>();
builder.Services.AddSingleton<IResizeService, ResizeService>();

builder.Services.AddSingleton<IPlugin, AdobePlugin>();

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
