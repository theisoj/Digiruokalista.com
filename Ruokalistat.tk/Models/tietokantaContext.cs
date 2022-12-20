using System;
using Digiruokalista.com.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Logging;

#nullable disable

namespace Ruokalistat.tk.Models
{
    public partial class tietokantaContext : IdentityDbContext
    {
        private readonly ILogger _logger;
        public tietokantaContext()
        {
            
        }

        public tietokantaContext(DbContextOptions<tietokantaContext> options,ILogger<tietokantaContext> logger)
            : base(options)
        {

            _logger = logger;
        }

        public virtual DbSet<Yritys> Yritys { get; set; }
        public virtual DbSet<Hintahistoria> Hintahistoria { get; set; }
        public virtual DbSet<Ruokalista> Ruokalista {get;set;}
        public virtual DbSet<Ruoka> Ruoka {get;set;}
        public virtual DbSet<Kategoria> Kategoria {get;set;}
        public virtual DbSet<Arvostelu> Arvostelu {get;set;}
        public virtual DbSet<RuokaTykkays> RuokaTykkaykset { get; set; }
        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
