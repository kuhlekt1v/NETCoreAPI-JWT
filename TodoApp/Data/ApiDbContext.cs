using TodoApp.Models;
using Microsoft.EntityFrameworkCore;

namespace TodoApp.Data
{
    public class ApiDbContext : DbContext
    {
        public ApiDbContext(DbContextOptions<ApiDbContext> options)
            : base(options) { }

        public virtual DbSet<ItemData> Items { get; set; }
    }
}