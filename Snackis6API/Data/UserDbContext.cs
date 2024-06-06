using Microsoft.EntityFrameworkCore;
using Snackis6API.Models;

namespace Snackis6API.Data
{
    public class Snackis6Context : DbContext
    {
        public Snackis6Context(DbContextOptions<Snackis6Context> options)
            : base(options)
        {
        }

        public DbSet<Category> Category { get; set; }
    }
}
