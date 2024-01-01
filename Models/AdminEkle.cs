using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading.Tasks;

namespace HastaneRandevuSistemi.Models
{
    public class AdminEkle
    {

        public static async Task AdminAsync(IServiceProvider serviceProvider)
        {


            var userManager = serviceProvider.GetRequiredService<UserManager<IdentityUser>>();
            var email = "G211210553@sakarya.edu.tr";
            var pass = "sau";
            if (userManager.FindByEmailAsync(email).Result == null)
            {

                IdentityUser user = new()
                {
                    Email = email,
                    UserName = email,


                };
                var result = userManager.CreateAsync(user, pass).Result;

                if (result.Succeeded)
                {
                    userManager.AddToRoleAsync(user, role: "Admin").Wait();
                }
            }

        }

        internal static object AdminAsync(IServiceCollection services)
        {
            throw new NotImplementedException();
        }
    }
}

