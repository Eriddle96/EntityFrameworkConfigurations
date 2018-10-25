//Many-to-Many relationship between Application and User. An Application can have many users. A user can have many applications

public class ApplicationConfiguration : EntityTypeConfiguration<Application>
    {
        public ApplicationConfiguration()
        {
            ToTable("Application");
            HasKey(c => c.Id);
            

            HasMany(c => c.ApplicationUsers)
                .WithMany(a => a.UserApplications)
                .Map(m => m.ToTable("UserApplications"));
        }
    }
    
    
public class UserConfiguration : EntityTypeConfiguration<User>
    {
        public UserConfiguration()
        {
            ToTable("User");
            HasKey(c => c.Id);
            HasMany(c => c.UserApplications)
                .WithMany(a => a.ApplicationUsers)
                .Map(m => m.ToTable("UserApplications"));
        }
    }
    
    
    
