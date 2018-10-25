// One-to-Many relationship between Book and Page. One Book has many Pages. One Page belongs only to specific Book. 


    public class PageConfiguration : EntityTypeConfiguration<Page>
    {
        public PageConfiguration()
        {
            ToTable("Page");
            HasKey(c => c.Id);
            HasRequired(a => a.Book).WithMany(p => p.Pages)
                .HasForeignKey(a => a.BookId);
        }
    }
    
    public class BookConfiguration : EntityTypeConfiguration<Book>
    {
        public BookConfiguration()
        {
            ToTable("Book");
            HasKey(c => c.Id);
            HasMany(c => c.Pages);
        }
    }
    
    public class Book : BaseEntity
    {
        public virtual ICollection<Page> Pages { get; set; }

        public virtual string Title { get; set; }
    }
    
    public class Page : BaseEntity
    {
        public virtual int BookId { get; set; }

        public virtual Book Book { get; set; }

        public virtual int PageNumber { get; set; }

    }
    
    public abstract class BaseEntity
    {
        public virtual int Id { get; set; }
    }
    
    
