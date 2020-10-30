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
    public ActionResult<IEnumerable<Animal>> Get(string species, string name, string breed, int age, int page, int size)
    {
      var query = _db.Animals.AsQueryable();

      if (species != null)
      {
        query = query.Where(entry => entry.Species == species);
      }
      if (name != null)
      {
        query = query.Where(entry => entry.Name == name);
      }
      if (breed != null)
      {
        query = query.Where(entry => entry.Breed == breed);
      }
      if (age != 0)
      {
        query = query.Where(entry => entry.Age == age);
      }
      if (page != 0)
      {
        if (size !=0 )
        {
        }
        else {
          size = 5;
        }
        var entries = query.OrderBy(o => o.AnimalId).Skip((page - 1) * size).Take(size).ToList(); //finds the entries to be displayed
        query = entries.AsQueryable();
      }
      return query.ToList();
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

  [HttpGet("random")] //Gets animal randomly
  public ActionResult<Animal> Get()
  {
    System.Random random = new System.Random();
    int randId = random.Next(1, _db.Animals.Count());
      return _db.Animals.FirstOrDefault(entry => entry.AnimalId == randId);
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