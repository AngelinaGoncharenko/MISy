using DbClasses.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbClasses
{
    public class MISDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=ANGELINA;Database=ProMIS;Trusted_Connection=True;Encrypt=False;");

        }

        public DbSet<PatientEntities> Patient {get; set;}
        public DbSet<AccountEntities> Account {get; set;}
        public DbSet<AppointmentEntities> Appointment { get; set;}
        public DbSet<ConditionsHospEntities> Conditions { get; set;}
        public DbSet<DepartmentEntities> Department { get; set;}
        public DbSet<DiagnosisEntities> Diagnosis { get; set;}
        public DbSet<DoctorEntities> Doctor { get; set;}
        public DbSet<GenderEntities> Gender { get; set;}
        public DbSet<GovEntities> Gov { get; set;}  
        public DbSet<HospitalizationEntities> Hospitalization { get; set;}  
        public DbSet<LDEntities> lDEntities { get; set;}
        public DbSet<MedCardEntities> MedCard { get; set;}
        public DbSet<MedHistoryEntities> MedHistory { get; set;}
        public DbSet<ProfEntities> Professionaly { get; set;} 
        public DbSet<ReceptEntities> Recept { get; set;}
        public DbSet<SolutionHospEntities> SolutionHosp { get; set;}
        public DbSet<TypeEventEntities> TypeEvent { get; set;}
}
}
