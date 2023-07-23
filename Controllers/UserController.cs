using Microsoft.AspNetCore.Mvc;
using NetCore.Models;

namespace NetCore.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            // url: /controller/action => /user/index
            var vm = new UserListVm();
            vm.Name = "hola";
            vm.Role = "Super Admin";
            vm.LastLoggedIn = DateTime.Now;
            return View(vm);
        }

        public IActionResult Report(UserReportVm vm)
        {
            // Will retrieve data from database
            vm.UserRoles = new List<UserRole>()
            {
                new UserRole
                {
                    Name = "Super User",
                    Id = 1
                },
                new UserRole
                {
                    Name = "Admin",
                    Id = 1
                },
                new UserRole
                {
                    Name = "Branch Manager",
                    Id = 1
                },
                new UserRole
                {
                    Name = "Normal User",
                    Id = 1
                },
            };
            return View(vm);
        }
    }
}
