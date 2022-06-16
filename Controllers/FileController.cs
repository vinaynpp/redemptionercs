using redemptionercs.Models;
// using redemptionercs.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace redemptionercs.Controllers;

[ApiController]
[Route("[controller]")]
public class TileController : ControllerBase
{
    private readonly TileContext _context;

    private readonly ILogger<TileController> _logger;

    public TileController(TileContext context,ILogger<TileController> logger)
    {
        _context = context;
        _logger = logger;
    }
        // GET all action
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Tiles>>> GetTiles()
        {
            return await _context.Tiles.ToListAsync();
        }
    

        // GET by Id action
    [HttpGet("{id}")]   
    public async Task<ActionResult<Tiles>> GetProduct(long id)
        {
            var Tile = await _context.Tiles.FindAsync(id);

            if (Tile == null)
            {
                return NotFound();
            }

            return Tile;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutProduct(long id, Tiles Tile)
        {
            if (id != Tile.Id)
            {
                return BadRequest();
            }

            _context.Entry(Tile).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TileExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        private bool TileExists(long id)
        {
            return _context.Tiles.Any(e => e.Id == id);
        }

        [HttpPost]
        public async Task<ActionResult<Tiles>> PostProduct(Tiles Tile)
        {
            _context.Tiles.Add(Tile);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TileExists(Tile.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetProduct", new { id = Tile.Id }, Tile);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct(long id)
        {
            var product = await _context.Tiles.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }

            _context.Tiles.Remove(product);
            await _context.SaveChangesAsync();

            return NoContent();
        }
}
