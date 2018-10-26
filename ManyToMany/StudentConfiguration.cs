

public class StudentConfiguration : EntityTypeConfiguration<Student>
    {
        public StudentConfiguration()
        {
            ToTable("Student");
            HasKey(c => c.Id);
            HasMany(c => c.Courses).WithMany(c => c.Students).Map(cs =>
            {
                cs.MapLeftKey("StudentId");
                cs.MapRightKey("CourseId");
                cs.ToTable("StudentCourses");
            });
        }
    }
