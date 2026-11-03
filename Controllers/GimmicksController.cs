using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using big_isaac_project.Data;
using big_isaac_project.Models;
using big_isaac_project.ViewModels;

namespace big_isaac_project.Controllers;

public class GimmicksController : Controller
{
    private readonly CharacterContext _context;

    public GimmicksController(CharacterContext context)
    {
        _context = context;
    }

    public IActionResult Create(int? characterId)
    {
        var form = new GimmickFormViewModel
        {
            Gimmick = new Gimmicks { CharacterId = characterId ?? 0 },
            Characters = CharacterChoices(characterId)
        };

        return View(form);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(GimmickFormViewModel form)
    {
        if (!ModelState.IsValid)
        {
            form.Characters = CharacterChoices(form.Gimmick.CharacterId);   // rebuild it
            return View(form);
        }

        _context.Gimmicks.Add(form.Gimmick);
        await _context.SaveChangesAsync();

        return RedirectToAction("Details", "Characters", new { id = form.Gimmick.CharacterId });
    }

    // One place that knows how to build the list, because two actions need it.
    private SelectList CharacterChoices(int? selected) =>
        new SelectList(_context.Characters.OrderBy(t => t.Name).ToList(), "Id", "Name", selected);
}