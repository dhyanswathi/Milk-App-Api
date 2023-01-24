namespace MilkApp.PopulateData.Models;

public interface IMilkRepository
{
    void SaveChanges();
    Milk Create (string Name, string Type, int Storage, string Id);
}