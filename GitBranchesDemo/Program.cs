var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())//add middlewares
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();//Miriam is the winner


app.UseAuthorization();

app.MapControllers();

app.Run();
//return 404