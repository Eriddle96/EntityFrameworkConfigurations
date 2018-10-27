using System.Collections.Generic;

public class Book : BaseEntity
{
    public virtual ICollection<Page> Pages { get; set; }

    public virtual string Title { get; set; }

}
