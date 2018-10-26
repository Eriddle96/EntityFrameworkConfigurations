using System.Data.Entity.ModelConfiguration;

public class StudentConfiguration : EntityTypeConfiguration<Student>
{
    public StudentConfiguration()
    {
        ToTable("Student");
        HasKey(s => s.Id);
        HasMany(c => c.Courses).WithMany(s => s.Students).Map(sc =>
        {
            sc.MapLeftKey("StudentId");
            sc.MapRightKey("CourseId");
            sc.ToTable("StudentCourses");
        });
    }
}
