public class DemoContext : DbContext
{
    public DemoContext()
    {
        this.Configuration.LazyLoadingEnabled = false;
    }
}
