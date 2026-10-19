using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using big_isaac_project.Models;
using big_isaac_project.Data;
using Microsoft.EntityFrameworkCore;

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

    // GET: CharacterScaffold/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var character = await _context.Characters.FindAsync(id);
            if (character == null)
            {
                return NotFound();
            }
            return View(character);
        }

        // POST: CharacterScaffold/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Health,Speed,Damage,FavoriteDetails")] Character character)
        {
            if (id != character.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(character);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CharacterExists(character.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(character);
        }

         private bool CharacterExists(int id)
        {
            return _context.Characters.Any(e => e.Id == id);
        }


        // GET: CharacterScaffold/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var character = await _context.Characters
                .FirstOrDefaultAsync(m => m.Id == id);
            if (character == null)
            {
                return NotFound();
            }

            return View(character);
        }

        // POST: CharacterScaffold/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var character = await _context.Characters.FindAsync(id);
            if (character != null)
            {
                _context.Characters.Remove(character);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

}