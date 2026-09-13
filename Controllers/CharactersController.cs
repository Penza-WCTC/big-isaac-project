using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using big_isaac_project.Models;

namespace big_isaac_project.Controllers;

public class CharactersController : Controller
{
    public IActionResult Index()
    {
        return View(CharacterData.All);
    }

    public IActionResult Details(int id)
    {
        var character = CharacterData.All.FirstOrDefault(t => t.Id == id);

        if(character == null)
        {
            return NotFound();
        }

        return View(character);
    }
}
