using Microsoft.EntityFrameworkCore;
using Movies_Exam.Model;

namespace Movies_Exam.Persistence
{
    public class MoviesContext : DbContext
    {
        public MoviesContext() { }
        public MoviesContext(DbContextOptions<MoviesContext> options) : base(options) { }
        public virtual DbSet<VisualContent> VisualContent { get; set; }
        public virtual DbSet<Language> Language { get; set; }
        public virtual DbSet<Genre> Genre { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<Stadistics> Stadistics { get; set; }
        public virtual DbSet<Staff> Staff { get; set; }
        public virtual DbSet<TypeContent> TypeContent { get; set; }
        public virtual DbSet<VisualContentGenre> VisualContentGenre { get; set; }
        public virtual DbSet<VisualContentLanguage> VisualContentLanguage { get; set; }
        public virtual DbSet<VisualContentStaff> VisualContentStaff { get; set; }
    }
}
