using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using Server.Data;
using System.Linq;

namespace Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    

    public class SuperHeroController : ControllerBase
    {
        private readonly DataContext _context;
        public SuperHeroController(DataContext context)
        {
            _context = context;

        }

        private List<SuperHero> Gett()
    {
        var q = (from c in _context.SuperHeroes       // Gives all data
                 select new SuperHero
                 {
                     ID = c.ID,
                     Name = c.Name,
                     FirstName = c.FirstName,
                     LastName = c.LastName,
                     Place = c.Place,
                 }).ToList();
            return (q);
    }
        

        [HttpGet]



        public async  Task<ActionResult<List<SuperHero>>> GetSuperHeroes()
        {
            // return Ok(await _context.SuperHeroes.ToListAsync());      //Gets all data at a time
            //int target =1;
            /* var result = (from c in _context.SuperHeroes    //Get Here by ID
                           where c.ID == target
                           select new SuperHero
                           {
                               ID = c.ID,
                               Name = c.Name,
                               FirstName = c.FirstName,
                               LastName = c.LastName,
                               Place = c.Place,

                           }).ToListAsync();
             return Ok(await result);*/


            var q = Gett();
            return Ok(q);

        }
        [HttpPost]

        public async Task<ActionResult<List<SuperHero>>> CreateSuperHero(SuperHero hero)
        {
            _context.SuperHeroes.Add(hero);
            await _context.SaveChangesAsync();
            var q = Gett();
            return Ok(q);
        }
        [HttpPut]

        public async Task<ActionResult<List<SuperHero>>> UpdateSuperHero(SuperHero hero)
        {
            var dbHero = await _context.SuperHeroes.FindAsync(hero.ID);
            if (dbHero == null)
                return BadRequest("Student not found");

            dbHero.Name = hero.Name;
            dbHero.FirstName = hero.FirstName;
            dbHero.LastName = hero.LastName;
            dbHero.Place = hero.Place;

            await _context.SaveChangesAsync();
            var q = Gett();
            return Ok(q);

        }
        [HttpDelete("{id}")]

        public async Task<ActionResult<List<SuperHero>>> DeleteSuperHero(int id)
        {
            var dbHero = await _context.SuperHeroes.FindAsync(id);
            if (dbHero == null)
                return BadRequest("Student not found");

            _context.SuperHeroes.Remove(dbHero);
            await _context.SaveChangesAsync();
            var q = Gett();
            return Ok(q);
        }
        [HttpGet("{id}")]

        public async Task<ActionResult<List<SuperHero>>> GetSuperHeroes(int id)
        {
           

            var result = (from c in _context.SuperHeroes    //Get Here by ID
                          where c.ID == id
                          select new SuperHero
                          {
                              ID = c.ID,
                              Name = c.Name,
                              FirstName = c.FirstName,
                              LastName = c.LastName,
                              Place = c.Place,

                          }).ToListAsync();

            return Ok(await result);

        }
    }
}
