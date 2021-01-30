using Microsoft.EntityFrameworkCore;
namespace TodoApi.Models
{
    public class FoodLibraryContext : DbContext
    {
        public FoodLibraryContext(DbContextOptions<FoodLibraryContext> options) : base(options)
        {
        }
        public DbSet<Dish> Dishes { get; set; }

    }
}