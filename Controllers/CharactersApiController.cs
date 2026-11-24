using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using big_isaac_project.Data;
using big_isaac_project.Models;
using big_isaac_project.Dtos;

namespace big_isaac_project.Controllers;

// Week 13: the same characters as CharacterController, answered as JSON.
[ApiController]
[Route("api/characters")]
[Authorize(Roles = "Admin")]
public class CharactersApiController : ControllerBase
{
    private readonly CharacterContext _context;

    public CharactersApiController(CharacterContext context)
    {
        _context = context;
    }

    // inside CharacterApiController — both actions, replacing the old ones
    // GET /api/Characters
    [AllowAnonymous]
    [HttpGet]
    public async Task<List<CharacterDto>> GetAll()
    {
        var characters = await _context.Characters
            .Include(t => t.Gimmicks)
            .ToListAsync();

        return characters.Select(ToDto).ToList();
    }

    // GET /api/Characters/2
    [AllowAnonymous]
    [HttpGet("{id:int}")]
    public async Task<ActionResult<CharacterDto>> GetOne(int id)
    {
        var character = await _context.Characters
            .Include(t => t.Gimmicks)
            .FirstOrDefaultAsync(t => t.Id == id);

        if (character == null)
        {
            return NotFound();
        }

        return ToDto(character);
    }

    private static CharacterDto ToDto(Character character) => new CharacterDto
    {
        Id = character.Id,
        Name = character.Name,
        Health = character.Health,
        Speed = character.Speed,
        Damage = character.Damage,
        Gimmicks = character.Gimmicks
        .Select(s => new GimmickDto
        {
            ReleaseDate = s.ReleaseDate,
            Gimmick = s.Gimmick
        })
        .ToList()
    };

    [HttpPost]
    public async Task<ActionResult<CharacterDto>> Create(CharacterInput input)
    {
        var character = new Character
        {
            Name = input.Name,
            Health = input.Health,
            Speed = input.Speed,
            Damage = input.Damage,
            FavoriteDetails = input.FavoriteDetails
        };

        _context.Characters.Add(character);
        await _context.SaveChangesAsync();

        return CreatedAtAction(nameof(GetOne), new { id = character.Id }, ToDto(character));
    }

    // PUT /api/characters/2
    [HttpPut("{id:int}")]
    public async Task<IActionResult> Update(int id, CharacterInput input)
    {
        var character = await _context.Characters.FindAsync(id);
        if (character == null)
        {
            return NotFound();
        }

        character.Name = input.Name;
        character.Health = input.Health;
        character.Speed = input.Speed;
        character.Damage = input.Damage;
        character.FavoriteDetails = input.FavoriteDetails;

        await _context.SaveChangesAsync();
        return NoContent();
    }

    // DELETE /api/characters/2
    [HttpDelete("{id:int}")]
    public async Task<IActionResult> Delete(int id)
    {
        var character = await _context.Characters.FindAsync(id);
        if (character == null)
        {
            return NotFound();
        }

        _context.Characters.Remove(character);
        await _context.SaveChangesAsync();
        return NoContent();
    }
}