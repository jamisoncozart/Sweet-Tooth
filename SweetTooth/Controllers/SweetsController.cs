using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SweetTooth.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;
using System.Threading.Tasks;

namespace SweetTooth.Controllers
{
  public class SweetsController : Controller
  {
    private readonly SweetToothContext _db;
    private readonly UserManager<ApplicationUser> _userManager;

    public SweetsController(UserManager<ApplicationUser> userManager, SweetToothContext db)
    {
      _userManager = userManager;
      _db = db;
    }

    public ActionResult Index()
    {
      return View(_db.Sweets.ToList());
    }

    [Authorize]
    public ActionResult Create()
    {
      ViewBag.SweetId = new SelectList(_db.Sweets, "SweetId", "Name");
      return View();
    }

    [Authorize]
    [HttpPost]
    public ActionResult Create(Sweet sweet, int FlavorId)
    {
      _db.Sweets.Add(sweet);
      if(FlavorId != 0)
      {
        _db.SweetFlavor.Add(new SweetFlavor() { FlavorId = FlavorId, SweetId = sweet.SweetId});
      }
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      Sweet thisSweet = _db.Sweets
        .Include(sweet => sweet.Flavors)
        .ThenInclude(join => join.Flavor)
        .FirstOrDefault(sweet => sweet.SweetId == id);
      return View(thisSweet);
    }

    [Authorize]
    public ActionResult Edit(int id)
    {
      Sweet thisSweet = _db.Sweets.FirstOrDefault(sweet => sweet.SweetId == id);
      ViewBag.SweetId = new SelectList(_db.Flavors, "FlavorId", "Name");
      return View(thisSweet);
    }

    [Authorize]
    [HttpPost]
    public ActionResult Edit(Sweet sweet, int FlavorId)
    {
      if(FlavorId != 0)
      {
        _db.SweetFlavor.Add(new SweetFlavor() { FlavorId = FlavorId, SweetId = sweet.SweetId });
      }
      _db.Entry(sweet).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    [Authorize]
    public ActionResult AddFlavor(int id)
    {
      Sweet thisSweet = _db.Sweets.FirstOrDefault(categories => categories.SweetId == id);
      ViewBag.FlavorId = new SelectList(_db.Flavors, "FlavorId", "Name");
      return View(thisSweet);
    }

    [Authorize]
    [HttpPost]
    public ActionResult AddFlavor(Sweet sweet, int FlavorId)
    {
      if(FlavorId != 0)
      {
        _db.SweetFlavor.Add(new SweetFlavor() { FlavorId = FlavorId, SweetId = sweet.SweetId });
      }
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    [Authorize]
    public ActionResult Delete(int id)
    {
      var thisSweet = _db.Sweets.FirstOrDefault(sweet => sweet.SweetId == id);
      return View(thisSweet);
    }
    
    [Authorize]
    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      var thisSweet = _db.Sweets.FirstOrDefault(sweet => sweet.SweetId == id);
      _db.Sweets.Remove(thisSweet);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}