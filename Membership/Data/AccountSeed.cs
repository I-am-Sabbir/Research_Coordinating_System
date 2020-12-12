using Data;
using Membership.Contexts;
using Membership.Entities;
using Membership.Services;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Membership.Data
{
    public class AccountSeed : DataSeed
    {
        private readonly UserManager _userManager;
        private readonly RoleManager _roleManager;

        private readonly ApplicationUser _AdminUser, _CoordinatorUser;
        private readonly Role _AdminRole, _CoordinatorRole;

        public AccountSeed(UserManager userManager, RoleManager roleManager, ApplicationDbContext context)
            : base(context)
        {
            _userManager = userManager;
            _roleManager = roleManager;

            _AdminUser = new ApplicationUser("xdxsabbir@gmail.com", "Sabbir Ahammed", "01681561869", "xdxsabbir@gmail.com");
            _CoordinatorUser = new ApplicationUser("sabbir35-1979@gmail.com", "Sabbir", "01303062901", "sabbir35-1979@gmail.com");


            _AdminRole = new Role("Admin");
            _CoordinatorRole = new Role("Coordinator");

        }

        private async Task<bool> CheckAndCreateRoleAsync(Role role)
        {
            if ((await _roleManager.FindByNameAsync(role.Name)) == null)
            {
                var result = await _roleManager.CreateAsync(role);
                return result.Succeeded;
            }
            return true;
        }

        private async Task SeedUserAsync()
        {
            IdentityResult result = null;
            if ((await _userManager.FindByNameAsync(_AdminUser.UserName.ToUpper())) == null)
            {
                result = await _userManager.CreateAsync(_AdminUser, "asd123!@#");
                if (result.Succeeded)
                {
                    if (await CheckAndCreateRoleAsync(_AdminRole))
                    {
                        await _userManager.AddToRoleAsync(_AdminUser, _AdminRole.Name);
                    }
                }
            }

            if ((await _userManager.FindByNameAsync(_CoordinatorUser.UserName.ToUpper())) == null)
            {
                result = await _userManager.CreateAsync(_CoordinatorUser, "Password@2020");
                if (result.Succeeded)
                {
                    if (await CheckAndCreateRoleAsync(_CoordinatorRole))
                    {
                        await _userManager.AddToRoleAsync(_CoordinatorUser, _CoordinatorRole.Name);
                    }
                }
            }

        }

        public override async Task SeedAsync()
        {
            await SeedUserAsync();
        }

    }
}
