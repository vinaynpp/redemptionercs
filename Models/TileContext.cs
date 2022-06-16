using Microsoft.EntityFrameworkCore;

namespace redemptionercs.Models
{
    public class TileContext:DbContext
    {
        public TileContext(DbContextOptions<TileContext> options)
            : base(options)
        {

        }
        public DbSet<Tiles> Tiles { get; set; }
    }

}