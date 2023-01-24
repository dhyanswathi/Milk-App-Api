namespace MilkApp.PopulateData.Models;

public interface IMilkRepository
{
    void Save();
    void Create (string Name, string Type, int Storage, string Id);
}