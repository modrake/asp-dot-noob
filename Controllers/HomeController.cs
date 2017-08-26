using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace CharacterSheetApp.Controllers
{
  public class HomeController : Controller
  {
    public IActionResult Index()
    {
      var model = new CharacterSheetApp.Models.Character();
      model.Name = "Big Edna";
      return View(model);
    }
  }
}