using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;
using PerformanceReview;
using PerformanceReview.Services.CheckinRecordServices;
using PerformanceReview.Services.QuestionsServices;
using PerformanceReview.Services.RatingRecordServices;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddSingleton(sp => new HttpClient
{
	BaseAddress = new Uri("https://localhost:7282")
});

builder.Services.AddMudServices();
builder.Services.AddScoped<IQuestionsService, QuestionsService>();
builder.Services.AddScoped<ICheckinRecordService, CheckinRecordService>();
builder.Services.AddScoped<IRatingRecordService, RatingRecordService>();

await builder.Build().RunAsync();
