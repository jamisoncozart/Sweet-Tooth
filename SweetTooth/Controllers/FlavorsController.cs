using Microsoft.AspNetCore.Mvc;
using SweetTooth.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using System.Security.Claims;

namespace SweetTooth.Controllers
{
  
  public class FlavorsController : Controller
  {
    private readonly SweetToothContext _db;
    private readonly UserManager<ApplicationUser> _userManager; 

    public FlavorsController(UserManager<ApplicationUser> userManager, SweetToothContext db)
    {
      _userManager = userManager; 
      _db = db;
    }
    public ActionResult Index()
    {
      var allFlavors = _db.Flavors.ToList();
      return View(allFlavors);
    }

    [Authorize]
    public ActionResult Create()
    {
      ViewBag.SweetId = new SelectList(_db.Sweets, "SweetId", "Name");
      return View();
    }

    [Authorize]
    [HttpPost]
    public async Task<ActionResult> Create(Flavor flavor, int SweetId)
    {
      var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
      var currentUser = await _userManager.FindByIdAsync(userId);
      _db.Flavors.Add(flavor);
      if (SweetId != 0)
      {
        _db.SweetFlavor.Add(new SweetFlavor() { SweetId = SweetId, FlavorId = flavor.FlavorId });
      }
      _db.SaveChanges();
      return RedirectToAction("Index", "Home");
    }

    public ActionResult Details(int id)
    {
      var thisFlavor = _db.Flavors
        .Include(flavor => flavor.Sweets)
        .ThenInclude(join => join.Sweet)
        .FirstOrDefault(flavor => flavor.FlavorId == id);
      return View(thisFlavor);
    }

    [Authorize]
    public ActionResult AddSweet(int id)
    {
      var thisFlavor = _db.Flavors.FirstOrDefault(flavors => flavors.FlavorId == id);
      ViewBag.SweetId = new SelectList(_db.Flavors, "SweetId", "Name");
      return View(thisFlavor);
    }

    [Authorize]
    [HttpPost]
    public ActionResult AddSweet(Flavor flavor, int SweetId)
    {
      if (SweetId != 0)
      {
        _db.SweetFlavor.Add(new SweetFlavor() { SweetId = SweetId, FlavorId = flavor.FlavorId });
      }
      _db.SaveChanges();
      return RedirectToAction("Index", "Home");
    }

    [Authorize]
    public ActionResult Delete(int id)
    {
      var thisFlavor = _db.Flavors.FirstOrDefault(flavors => flavors.FlavorId == id);
      return View(thisFlavor);
    }

    [Authorize]
    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      var thisFlavor = _db.Flavors.FirstOrDefault(flavors => flavors.FlavorId == id);
      _db.Flavors.Remove(thisFlavor);
      _db.SaveChanges();
      return RedirectToAction("Index", "Home");
    }

    [Authorize]
    [HttpPost]
    public ActionResult DeleteSweet(int joinId)
    {
      var joinEntry = _db.SweetFlavor.FirstOrDefault(entry => entry.SweetFlavorId == joinId);
      _db.SweetFlavor.Remove(joinEntry);
      _db.SaveChanges();
      return RedirectToAction("Index", "Home");
    }
  }
}