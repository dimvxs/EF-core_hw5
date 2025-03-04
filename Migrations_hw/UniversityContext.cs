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
        public DbSet<Heads> Heads { get; set; }
        public DbSet<Assistants> Assistants { get; set; }
        public DbSet<Deans> Deans { get; set; }
        public DbSet<Shedules> Shedules { get; set; }
        public DbSet<LectureRoom> LectureRooms { get; set; }


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

            modelBuilder.Entity<Deans>()
                .HasOne(t => t.Teacher)
                .WithOne(d => d.Deans)
                .HasForeignKey<Deans>(t => t.TeacherId)
                .OnDelete(DeleteBehavior.Cascade);

            // ✅ Один LectureRoom содержит много Schedule
            modelBuilder.Entity<Shedules>()
                .HasOne(s => s.LectureRoom)
                .WithMany(lr => lr.Shedules)
                .HasForeignKey(s => s.LectureRoomId)
                .OnDelete(DeleteBehavior.Restrict); // Запрещаем удаление, если есть связанные расписания
        

        // Один-ко-многим: Teacher ↔ Assistants
        modelBuilder.Entity<Assistants>()
                .HasOne(a => a.Teacher)
                .WithMany(t => t.Assistants)
                .HasForeignKey(a => a.TeachersId)
                .OnDelete(DeleteBehavior.Cascade);

            //  Один LectureRoom содержит много Schedule
            modelBuilder.Entity<Shedules>()
                .HasOne(s => s.LectureRoom)
                .WithMany(lr => lr.Shedules)
                .HasForeignKey(s => s.LectureRoomId)
                .OnDelete(DeleteBehavior.Restrict); // Запрещаем удаление, если есть связанные расписания
        }


    }




    }

