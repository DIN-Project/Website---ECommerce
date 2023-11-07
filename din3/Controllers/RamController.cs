using Microsoft.AspNetCore.Mvc;


namespace Din.Controllers;

[ApiController]
[Route("[controller]")]
public class  RamController: ControllerBase
{
    private readonly ILogger<UserController> _logger;
    private Din3Context _Din3Context;
    private IConfiguration _config;
    public RamController(ILogger<UserController> logger, Din3Context din3Context, IConfiguration config)
    {
        _logger = logger;
        _Din3Context = din3Context;
        _config = config;
    }

[HttpGet]
[Route("/Rams")]
public ActionResult ReadAll()
{
var all = _Din3Context.Rams;
return Ok(all);
}

[HttpGet]
[Route("/Ram/{id}")]
public async Task<ActionResult> Read(long id)
{
var Ram = await _Din3Context.Rams.FindAsync(id);
return Ok(Ram);
}

[HttpPost]
[Route("/Ram")]
public async Task<ActionResult> Create(Ram ram)
{
var manufacturer = await _Din3Context.Manufacturers.FindAsync(ram.Manufacturer.ManufacturerId);
if(manufacturer == null){
    return BadRequest();
}
ram.Manufacturer = manufacturer;
var result = await _Din3Context.Rams.AddAsync(ram);
manufacturer.Rams.Add (result.Entity);
_Din3Context.SaveChanges();
return Ok(ram.GetRamDTO());
}

[HttpPost]
[Route("/Ram/UploadImage/{id}")]
public async Task<ActionResult> UploadImage(long id, IFormFile image)
{
    var ram = await _Din3Context.Rams.FindAsync(id);

    if (ram == null)
    {
        return BadRequest("RAM not found.");
    }

    if (image != null && image.Length > 0)
    {
        var directoryPath = "products/images";
        var uniqueFileName = Guid.NewGuid().ToString() + "_" + image.FileName;
        var imagePath = Path.Combine(directoryPath, uniqueFileName);

        if (!Directory.Exists(directoryPath))
        {
            Directory.CreateDirectory(directoryPath);
        }

        using (var stream = new FileStream(imagePath, FileMode.Create))
        {
            await image.CopyToAsync(stream);
        }

        ram.ImagePath = uniqueFileName;
        _Din3Context.SaveChanges();

        Console.WriteLine("Image uploaded to: " + imagePath);

        return Ok("Image uploaded successfully.");
    }
    else
    {
        return BadRequest("Image upload failed.");
    }
}

[HttpPut]
[Route("/Ram")]
public async Task<ActionResult> Update(Ram ram)
{
var find = await _Din3Context.Rams.FindAsync(ram.RamId);
if(find == null)
{
    return BadRequest();
}
find.Name = ram.Name;
find.Updated = DateTime.UtcNow;
find.Description = ram.Description;
find.Price = ram.Price;
_Din3Context.SaveChanges();
return Ok(find);
}

[HttpDelete]
[Route("/Ram/{id}")]
public async Task<ActionResult> Delete(long id)
{
var find = await _Din3Context.Rams.FindAsync(id);
if (find == null)
{
    return BadRequest();
}
var deletus = _Din3Context.Rams.Remove(find);
_Din3Context.SaveChanges();
return Ok(deletus.Entity);
}
}