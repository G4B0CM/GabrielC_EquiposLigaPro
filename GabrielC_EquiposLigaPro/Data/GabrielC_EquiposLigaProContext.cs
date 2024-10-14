using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GabrielC_EquiposLigaPro.Models;

namespace GabrielC_EquiposLigaPro.Data
{
    public class GabrielC_EquiposLigaProContext : DbContext
    {
        public GabrielC_EquiposLigaProContext (DbContextOptions<GabrielC_EquiposLigaProContext> options)
            : base(options)
        {
        }

        public DbSet<GabrielC_EquiposLigaPro.Models.Jugador> Jugador { get; set; } = default!;
        public DbSet<GabrielC_EquiposLigaPro.Models.Equipo> Equipo { get; set; } = default!;
        public DbSet<GabrielC_EquiposLigaPro.Models.Estadio> Estadio { get; set; } = default!;
    }
}
