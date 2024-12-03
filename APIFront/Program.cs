using APIFront.Contracts.Database;
using APIFront.Models.Shared;
using APIFront.Services.Database;
using Microsoft.AspNetCore.Mvc.Controllers;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddTransient<IMongoDbService, MongoDbService>();
builder.Services.AddTransient<IAffiliateCampaignService, AffiliateCampaignService>();
builder.Services.AddTransient<IAffiliateService, AffiliateService>();
builder.Services.AddTransient<IBrandService, BrandService>();
builder.Services.AddTransient<ICountryService, CountryService>();
builder.Services.AddTransient<ICompanyService, CompanyService>();
builder.Services.AddTransient<IAutologinUrlService, AutologinUrlService>();


builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen(opt =>
{
    opt.TagActionsBy(api =>
    {
        if (api.GroupName != null)
        {
            return new[] { api.GroupName };
        }
        if (api.ActionDescriptor is ControllerActionDescriptor controllerActionDescriptor)
        {
            return new[] { controllerActionDescriptor.ControllerName };
        }
        throw new InvalidOperationException("Unable to determine tag for endpoint.");
    });
    opt.DocInclusionPredicate((name, api) => true);
});

builder.Services.Configure<MongoDbSettings>(
    builder.Configuration.GetSection("MongoDbSettings"));

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAnyOriginPolicy", policy =>
    {
        policy.AllowAnyOrigin() 
              .AllowAnyHeader() 
              .AllowAnyMethod(); 
    });
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
