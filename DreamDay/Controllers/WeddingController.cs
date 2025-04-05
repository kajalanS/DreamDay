using DreamDay.Attributes;
using DreamDay.Data;
using DreamDay.Database.Core.Enum;
using DreamDay.Models;
using DreamDay.Models.View;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DreamDay.Controllers
{
    [FullUserAuthorize]
    public class WeddingController(ApplicationDbContext context) : Controller
    {
        public ApplicationDbContext Context { get; } = context;

        [HttpGet]
        public IActionResult Index()
        {
            var weddingData = Context
                .Weddings
                .Include(x => x.Couple)
                .Include(x => x.Venue)
                .Include(x => x.Budget)
                .ToList();

            return View(new WeddingPageModel
            {
                Authenticated = User.Identity?.IsAuthenticated ?? false,
                UserRole = User.IsInRole(UserType.Admin.ToString()) ? UserType.Admin : User.IsInRole(UserType.Couple.ToString()) ? UserType.Couple : UserType.Vendor,
                CurrentUser = Context.Users.FirstOrDefault(u => u.UserName == User.Identity!.Name),
                Weddings = weddingData,
                RequestId = HttpContext.TraceIdentifier
            });
        }

        [HttpGet]
        [Route("Wedding/{id:guid}")]
        public IActionResult Details(Guid id)
        {
            var wedding = Context.Weddings.FirstOrDefault(w => w.Id == id);
            if (wedding == null)
            {
                return NotFound();
            }
            return View(wedding);
        }


        // [HttpGet]
        // [Route("create")]
        // public IActionResult Create()
        // {
        //     return View();
        // }

        // [HttpPost]
        // [ValidateAntiForgeryToken]
        // public IActionResult Create(Wedding wedding)
        // {
        //     if (ModelState.IsValid)
        //     {
        //         var transaction = Context.Database.BeginTransaction();
        //         try
        //         {
        //             Context.Weddings.Add(wedding);
        //             Context.SaveChanges();
        //             transaction.Commit();
        //             return RedirectToAction(nameof(Index));
        //         }
        //         catch (System.Exception)
        //         {
        //             transaction.Rollback();
        //             ModelState.AddModelError("", "An error occurred while creating the wedding. Please try again.");
        //             throw;
        //         }
        //     }
        //     return View(wedding);
        // }

        // [HttpGet]
        // public IActionResult Edit(Guid id)
        // {
        //     var wedding = Context.Weddings.FirstOrDefault(w => w.Id == id);
        //     if (wedding == null)
        //     {
        //         return NotFound();
        //     }
        //     return View(wedding);
        // }

        // [HttpPost]
        // [ValidateAntiForgeryToken]
        // public IActionResult Edit(Wedding wedding)
        // {
        //     if (ModelState.IsValid)
        //     {
        //         var transaction = Context.Database.BeginTransaction();
        //         try
        //         {
        //             Context.Weddings.Update(wedding);
        //             Context.SaveChanges();
        //             transaction.Commit();
        //             return RedirectToAction(nameof(Index));
        //         }
        //         catch (System.Exception)
        //         {
        //             transaction.Rollback();
        //             ModelState.AddModelError("", "An error occurred while updating the wedding. Please try again.");
        //             throw;
        //         }
        //     }
        //     return View(wedding);
        // }


        // [HttpGet]
        // public IActionResult Delete(Guid id)
        // {
        //     var wedding = Context.Weddings.FirstOrDefault(w => w.Id == id);
        //     if (wedding == null)
        //     {
        //         return NotFound();
        //     }
        //     return View(wedding);
        // }

        // [HttpPost, ActionName("Delete")]
        // [ValidateAntiForgeryToken]
        // public IActionResult DeleteConfirmed(Guid id)
        // {
        //     var wedding = Context.Weddings.FirstOrDefault(w => w.Id == id);
        //     if (wedding == null)
        //     {
        //         return NotFound();
        //     }
        //     var transaction = Context.Database.BeginTransaction();
        //     try
        //     {
        //         Context.Weddings.Remove(wedding);
        //         Context.SaveChanges();
        //         transaction.Commit();
        //         return RedirectToAction(nameof(Index));
        //     }
        //     catch (System.Exception)
        //     {
        //         transaction.Rollback();
        //         ModelState.AddModelError("", "An error occurred while deleting the wedding. Please try again.");
        //         throw;
        //     }
        // }
    }
}
