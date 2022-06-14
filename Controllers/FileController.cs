using redemptionercs.Models;
using redemptionercs.Services;
using Microsoft.AspNetCore.Mvc;

namespace redemptionercs.Controllers;

[ApiController]
[Route("[controller]")]
public class FileController : ControllerBase
{
    public FileController()
    {

    }
            // GET all action
    [HttpGet]
    public ActionResult<List<Files>> GetAll() => FilesService.GetAll();
    

        // GET by Id action
    [HttpGet("{id}")]   
    public ActionResult<Files> GetFile(int id)
    {
        var file = FilesService.GetFile(id);
        if (file == null)
        {
            return NotFound();
        }
        return file;
    }
    

    // POST action
    [HttpPost]
    public ActionResult<Files> CreateFile(Files file)
    {
        FilesService.AddFile(file);
        return CreatedAtRoute("GetFile", new { id = file.Id }, file);
    }
    

    // PUT action
    [HttpPut("{id}")]
    public IActionResult UpdateFile(int id, Files file)
    {
        var oldFile = FilesService.GetFile(id);
        if (oldFile == null)
        {
            return NotFound();
        }
        FilesService.UpdateFile(file);
        return NoContent();
    }

    // DELETE action
    [HttpDelete("{id}")]
    public IActionResult DeleteFile(int id)
    {
        var file = FilesService.GetFile(id);
        if (file == null)
        {
            return NotFound();
        }
        FilesService.DeleteFile(id);
        return NoContent();
    }
}
