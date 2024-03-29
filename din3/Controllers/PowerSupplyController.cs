using Microsoft.AspNetCore.Mvc;


namespace Din.Controllers;

[ApiController]
[Route("[controller]")]
public class  PowerSupplyController: ControllerBase
{
    private readonly ILogger<UserController> _logger;
    private Din3Context _Din3Context;
    private IConfiguration _config;
    public PowerSupplyController(ILogger<UserController> logger, Din3Context din3Context, IConfiguration config)
    {
        _logger = logger;
        _Din3Context = din3Context;
        _config = config;
    }

[HttpGet]
[Route("/PowerSupplys")]
public ActionResult ReadAll()
{
var all = _Din3Context.PowerSupplies;
return Ok(all);
}

[HttpGet]
[Route("/PowerSupply/{id}")]
public async Task<ActionResult> Read(long id)
{
var PowerSupply = await _Din3Context.PowerSupplies.FindAsync(id);
return Ok(PowerSupply);
}

[HttpGet]
[Route("/PowerSupply/Images/{id}")]
public IActionResult GetImage(long id)
{
    var psu = _Din3Context.PowerSupplies.FirstOrDefault(m => m.PowerSupplyId == id);

    if (psu == null || string.IsNullOrWhiteSpace(psu.ImagePath))
    {
        return NotFound();
    }

    var directoryPath = "products/images"; 
    var imagePath = Path.Combine(Directory.GetCurrentDirectory(), directoryPath, psu.ImagePath);

    if (!System.IO.File.Exists(imagePath))
    {
        return NotFound();
    }

    var imageBytes = System.IO.File.ReadAllBytes(imagePath);
    return File(imageBytes, "image/jpeg"); 
}


[HttpPost]
[Route("/PowerSupply")]
public async Task<ActionResult> Create(PowerSupply powerSupply)
{
var manufacturer = await _Din3Context.Manufacturers.FindAsync(powerSupply.Manufacturer.ManufacturerId);
if(manufacturer == null){
    return BadRequest();
}
powerSupply.Manufacturer = manufacturer;
var result = await _Din3Context.PowerSupplies.AddAsync(powerSupply);
manufacturer.PowerSupplies.Add (result.Entity);
_Din3Context.SaveChanges();
return Ok(powerSupply.GetPowerSupplyDTO());
}

[HttpPost]
[Route("/PowerSupply/UploadImage/{id}")]
public async Task<ActionResult> UploadImage(long id, IFormFile image)
{
    var psu = await _Din3Context.PowerSupplies.FindAsync(id);

    if (psu == null)
    {
        return BadRequest("Power Supply not found.");
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

        psu.ImagePath = uniqueFileName;
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
[Route("/PowerSupply")]
public async Task<ActionResult> Update(PowerSupply powerSupply)
{
var find = await _Din3Context.PowerSupplies.FindAsync(powerSupply.PowerSupplyId);
if(find == null)
{
    return BadRequest();
}
find.Name = powerSupply.Name;
find.Updated = DateTime.UtcNow;
find.Description = powerSupply.Description;
find.Price = powerSupply.Price;
_Din3Context.SaveChanges();
return Ok(find);
}

[HttpDelete]
[Route("/PowerSupply/{id}")]
public async Task<ActionResult> Delete(long id)
{
var find = await _Din3Context.PowerSupplies.FindAsync(id);
if (find == null)
{
    return BadRequest();
}
var deletus = _Din3Context.PowerSupplies.Remove(find);
_Din3Context.SaveChanges();
return Ok(deletus.Entity);
}
}