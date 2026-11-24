using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using big_isaac_project.Data;
using big_isaac_project.Models;
using big_isaac_project.Dtos;

namespace big_isaac_project.Controllers;

// Week 13: the same characters as CharacterController, answered as JSON.
[ApiController]
[Route("api/characters")]
public class CharactersApiController : ControllerBase
{
    private readonly CharacterContext _context;

    public CharactersApiController(CharacterContext context)
    {
        _context = context;
    }

    // inside TrucksApiController — both actions, replacing the old ones
    // GET /api/trucks
    [HttpGet]
    public async Task<List<CharacterDto>> GetAll()
    {
        var characters = await _context.Characters
            .Include(t => t.Gimmicks)
                .ThenInclude(s => s.Gimmick)
            .ToListAsync();

        return characters.Select(ToDto).ToList();
    }

    // GET /api/trucks/2
    [HttpGet("{id:int}")]
    public async Task<ActionResult<CharacterDto>> GetOne(int id)
    {
        var character = await _context.Characters
            .Include(t => t.Gimmicks)
                .ThenInclude(s => s.Gimmick)
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
            .Select(s => new GimmickDto { ReleaseDate = s.ReleaseDate, Gimmick = s.Gimmick })
            .ToList()
    };
}