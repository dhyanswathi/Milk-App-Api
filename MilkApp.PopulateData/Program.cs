using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MilkApp.PopulateData.Models;

IHost host = Host.CreateDefaultBuilder(args)
.ConfigureServices((context, services) =>
{
    var cns = "Data Source=LAPTOP-AC42D6SP\\MSSQLSERVER01;Initial Catalog=MilkDB;Integrated Security=True;encrypt=false";
    services.AddDbContext<MilkDBContext>(options => options.UseSqlServer(cns));
    services.AddTransient<MilkRepository>();
})
.Build();

var milkRepository = host.Services.GetRequiredService<MilkRepository>();
milkRepository.Create("Arla", "Cow", 40, "dfsdfdsfssdsdfd");

host.Run();