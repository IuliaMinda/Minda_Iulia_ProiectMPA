using Microsoft.EntityFrameworkCore;
using Minda_Iulia_ProiectMPA.Models;

namespace Minda_Iulia_ProiectMPA.Data
{
    public class DbInitializer
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RentalContext(serviceProvider.GetRequiredService<DbContextOptions<RentalContext>>()))
            {
                if (context.Cars.Any())
                {
                    return;
                }

                context.Cars.AddRange(new Car { RegistrationPlate = "CS31MND", Make = "Dacia", Model = "Logan" }, new Car { RegistrationPlate = "CS31VAL", Make = "Opel", Model = "Insignia"});
                context.Cards.AddRange(new Card { Level = "Bronze" }, new Card { Level = "Silver" }, new Card { Level = "Gold" }, new Card { Level = "Platinum" });
                context.SaveChanges();
            }
        }
    }
}
