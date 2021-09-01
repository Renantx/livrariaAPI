using Microsoft.EntityFrameworkCore;


namespace livrariaAPI.Models
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> option)
             : base(option)
        {
        }

        public DbSet<Product> TodoProducts { get; set; }
    }
}
