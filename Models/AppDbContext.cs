using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mathletes2020.Areas.Multiplication.Models;

namespace Mathletes2020.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) 
            : base(options)
        {

        }

        public DbSet<Answers> Answers { get; set; }
        public DbSet<StudentStats> StudentStats { get; set; }
        
    }
}
