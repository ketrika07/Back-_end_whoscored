using Ionic_API.Data;
using Ionic_API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.Threading.Tasks;

namespace Ionic_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IndexController : ControllerBase
    {
        private readonly IonicContext _context= new IonicContext();

        /*public IndexController(IonicContext context)
        {
            _context = context;
        }*/

        // GET: api/General/SousType/1
        [HttpGet("SousType/{sousType}")]
        public async Task<IActionResult> GetGeneralsBySousType(int sousType)
        {
            try
            {
                List<General> generals = await _context.General
                    .Where(g => g.sousType == sousType)
                    .ToListAsync();

                if (generals == null || generals.Count == 0)
                {
                    return NotFound();
                }
                /*
                var jsonOptions = new JsonSerializerOptions
                {
                    ReferenceHandler = ReferenceHandler.Preserve,
                    // Add other serialization options as needed
                };

                string serializedGenerals = JsonSerializer.Serialize(generals, jsonOptions);

                var result = new ContentResult
                {
                    Content = serializedGenerals,
                    ContentType = "application/json",
                };

                return result;*/
                return Ok(generals);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }


    }
}