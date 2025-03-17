using EC.Discount.Context;
using EC.Discount.Services.Abstract;
using EC.Discount.Services.Concrete;
using Microsoft.AspNetCore.Authentication.JwtBearer;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(opt =>
{
    opt.Authority = builder.Configuration["IdentityServerUrl"]; //OpenID'yi çağıracak yer. JWT Bearer'ı kiminle birlikte kullanacağımızı belirtir.
    opt.Audience = "ResourceDiscount"; //Config tarafında dinleyici olan keyi belirtir ve bu keyde kullanılan scopelar alınır.
    opt.RequireHttpsMetadata = false; //https gerekmesin.
});

// Add services to the container.
builder.Services.AddTransient<DapperContext>();
builder.Services.AddTransient<IDiscountService, DiscountService>();

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
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
