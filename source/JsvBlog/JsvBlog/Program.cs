using JsvBlog.Business.Interfaces;
using JsvBlog.Data.File;
using JsvBlog.Extensions;
using System.Net.Http.Headers;
using Westwind.AspNetCore.Markdown;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddMarkdown();
builder.Services.AddMvc().AddApplicationPart(typeof(MarkdownPageProcessorMiddleware).Assembly);
builder.Services.AddControllersWithViews();
builder.Services.AddAutoMapperSetup();

builder.Services.AddDataBase(builder.Configuration);
JsvBlog.IoC.IoCConfiguration.Configure(builder.Services);

builder.Services.AddHttpClient<IPostRepository, PostFileRepository>(client =>
{
    client.DefaultRequestHeaders.Accept.Clear();
    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseMarkdown();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
