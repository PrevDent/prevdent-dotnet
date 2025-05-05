using Microsoft.OpenApi.Models;
using prevdent.application.Mappings;
using prevdent.ioc;

var builder = WebApplication.CreateBuilder(args);

Bootstrap.Start(builder.Services, builder.Configuration);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(
    c =>
    {
        c.EnableAnnotations();
        c.SwaggerDoc("v1", new OpenApiInfo
        {
            Title = "PrevDent API",
            Description = "API para controle de paciente.",
        });
    }
);

builder.Services.AddHttpClient("ViaCep", client =>
{
    client.BaseAddress = new Uri("https://viacep.com.br/ws/");
    client.DefaultRequestHeaders.Add("Accept", "application/json");
});

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
