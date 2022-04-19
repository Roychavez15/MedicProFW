using MedicProFW.Win.Data.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicProFW.Win.Data
{
    public class DataContext : DbContext
    {
        public DataContext() : base("name=con")
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<Dependencia> Dependencias { get; set; }
        public DbSet<Diagnostico> Diagnosticos { get; set; }
        public DbSet<Enfermedad> Enfermedades { get; set; }
        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<Seguro> Seguros { get; set; }
        public DbSet<Servicio> Servicios { get; set; }
        public DbSet<Habitacion> Habitaciones { get; set; }
        public DbSet<Planilla> Planillas { get; set; }
        public DbSet<Tarifario> Tarifarios { get; set; }
        public DbSet<PlanillaDetail> PlanillaDetails { get; set; }
        public DbSet<EstadoPlanilla> EstadoPlanillas { get; set; }
        public DbSet<Medico> Medicos { get; set; }
    }

}
