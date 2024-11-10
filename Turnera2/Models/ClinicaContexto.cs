using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Turnera2.Models;

namespace Turnera2.Models
{
    public class ClinicaContexto : DbContext
    {
        public ClinicaContexto(DbContextOptions<ClinicaContexto> options) : base(options) 
        { 
        }

        public DbSet<Medico> Medicos { get; set; }
        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<Ticket> Tickets { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-HPE7L6H\SQLEXPRESS;Database=CLINICA;Trusted_Connection=True;TrustServerCertificate=True;");
        }
        

    }
}
