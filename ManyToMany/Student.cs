using System.Collections.Generic;

public class Student : BaseEntity
{
    public virtual ICollection<Course> Courses { get; set; }

    public virtual string FirstName { get; set; }
    
    public virtual string LastName { get; set; }

}
    
