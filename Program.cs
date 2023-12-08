using HrDatabaseBackend.Model.ApplicantsModel;
using HrDatabaseBackend.Model.AttendanceModel;
using HrDatabaseBackend.Model.EmployeeModel;
using HrDatabaseBackend.Model.JobPostingModel;
using HrDatabaseBackend.Model.PerformanceModel;
using HrDatabaseBackend.Model.UserModel;
using HrDatabaseBackend.Services.ApplicantsModel;
using HrDatabaseBackend.Services.ApplicantsService;
using HrDatabaseBackend.Services.AttendanceService;
using HrDatabaseBackend.Services.EmployeeService;
using HrDatabaseBackend.Services.JobPostingService;
using HrDatabaseBackend.Services.PerformanceService;
using HrDatabaseBackend.Services.UserService;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.Configure<UserDatabaseSetting>(
    builder.Configuration.GetSection(nameof(UserDatabaseSetting)));

builder.Services.AddSingleton<IUserDatabaseSetting>(sp =>
sp.GetRequiredService<IOptions<UserDatabaseSetting>>().Value);

builder.Services.AddSingleton<IMongoClient>(s =>
new MongoClient(builder.Configuration.GetValue<string>("UserDatabaseSetting:ConnectionString")));

builder.Services.AddScoped<IUserService, UserService>();



//Employee Table
builder.Services.Configure<EmployeeDatabaseSetting>(
    builder.Configuration.GetSection(nameof(EmployeeDatabaseSetting)));

builder.Services.AddSingleton<IEmployeeDatabaseSetting>(sp =>
sp.GetRequiredService<IOptions<EmployeeDatabaseSetting>>().Value);

builder.Services.AddSingleton<IMongoClient>(s =>
new MongoClient(builder.Configuration.GetValue<string>("EmployeeDatabaseSetting:ConnectionString")));

builder.Services.AddScoped<IEmployeeService, EmployeeService>();

//jobpostingtable

builder.Services.Configure<JobPostingDatabaseSetting>(
    builder.Configuration.GetSection(nameof(JobPostingDatabaseSetting)));

builder.Services.AddSingleton<IJobPostingDatabaseSetting>(sp =>
sp.GetRequiredService<IOptions<JobPostingDatabaseSetting>>().Value);

builder.Services.AddSingleton<IMongoClient>(s =>
new MongoClient(builder.Configuration.GetValue<string>("JobPostingDatabaseSetting:ConnectionString")));

builder.Services.AddScoped<IJobPostingService, JobPostingService>();

//Applicants Table
builder.Services.Configure<ApplicantsDatabaseSetting>(
    builder.Configuration.GetSection(nameof(ApplicantsDatabaseSetting)));

builder.Services.AddSingleton<IApplicantsDatabaseSetting>(sp =>
sp.GetRequiredService<IOptions<ApplicantsDatabaseSetting>>().Value);

builder.Services.AddSingleton<IMongoClient>(s =>
new MongoClient(builder.Configuration.GetValue<string>("ApplicantsDatabaseSetting:ConnectionString")));

builder.Services.AddScoped<IApplicantsService, ApplicantsService>();



//attendance table
builder.Services.Configure<AttendanceDatabaseSetting>(
    builder.Configuration.GetSection(nameof(AttendanceDatabaseSetting)));

builder.Services.AddSingleton<IAttendanceDatabaseSetting>(sp =>
sp.GetRequiredService<IOptions<AttendanceDatabaseSetting>>().Value);

builder.Services.AddSingleton<IMongoClient>(s =>
new MongoClient(builder.Configuration.GetValue<string>("AttendanceDatabaseSetting:ConnectionString")));

builder.Services.AddScoped<IAttendanceService, AttendanceService>();

//performace table


builder.Services.Configure<PerformanceDatabaseSetting>(
    builder.Configuration.GetSection(nameof(PerformanceDatabaseSetting)));

builder.Services.AddSingleton<IPerformanceDatabaseSetting>(sp =>
sp.GetRequiredService<IOptions<PerformanceDatabaseSetting>>().Value);

builder.Services.AddSingleton<IMongoClient>(s =>
new MongoClient(builder.Configuration.GetValue<string>("PerformanceDatabaseSetting:ConnectionString")));

builder.Services.AddScoped<IPerformanceService, PerformanceService>();





builder.Services.AddCors(options =>

{

    options.AddPolicy("corsPolicy",

                      policy =>

                      {

                          policy.WithOrigins("http://localhost:4200").AllowAnyMethod().AllowAnyHeader().AllowAnyOrigin();

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
    app.UseCors("corsPolicy");
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
