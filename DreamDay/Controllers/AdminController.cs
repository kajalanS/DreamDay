using DreamDay.Attributes;
using DreamDay.Database.Core.Enum;
using DreamDay.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace DreamDay.Controllers
{
    [AdminAuthorize]
    public class AdminController(UserManager<User> userManager) : Controller
    {
        public UserManager<User> TestUserManager { get; } = userManager;

        // GET: AdminController
        public ActionResult IndexAsync()
        {
            //var user = await TestUserManager.GetUserAsync(User);
            return View();
        }
    }
}
