using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
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
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=dictionary;Trusted_Connection=True;");
            //optionsBuilder.UseSqlite("Data Source=dictionary.db");
            optionsBuilder.LogTo(message => System.Diagnostics.Debug.WriteLine(message));
        }
    }
}
