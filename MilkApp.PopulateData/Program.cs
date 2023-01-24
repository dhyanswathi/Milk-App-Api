using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MilkApp.PopulateData.Models;

IHost host = Host.CreateDefaultBuilder(args)
.ConfigureServices((context, services) =>
{
    var cns = "Data Source=LAPTOP-AC42D6SP\\MSSQLSERVER01;Initial Catalog=MilkDB;Integrated Security=True";
    services.AddDbContext<MilkDBContext>(options => options.UseSqlServer(cns))
    ;
})
.Build();

host.Run();