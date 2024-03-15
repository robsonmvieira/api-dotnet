using Stock.Supplier.Application.Configurations;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCustomConnections(builder.Configuration)
    .AddUseCases()
    .AddControllersConfiguration();

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
app.MapControllers();


app.Run();

