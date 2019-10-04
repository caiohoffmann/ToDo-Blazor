using Microsoft.EntityFrameworkCore;
using TaskiesBlazor.Data;

namespace TaskiesBlazor.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> dbContextOptions) : base(dbContextOptions)
        {
        }
        public DbSet<Taskie> Taskies { get; set; }
        public DbSet<TaskBlock> TaskBlocks { get; set; }
    }
}
