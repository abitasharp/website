using Abitasharp.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abitasharp.Data
{
    public class ContextSeeder
    {
        private ApplicationContext _context;
        private UserManager<Utente> _userManager;
        private RoleManager<IdentityRole> _roleManager;

        public ContextSeeder(ApplicationContext context, 
            UserManager<Utente> userManager, 
            RoleManager<IdentityRole> roleManager)
        {
            _context = context;
            _userManager = userManager;
            _roleManager = roleManager;
        }
        
        public void Empty()
        {

        }

        public void Seed()
        {
            /* Roles */
            var tasks = new Task<IdentityResult>[3];
            tasks[0] = _roleManager.CreateAsync(new IdentityRole("Admin"));
            tasks[1] = _roleManager.CreateAsync(new IdentityRole("Privato"));
            tasks[2] = _roleManager.CreateAsync(new IdentityRole("Azienda"));
            Task.WaitAll(tasks);
            /* Admin */
            Admin admin = new Admin();
            admin.Id = Guid.NewGuid().ToString();
            admin.UserName = admin.Id;
            admin.Email = "admin@abitasharp.com";

            tasks[0] = _userManager.CreateAsync(admin, "ingsoftware");
            Task.WaitAll(tasks);
            tasks[0] =  _userManager.AddToRoleAsync(admin, "Admin");
            Task.WaitAll(tasks);
        }
    }
}
