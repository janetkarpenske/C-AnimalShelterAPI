using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using AnimalShelter.Models;

namespace AnimalShelter.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class AnimalsController : ControllerBase
  {
    private AnimalShelterContext _db;

    public AnimalsController(AnimalShelterContext db)
    {
      _db = db;
    }

  [HttpGet] //Get all animals functionality
    public ActionResult<IEnumerable<Animal>> Get()
    {
      return _db.Animals.ToList();
    }
  
  [HttpPost] //Add animal functionality
    public void Post([FromBody] Animal animal)
    {
      _db.Animals.Add(animal);
      _db.SaveChanges();
    }

  [HttpGet("{id}")] //Get by id functionality
  public ActionResult<Animal> Get(int id)
  {
      return _db.Animals.FirstOrDefault(entry => entry.AnimalId == id);
  }

  [HttpPut("{id}")] //Edit Functionality
    public void Put(int id, [FromBody] Animal animal)
    {
        animal.AnimalId = id;
        _db.Entry(animal).State = EntityState.Modified;
        _db.SaveChanges();
    }

  [HttpDelete("{id}")] //delete functionality
    public void Delete(int id)
    {
      var animalToDelete = _db.Animals.FirstOrDefault(entry => entry.AnimalId == id);
      _db.Animals.Remove(animalToDelete);
      _db.SaveChanges();
    }
  }
}