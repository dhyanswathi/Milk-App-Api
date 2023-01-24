using System;

namespace MilkApp.PopulateData.Models;

public class MilkRepository: IMilkRepository
{
    private readonly MilkDBContext _context;

    public MilkRepository (MilkDBContext context)
    {
        _context = context;
    }

    public void Create(string Name, string Type, int Storage, string Id)
    {
        _context.Add(
            new Milk
            {
                Name = Name,
                Type = Type,
                Storage = Storage,
                Id = Id
            });
        Save();
    }

    public void Save()
    {
        _context.SaveChanges();
    }
}