
using RaidManager.API.Models;
using Microsoft.EntityFrameworkCore;

namespace RaidManager.API.Data

{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options){}    
        
        public DbSet<Value> Values { get; set; }

        public DbSet<User> Users { get; set;}

        public DbSet<Character> Characters { get; set; }
    }
}