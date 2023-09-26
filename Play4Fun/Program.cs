var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

string corsPolicy = "mini-game-cors";
builder.Services.AddCors(p => p.AddPolicy(corsPolicy, builder =>
   {
       builder.WithOrigins("*").AllowAnyMethod().AllowAnyHeader();
   }));
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseExceptionHandler("/error");

app.UseCors(corsPolicy);
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
