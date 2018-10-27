using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;


public class DemoContext : DbContext
{
    public DemoContext()
    {
        this.Configuration.LazyLoadingEnabled = false;
    }
}
