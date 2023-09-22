using Microsoft.EntityFrameworkCore;
using Noctus.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Noctus.Core.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<PDF> PDFs { get; set; }
        public DbSet<Alfabeto> Alfabetos { get; set; }

    }
}
