using System.ComponentModel.DataAnnotations;

namespace MilkApp.PopulateData.Models;

public class Milk
{
    public string? Name {get; set;}
    public string? Type {get; set;}
    public int Storage {get; set;}
    [Key]
    public string? Id {get; set;}

}