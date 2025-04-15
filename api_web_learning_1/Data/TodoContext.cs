using Microsoft.EntityFrameworkCore;

namespace api_web_learning_1.Data
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options)
            : base(options)
        {
        }
        public DbSet<Models.TodoItem> TodoItems { get; set; } = null!;
    }
}
