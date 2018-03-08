using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Identity_and_Login.Data
{
    public static class Initializer
    {
        public static async Task initial(RoleManager<IdentityRole> roleManager)
        {
            if (!await roleManager.RoleExistsAsync("Admin"))
            {
                var users = new IdentityRole("Admin");
                await roleManager.CreateAsync(users);
            }
            if (!await roleManager.RoleExistsAsync("user"))
            {
                var users = new IdentityRole("user");
                await roleManager.CreateAsync(users);
            }
            if (!await roleManager.RoleExistsAsync("manager"))
            {
                var users = new IdentityRole("manager");
                await roleManager.CreateAsync(users);
            }
        }
    }
}
