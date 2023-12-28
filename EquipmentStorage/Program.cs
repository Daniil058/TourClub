using EquipmentStorage.Data;
using EquipmentStorage.Data.Services;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<EquipmentStorageContext>();
builder.Services.AddDatabaseDeveloperPageExceptionFilter();
builder.Services.AddTransient<BookingService>();
builder.Services.AddTransient<CategoryEquipmentService>();
builder.Services.AddTransient<ConditionService>();
builder.Services.AddTransient<EquipmentService>();
builder.Services.AddTransient<InterestService>();
builder.Services.AddTransient<RoleService>();
builder.Services.AddTransient<StatusBookingService>();
builder.Services.AddTransient<UserDescriptionService>();
builder.Services.AddTransient<UserAuthService>();


builder.Services.AddControllers().AddNewtonsoftJson(options =>
    options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);

var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


app.UseCors(policy => policy
    .AllowAnyOrigin()
    .AllowAnyMethod()
    .AllowAnyHeader()
    );

app.UseAuthorization();
app.MapControllers();
app.Run();
