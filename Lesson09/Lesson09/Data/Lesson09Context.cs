using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Lesson09.Models
{
    public class Lesson09Context : DbContext
    {
        public Lesson09Context (DbContextOptions<Lesson09Context> options)
            : base(options)
        {
        }

        public DbSet<Lesson09.Models.Customer> Customer { get; set; }
    }
}
