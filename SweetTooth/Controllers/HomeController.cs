using Microsoft.AspNetCore.Mvc;
using SweetTooth.Models;
using System.Linq;

namespace SweetTooth.Controllers
{
  public class HomeController : Controller
  {

    private readonly SweetToothContext _db;

    public HomeController(SweetToothContext db)
    {
      _db = db;
    }

    [HttpGet("/")]
    public ActionResult Index()
    {
      ViewBag.Flavors = _db.Flavors.ToList();
      return View(_db.Sweets.ToList());
    }
  }
}