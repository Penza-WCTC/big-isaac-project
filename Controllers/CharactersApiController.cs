using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using big_isaac_project.Data;
using big_isaac_project.Models;

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

    // GET /api/characters
    [HttpGet]
    public async Task<List<Character>> GetAll()
    {
        return await _context.Characters.ToListAsync();
    }
}