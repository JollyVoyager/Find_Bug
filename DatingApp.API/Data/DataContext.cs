using DatingApp.API.Models;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.API.Data

//Referenciar aqui sempre que é criada uma nova classe (ou alterada) nos models

{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options){}
    
        public DbSet<Value> Values { get; set; }
    
        public DbSet<User> Users { get; set; }
        public DbSet<Photo> Photos { get; set; }
    }
}

