using Milk.Api.Controllers;
using Milk.Api.Models;

namespace Milk.Api.Tests.MockData
{
    public class MilkMockData
    {
        public static List<Models.Milk> GetmockMilk()
        {
            return new List<Models.Milk> { new Models.Milk
            {
                 Name = "Dillion's unequaled cashew milk",
                 Type = "Cashew milk",
                 Storage = 99,
                 Id = "301d5dcf-a2a8-4a34-b26b-efcaa103963c"
             },
            new Models.Milk
            {
                Name = "Joe's unequaled pea milk",
                 Type = "Pea milk",
                 Storage = 40,
                 Id = "301d5dcf-a2a8-4a34-b26h-efcaa103963c"
            },
            new Models.Milk
            {
                Name = "Macie's broad walnut milk",
                 Type = "Walnut milk",
                 Storage = 23,
                 Id = "72204ea0-29e2-4da8-bf57-648b37268b71"
            },
            new Models.Milk
            {
                Name = "Christa's fearful rice milk",
                 Type = "Rice milk",
                 Storage = 23,
                 Id = "72204ea0-29e2-4da8-bf57-648b37268b71"
            },
            new Models.Milk
            {
                Name = "Shakayla's loose coconut milk",
                 Type = "Coconut milk",
                 Storage = 82,
                 Id = "6905f2f6-e80c-4601-8ae6-5408485ef9c5"
            }
            };
        }
    }
}
