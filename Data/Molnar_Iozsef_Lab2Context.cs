using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Molnar_Iozsef_Lab2.Models;

namespace Molnar_Iozsef_Lab2.Data
{
    public class Molnar_Iozsef_Lab2Context : DbContext
    {
        public Molnar_Iozsef_Lab2Context (DbContextOptions<Molnar_Iozsef_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Molnar_Iozsef_Lab2.Models.Book> Book { get; set; } = default!;
        public DbSet<Molnar_Iozsef_Lab2.Models.Publisher> Publisher { get; set; } = default!;
        public DbSet<Molnar_Iozsef_Lab2.Models.Author> Author { get; set; } = default!;
    }
}
