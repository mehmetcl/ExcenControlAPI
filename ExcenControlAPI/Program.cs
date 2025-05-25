using ExcenControlAPI.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddSingleton<ILedService, LedService>();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "ExcenControlAPI v1");
    c.RoutePrefix = string.Empty; // ← Bu, https://excencenter.online
});

//app.UseHttpsRedirection();

app.UseAuthorization();
app.MapControllers();

app.Run();
