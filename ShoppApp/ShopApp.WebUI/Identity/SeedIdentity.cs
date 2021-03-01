using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopApp.WebUI.Identity
{
    public static class SeedIdentity
    {
        public static async Task Seed(UserManager<ApplicationUser> userManager, 
                                      RoleManager<IdentityRole> roleManager, 
                                      IConfiguration configuration)
        {
            var userName = configuration["Data:AdminUser:UserName"];
            var password = configuration["Data:AdminUser:Password"];
            var email = configuration["Data:AdminUser:Email"];
            var role = configuration["Data:AdminUser:Role"];

            if(await userManager.FindByNameAsync(userName) == null)
            {
                await roleManager.CreateAsync(new IdentityRole(role));

                var user = new ApplicationUser()
                {
                    UserName = userName,
                    Email = email,
                    FullName = "Admin User",
                    EmailConfirmed=true
                };

                var result = await userManager.CreateAsync(user, password);

                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(user, role);
                }
            }
        }
    }
}
