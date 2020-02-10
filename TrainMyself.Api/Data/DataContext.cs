using Microsoft.EntityFrameworkCore;
using TrainMyself.Api.Models;
using TrainMyself.Models;

namespace TrainMyself.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions options): base(options)
        {
            
        }

        public DbSet<Student> Students{get;set;}
        public DbSet<School> Schools {get;set;}
    }
}