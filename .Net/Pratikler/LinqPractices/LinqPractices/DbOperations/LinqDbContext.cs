using System.Data.Entity;
using Microsoft.EntityFrameworkCore;

namespace LinqPractices.DbOperations
{
    public class LinqDbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public Microsoft.EntityFrameworkCore.DbSet<Student> Students {get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
            optionsBuilder.UseInMemoryDatabase(databaseName : "LinqDatabase");
        }
    }
}