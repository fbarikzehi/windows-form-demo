namespace Nojan.Data
{
    public abstract class CommandBase
    {
        public MainDbContext MainDbContext { get; set; } = new MainDbContext();
    }
}
