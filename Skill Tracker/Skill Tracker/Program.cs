using Microsoft.Extensions.Options;
using MongoDB.Driver;
using Skill_Tracker.Models;
using Skill_Tracker.Services;

var builder = WebApplication.CreateBuilder(args);
var policyName = "_myAllowSpecificOrigins";

// Add services to the container.
builder.Services.Configure<SkillTrackerDatabaseSetting>
    (builder.Configuration.GetSection(nameof(SkillTrackerDatabaseSetting)));

builder.Services.AddSingleton<ISkillTrackerDatabaseSetting>
    (sp => sp.GetRequiredService<IOptions<SkillTrackerDatabaseSetting>>().Value);

builder.Services.AddSingleton<IMongoClient>
    (s => new MongoClient(builder.Configuration.GetValue<string>("SkillTrackerDatabaseSetting:ConnectionString")));

builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: policyName,
                      builder =>
                      {
                          builder
                            .WithOrigins("http://localhost:3000") // specifying the allowed origin
                            .WithMethods("POST")
                            .WithMethods("PUT")
                            .WithMethods("GET")// defining the allowed HTTP method
                            .AllowAnyHeader(); // allowing any header to be sent
                      });
});


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
app.UseCors(policyName);

app.UseAuthorization();

 app.MapControllers();

app.Run();
