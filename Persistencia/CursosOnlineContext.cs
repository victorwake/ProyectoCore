// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;

using Dominio;
using Microsoft.EntityFrameworkCore;

namespace Persistencia
{
    public class CursosOnlineContext : DbContext
    {
        public CursosOnlineContext(DbContextOptions options) : base(options){

        }


        protected override void OnModelCreating(ModelBuilder modelBuilder){
            modelBuilder.Entity<CursoInstructor>().HasKey(ci => new {ci.InstructorId, ci.CursoId}); 
        }

        public DbSet<Comentario> Comentario {get;set;}
        public DbSet<Curso> Cursos {get;set;}
        public DbSet<CursoIstructor> CursoIstructors {get;set;}
        public DbSet<Instructor> Instructors {get;set;}
        
    }
}