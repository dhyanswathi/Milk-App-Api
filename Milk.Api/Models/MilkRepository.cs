namespace Milk.Api.Models
{
    public class MilkRepository : IMilkRepository
    {
        private readonly MilkDBContext _context;

        public MilkRepository(MilkDBContext context) => _context = context;

        public Milk Add (string name, string type, int? storage)
        {
            var milk = new Models.Milk
            {
                Name = name,
                Type = type,
                Storage = storage,
                Id = Guid.NewGuid().ToString(),
            };
            _context.Milk.Add(milk);
            Save();
            return milk;
        }

        public Milk? GetOneById(string id) => _context.Milk.FirstOrDefault(x => x.Id == id);

        public IEnumerable<Milk> GetAll() => _context.Milk.ToList();

        public void Delete(string id)
        {
            var milk = GetOneById(id);
            if (milk != null)
                return;
            _context.Milk.Remove(milk);
            Save();
        }
        public void Save()
        {
            _context.SaveChanges();
        }

        public Milk Update(string id, string name, string type, int? storage)
        {
            var milk = GetOneById(id);

            milk.Name = name;
            milk.Type = type;
            milk.Storage = storage;
            

            var updatedMilk = _context.Milk.Update(milk);
            Save();
            return updatedMilk.Entity;
        }
    }
}
