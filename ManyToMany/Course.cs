using System.Collections.Generic;

public class Course : BaseEntity
{
    public virtual ICollection<Student> Students { get; set; }

    public virtual string Code { get; set; }

}
