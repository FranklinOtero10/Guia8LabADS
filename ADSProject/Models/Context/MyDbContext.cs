using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ADSProject.Models.Context
{
    public class MyDbContext: DbContext
    {
        public MyDbContext(): base("DefaultConnection") {}

        public DbSet<Carrera> Carrera { get; set; }
        public DbSet<Estudiante> Estudiante { get; set; }
        public DbSet<Grupo> Grupo { get; set; }
        public DbSet<Materia> Materia { get; set; }
        public DbSet<Profesor> Profesor { get; set; }
    }
}