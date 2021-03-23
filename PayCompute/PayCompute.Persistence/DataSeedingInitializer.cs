using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PayCompute.Persistence
{
    public static class DataSeedingInitializer
    {
        public static async Task UserAndRoleSeedAsync(UserManager<IdentityUser> userManager, 
                                                RoleManager<IdentityRole> roleManager)
        {
            string[] roles = { "Admin", "Manager", "Staff" };
            foreach (var role in roles)
            {
                var roleExist = await roleManager.RoleExistsAsync(role);
                //if role does not exist, we will create a new role
                if (!roleExist)
                {
                    IdentityResult result = await roleManager.CreateAsync(new IdentityRole(role));
                }
            }

            //create admin user
            createUser("thisIsATestEmailAdmin@notARealEmail.com", "Password1", "Admin", userManager);

            //create Manager user
            createUser("stillNotARealManager@notARealEmail.com", "Password1", "Manager", userManager);

            //create Staff user
            createUser("stillNotARealStaff@notARealEmail.com", "Password1", "Staff", userManager);

            //create No Role user
            createUser("stillNotARealNoRole@notARealEmail.com", "Password1", "", userManager);

        }

        private static void createUser(string email, string password, string role, UserManager<IdentityUser> userManager)
        {
            if (userManager.FindByEmailAsync(email).Result == null)
            {
                IdentityUser user = new IdentityUser
                {
                    UserName = email,
                    Email = email
                };

                //this will create the user and password
                IdentityResult identityResult = userManager.CreateAsync(user, password).Result;

                if (role == "") return;

                if (identityResult.Succeeded)
                {
                    userManager.AddToRoleAsync(user, role).Wait();
                }
            }
        }
    }
}
