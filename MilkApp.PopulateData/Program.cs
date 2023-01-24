using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MilkApp.PopulateData.Data;
using MilkApp.PopulateData.Models;

IHost host = Host.CreateDefaultBuilder(args)
.ConfigureServices((context, services) =>
{
    var cns = "Data Source=LAPTOP-AC42D6SP\\MSSQLSERVER01;Initial Catalog=MilkDB;Integrated Security=True;encrypt=false";
    services.AddDbContext<MilkDBContext>(options => options.UseSqlServer(cns));
    services.AddTransient<MilkRepository>();
})
.Build();

var path = "C:\\Users\\Mintu\\swathistudy\\pgp\\codeTest\\Milk-App-Api\\MilkApp.PopulateData\\Data\\Milk.json";

var items = JsonReader.GetMilkData(path);
var milkRepository = host.Services.GetRequiredService<MilkRepository>();
items.ForEach(x => milkRepository.Create(x.Name, x.Type,x.Storage, x.Id));

host.Run();