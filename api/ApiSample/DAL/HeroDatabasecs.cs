using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiSample.DAL
{

    public class Hero
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public string name { get; set; }
    }

    public class HeroDatabase:DbContext
    {
        public static string DefaultConnection { get; set; }

        public DbSet<Hero> Heroes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL(DefaultConnection);
        }
    }
}
