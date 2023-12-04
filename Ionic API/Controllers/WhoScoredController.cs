using Microsoft.AspNetCore.Mvc;
using Ionic_API.Data;
using Ionic_API.Models;
using Microsoft.EntityFrameworkCore;

namespace Ionic_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class WhoScoredController : Controller
    {
        private readonly IonicContext _context = new IonicContext();

        // GET: api/General/SousType
        [HttpGet("Generals/{sousType}")]
        public async Task<IActionResult> GetGeneralsBySousType(string sousType)
        {
            try
            {
                Dictionary<string, int> sousTypeMapping = new Dictionary<string, int>
                {
                    {"general", 1},
                    {"domicile", 2},
                    {"exterieur", 3}
                };
                if (!sousTypeMapping.TryGetValue(sousType.ToLower(), out int sousTypeValue))
                {
                    return BadRequest("Invalid sousType");
                }

                List<General> generals = await _context.General
                    .Where(g => g.sousType == sousTypeValue)
                    .OrderByDescending(g => g.note)
                    .ToListAsync();

                if (generals == null || generals.Count == 0)
                {
                    return NotFound();
                }

                return Ok(generals);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }


        [HttpGet("Defenses/{sousType}")]
        public async Task<IActionResult> GetDefensesBySousType(string sousType)
        {
            try
            {
                Dictionary<string, int> sousTypeMapping = new Dictionary<string, int>
                {
                    {"general", 1},
                    {"domicile", 2},
                    {"exterieur", 3}
                };
                if (!sousTypeMapping.TryGetValue(sousType.ToLower(), out int sousTypeValue))
                {
                    return BadRequest("Invalid sousType");
                }

                List<Defense> defenses = await _context.Defense
                    .Where(d => d.sousType == sousTypeValue)
                    .OrderByDescending(d => d.note)
                    .ToListAsync();

                if (defenses == null || defenses.Count == 0)
                {
                    return NotFound();
                }

                return Ok(defenses);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet("Attaques/{sousType}")]
        public async Task<IActionResult> GetAttaquesBySousType(string sousType)
        {
            try
            {
                Dictionary<string, int> sousTypeMapping = new Dictionary<string, int>
                {
                    {"general", 1},
                    {"domicile", 2},
                    {"exterieur", 3}
                };
                if (!sousTypeMapping.TryGetValue(sousType.ToLower(), out int sousTypeValue))
                {
                    return BadRequest("Invalid sousType");
                }

                List<Attaque> attaques = await _context.Attaque
                    .Where(a => a.sousType == sousTypeValue)
                    .OrderByDescending(a => a.note)
                    .ToListAsync();

                if (attaques == null || attaques.Count == 0)
                {
                    return NotFound();
                }

                return Ok(attaques);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

    }
}
