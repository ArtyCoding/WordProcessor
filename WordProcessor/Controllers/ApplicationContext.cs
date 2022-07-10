using Microsoft.EntityFrameworkCore;
using WordProcessor.Models;

namespace WordProcessor
{
    internal class ApplicationContext : DbContext
    {
        public DbSet<DictionaryModel> DictionaryModels => Set<DictionaryModel>();

        public ApplicationContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=dictionary.db");
            optionsBuilder.LogTo(message => System.Diagnostics.Debug.WriteLine(message));
        }
    }
}
