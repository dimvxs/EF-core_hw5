using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Migrations_hw
{
    public class UniversityContext: DbContext
    {
        public DbSet<Teachers> Teachers { get; set; }
        public DbSet<Subjects> Subjects { get; set; }
        public DbSet<Faculties> Faculties { get; set; }
        public DbSet<Curators> Curators { get; set; }
        public DbSet<Groups> Groups { get; set; }
        public DbSet<Lectures> Lectures { get; set; }
        public DbSet<GroupsLectures> GroupsLectures { get; set; }
        public DbSet<Departments> Departments { get; set; }
        public DbSet<GroupsCurators> GroupsCurators { get; set; }


        static DbContextOptions<UniversityContext> _options;

        static UniversityContext()
        {
            var builder = new ConfigurationBuilder();
            builder.SetBasePath(Directory.GetCurrentDirectory());
            builder.AddJsonFile("appsettings.json");
            var config = builder.Build();
            string connectionString = config.GetConnectionString("DefaultConnection");

            var optionsBuilder = new DbContextOptionsBuilder<UniversityContext>();
            _options = optionsBuilder.UseSqlServer(connectionString).Options;
        }

        public UniversityContext()
           : base(_options)
        {

        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Faculty - Department
            modelBuilder.Entity<Departments>()
                .HasOne(d => d.Faculty)
                .WithMany(f => f.Departments)
                .HasForeignKey(d => d.FacultyId);

            // Department - Group
            modelBuilder.Entity<Groups>()
                .HasOne(g => g.Department)
                .WithMany(d => d.Groups)
                .HasForeignKey(g => g.DepartmentId);

            // Subject - Lecture
            modelBuilder.Entity<Lectures>()
                .HasOne(l => l.Subjects)
                .WithMany()
                .HasForeignKey(l => l.SubjectId);

            // Teacher - Lecture
            modelBuilder.Entity<Lectures>()
                .HasOne(l => l.Teachers)
                .WithMany(t => t.Lectures)
                .HasForeignKey(l => l.TeacherId);

            // GroupsLectures (многие ко многим)
            modelBuilder.Entity<GroupsLectures>()
                .HasOne(gl => gl.Group)
                .WithMany(g => g.GroupsLectures)
                .HasForeignKey(gl => gl.GroupId);

            modelBuilder.Entity<GroupsLectures>()
                .HasOne(gl => gl.Lectures)
                .WithMany(l => l.GroupsLectures)
                .HasForeignKey(gl => gl.LectureId);

            // GroupsCurators (многие ко многим)
            modelBuilder.Entity<GroupsCurators>()
                .HasOne(gc => gc.Group)
                .WithMany(g => g.GroupsCurators)
                .HasForeignKey(gc => gc.GroupId);

            modelBuilder.Entity<GroupsCurators>()
                .HasOne(gc => gc.Curator)
                .WithMany(c => c.GroupsCurators)
                .HasForeignKey(gc => gc.CuratorId);
        }




    }
}

