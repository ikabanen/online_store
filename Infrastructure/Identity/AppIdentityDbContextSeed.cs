using System.Linq;
using System.Threading.Tasks;
using Core.Entities.Identity;
using Microsoft.AspNetCore.Identity;

namespace Infrastructure.Identity
{
    public class AppIdentityDbContextSeed
    {
        public static async Task SeedUsersAsync(UserManager<AppUser> userManager) 
        {
            if (!userManager.Users.Any()) 
            {
                var user = new AppUser 
                {
                    DisplayName = "managerIK",
                    Email = "flysensee@gmail.com",
                    UserName = "flysensee@gmail.com",
                    Address = new Address 
                    {
                        FirstName = "Admin",
                        LastName = "Testing",
                        Street = "3 Test City",
                        City = "New York",
                        State = "NY",
                        Zipcode = "10003"
                    }
                };

                await userManager.CreateAsync(user, "IKLaceyOly21$$");
            }
        }
    }
}