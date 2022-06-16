using redemptionercs.Models;

// namespace redemptionercs.Services
// {
//     public static class TilesService
//     {
//         static List<Tiles> Folder { get; }
//         static int nextId = 3;
//         static TilesService()
//         {
//             Folder = new List<Tiles>
//             {
//                 new Tiles { Id = 1, Name = "Tile1", Path = "C:\\Tile1.txt", Extension = "txt" },
//                 new Tiles { Id = 2, Name = "Tile2", Path = "C:\\Tile2.txt", Extension = "txt" },
//             };
//         }
//         public static List<Tiles> GetAll()
//         {
//             return Folder;
//         }
//         public static Tiles? GetTile(int id)
//         {
//             return Folder.FirstOrDefault(f => f.Id == id);
//         }
//         public static void AddTile(Tiles tile)
//         {
//             tile.Id = nextId++;
//             Folder.Add(tile);
//         }
//         public static void UpdateTile(Tiles tile)
//         {
//             var oldTile = GetTile(tile.Id);
//             if (oldTile == null)
//             {
//                 throw new Exception("tile not found");
//             }
//             oldTile.Name = tile.Name;
//             oldTile.Path = tile.Path;
//             oldTile.Extension = tile.Extension;
//         }
//         public static void DeleteTile(int id)
//         {
//             var tile = GetTile(id);
//             if (tile == null)
//             {
//                 throw new Exception("tile not found");
//             }
//             Folder.Remove(tile);
//         }

//     }
// }