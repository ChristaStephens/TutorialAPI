using Microsoft.EntityFrameworkCore;

namespace TutorialAPI.Models
{
    //inherit from DbContext class.
    public class CommandContext : DbContext
    {
        //allows you to pass in options when creating DBcontext
        public CommandContext(DbContextOptions<CommandContext> options) : base (options)
        {

        }
        //tells entity that this is something we want to replicate as a set
        public DbSet<Command> CommandItems {get; set;}

    }
}
