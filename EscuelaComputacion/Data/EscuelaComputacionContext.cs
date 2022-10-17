using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EscuelaComputacion.Models;

namespace EscuelaComputacion.Data
{
    public class EscuelaComputacionContext : DbContext
    {
        public EscuelaComputacionContext (DbContextOptions<EscuelaComputacionContext> options)
            : base(options)
        {
        }

        public DbSet<EscuelaComputacion.Models.Students> Students { get; set; } = default!;

        public DbSet<EscuelaComputacion.Models.Courses> Courses { get; set; }

    }
}
