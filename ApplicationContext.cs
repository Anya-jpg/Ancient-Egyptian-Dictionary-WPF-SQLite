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
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Translator> Translators { get; set; }
        public DbSet<Translation> Translations { get; set; }

    }
}