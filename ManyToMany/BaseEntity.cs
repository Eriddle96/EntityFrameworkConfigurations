using System;

public abstract class BaseEntity
{
    public virtual int Id { get; set; }
    public virtual DateTime CreatedOnUtc { get; set; }
}
