
namespace Milk.Api.Models
{
    public interface IMilkRepository
    {
        void Save();
        Milk? GetOneById(string id);
        IEnumerable<Milk> GetAll();
        Milk Add(string name, string type, int? storage);
        void Delete(string id);
        Milk Update(string id, string name, string type, int? storage);

    }
}
