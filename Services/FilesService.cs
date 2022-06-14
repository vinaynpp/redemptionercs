using redemptionercs.Models;

namespace redemptionercs.Services
{
    public static class FilesService
    {
        static List<Files> Folder { get; }
        static int nextId = 3;
        static FilesService()
        {
            Folder = new List<Files>
            {
                new Files { Id = 1, Name = "File1", Path = "C:\\File1.txt", Extension = "txt" },
                new Files { Id = 2, Name = "File2", Path = "C:\\File2.txt", Extension = "txt" },
            };
        }
        public static List<Files> GetAll()
        {
            return Folder;
        }
        public static Files? GetFile(int id)
        {
            return Folder.FirstOrDefault(f => f.Id == id);
        }
        public static void AddFile(Files file)
        {
            file.Id = nextId++;
            Folder.Add(file);
        }
        public static void UpdateFile(Files file)
        {
            var oldFile = GetFile(file.Id);
            if (oldFile == null)
            {
                throw new Exception("File not found");
            }
            oldFile.Name = file.Name;
            oldFile.Path = file.Path;
            oldFile.Extension = file.Extension;
        }
        public static void DeleteFile(int id)
        {
            var file = GetFile(id);
            if (file == null)
            {
                throw new Exception("File not found");
            }
            Folder.Remove(file);
        }

    }
}