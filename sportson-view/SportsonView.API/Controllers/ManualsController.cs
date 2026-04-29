using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SportsonView.API.Data; 
using SportsonView.API.Data.Entities; 

namespace SportsonView.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ManualsController : ControllerBase
{
    private readonly ApplicationDbContext _context;

    public ManualsController(ApplicationDbContext context)
    {
        _context = context;
    }

        
            
    [HttpGet("search")]
    public async Task<ActionResult<IEnumerable<Manual>>> SearchManuals([FromQuery] string? query)
    {
        try
        {
            // 1. Byggsten: Säkerhetskoll - returnera tom lista om sökordet är för kort
            if (string.IsNullOrWhiteSpace(query) || query.Length < 2)
            {
                return Ok(new List<Manual>());
            }

            // 2. Tvätta sökordet
            var cleanQuery = query.Trim().ToLower();

            // 3. Den kreativa sökningen med viktad sortering
            var results = await _context.Manuals
                .Where(m => 
                    m.Title.ToLower().Contains(cleanQuery) || 
                    (m.Description != null && m.Description.ToLower().Contains(cleanQuery)))
                
                // SORTERINGSLOGIK:
                // .OrderByDescending på en bool (True/False) gör att True (träff i titeln) hamnar först.
                .OrderByDescending(m => m.Title.ToLower().Contains(cleanQuery))
                
                // Därefter sorterar vi på titel i bokstavsordning
                .ThenBy(m => m.Title)
                
                .ToListAsync();

            return Ok(results);
        }
        catch (Exception ex)
        {
            // Logga felet internt (ex.Message) men skicka ett snyggt svar utåt
            return StatusCode(500, "Ett fel uppstod i sökfunktionen.");
        }
    }


        [HttpGet]
        public async Task<ActionResult<IEnumerable<Manual>>> GetManuals()
        {
            return await _context.Manuals.ToListAsync();
        }
}
