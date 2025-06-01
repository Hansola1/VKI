using MorphpediaAPI.DataAccess;
using SQLitePCL;

Batteries_V2.Init();
var builder = WebApplication.CreateBuilder(args);

// �������
builder.Services.AddControllers();
builder.Services.AddDbContext<ApplicationContext>();

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", policy =>
    {
        policy.AllowAnyOrigin()
              .AllowAnyMethod()
              .AllowAnyHeader();
    });
});

//��������� Swagger, ����� �������� ������������ � ����� API :)
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseCors("AllowAll");
app.UseStaticFiles(); // �� ��������� ����� �� wwwroot

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();
app.MapControllers();

using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<ApplicationContext>();
    db.Database.EnsureCreated();
}

app.Run(); //https://localhost:7049/swagger/index.html
