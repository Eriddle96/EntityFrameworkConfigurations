using System.Data.Entity.ModelConfiguration;

public class CourseConfiguration : EntityTypeConfiguration<Course>
{
    public CourseConfiguration()
    {
        ToTable("Course");
        HasKey(c => c.Id);
    }
}
