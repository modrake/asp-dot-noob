using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace CharacterSheetApp.Controllers
{
  public class HomeController : Controller
  {
    public IActionResult Index()
    {
      var name = "Big Edna";
      return View("Index",name);
    }
  }
}