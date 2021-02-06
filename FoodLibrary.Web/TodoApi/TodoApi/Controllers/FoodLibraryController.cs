using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TodoApi.Models;

namespace TodoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FoodLibraryController : ControllerBase
    {
        private readonly FoodLibraryContext _context;

        public FoodLibraryController(FoodLibraryContext context)
        {
            _context = context;
        }

        // GET: api/StockPurchases
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Dish>>> GetDishes()
        {
            return await _context.Dishes
                .ToListAsync();
        }

        [HttpGet("NineRandom")]
        public async Task<ActionResult<IEnumerable<Dish>>> GetNineRandomDishes()
        {
            var NineRandomDishesQuery = _context.Dishes.OrderBy(r => Guid.NewGuid()).Take(9);
            return await NineRandomDishesQuery.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Dish>> GetDish(int id)
        {
            var selectedDish = await _context.Dishes.FindAsync(id);

            if (selectedDish == null)
            {
                return NotFound();
            }

            return selectedDish;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateDish(int id, Dish updatedDish)
        {
            if (id != updatedDish.ID)
            {
                return BadRequest();
            }

            var dishFromDB= await _context.Dishes.FindAsync(id);
            if (dishFromDB == null)
            {
                return NotFound();
            }

            dishFromDB.ID = updatedDish.ID;
            dishFromDB.Name = updatedDish.Name;
            dishFromDB.PreparationTimeMinutes = updatedDish.PreparationTimeMinutes;
            dishFromDB.Meat = updatedDish.Meat;
            dishFromDB.MealType = updatedDish.MealType;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException) when (!dishExists(id))
            {
                return NotFound();
            }

            return NoContent();
        }

        [HttpPost]
        public async Task<ActionResult<Dish>> CreateDish(Dish dishToCreate)
        {
            //Console.WriteLine("Testline");
            //Console.WriteLine(stockPurchase);
            _context.Dishes.Add(dishToCreate);
            await _context.SaveChangesAsync();

            return CreatedAtAction(
                nameof(GetDish),
                new { id = dishToCreate.ID },
                dishToCreate);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDish(int id)
        {
            var dishtoRemove = await _context.Dishes.FindAsync(id);

            if (dishtoRemove == null)
            {
                return NotFound();
            }

            _context.Dishes.Remove(dishtoRemove);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool dishExists(long id) =>
             _context.Dishes.Any(e => e.ID == id);
    }
}
