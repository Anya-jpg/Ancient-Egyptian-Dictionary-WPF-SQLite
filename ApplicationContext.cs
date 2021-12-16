using System.Data.Entity;

namespace EgyptianDictionary_SQLite
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext() : base("DefaultConnection")
        {
        }
        public DbSet<God> Gods { get; set; }
        public DbSet<Dictionary> Dictionaries { get; set; }
        public DbSet<Pharaoh> Pharaohs { get; set; }
        public DbSet<Phonogram> Phonograms { get; set; }
        public DbSet<Categoria> Categorias { get; set; }

    }
}