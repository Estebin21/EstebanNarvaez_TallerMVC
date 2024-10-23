using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EstebanNarvaez_TallerMVC.Models;

    public class LigaProContext : DbContext
    {
        public LigaProContext (DbContextOptions<LigaProContext> options)
            : base(options)
        {
        }

        public DbSet<EstebanNarvaez_TallerMVC.Models.Jugador> Jugador { get; set; } = default!;

public DbSet<EstebanNarvaez_TallerMVC.Models.Equipo> Equipo { get; set; } = default!;

public DbSet<EstebanNarvaez_TallerMVC.Models.Estadio> Estadio { get; set; } = default!;
    }
