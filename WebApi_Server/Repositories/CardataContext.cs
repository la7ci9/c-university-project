using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Text.Json;
using WebApi_Common.Models;

namespace WebApi_Server.Repositories
{
    public class CardataContext : DbContext
    {
      
        public DbSet<Cardata> Cars { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(

               "Data Source=(localdb)\\mssqllocaldb;Database=ServerDb;Integrated Security=True;");
 
        }
    }
}
