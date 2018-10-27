using System.Collections.Generic;

public class Page : BaseEntity
{
    public virtual int Number { get; set; }
    
    public virtual int BookId { get; set; }
    
    public virtual Book Book { get; set; }

}
