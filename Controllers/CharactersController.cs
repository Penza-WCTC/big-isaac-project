using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using big_isaac_project.Models;
using big_isaac_project.Data;

namespace big_isaac_project.Controllers;

public class CharactersController : Controller
{
    private readonly CharacterContext _context;

    public CharactersController(CharacterContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        return View(_context.Characters.ToList());
    }

    public IActionResult Details(int id)
    {
        var character = _context.Characters.FirstOrDefault(c => c.Id == id);

        if (character == null)
        {
            return NotFound();
        }

        return View(character);
    }

    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Create(Character character)
    {
        if (!ModelState.IsValid)
        {
            return View(character);
        }

        _context.Characters.Add(character);
        _context.SaveChanges();

        return RedirectToAction(nameof(Index));
    }
}