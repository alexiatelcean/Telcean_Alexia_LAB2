using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Telcean_Lorena_Alexia_LAB2.Models;

namespace Telcean_Lorena_Alexia_LAB2.Data
{
    public class Telcean_Lorena_Alexia_LAB2Context : DbContext
    {
        public Telcean_Lorena_Alexia_LAB2Context (DbContextOptions<Telcean_Lorena_Alexia_LAB2Context> options)
            : base(options)
        {
        }

        public DbSet<Telcean_Lorena_Alexia_LAB2.Models.Book> Book { get; set; } = default!;
        public DbSet<Telcean_Lorena_Alexia_LAB2.Models.Publisher> Publisher { get; set; } = default!;
        public DbSet<Telcean_Lorena_Alexia_LAB2.Models.Author> Author { get; set; } = default!;
    }
}
