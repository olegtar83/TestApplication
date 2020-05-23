using Microsoft.EntityFrameworkCore;
using TestDAL.ComplexTypes;
using TestDAL.Seed;

namespace TestDAL.Models
{
    public partial class JTITestContext : DbContext
    {
        public JTITestContext()
        {
        }

        public JTITestContext(DbContextOptions<JTITestContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Departments> Departments { get; set; }
        public virtual DbSet<Employees> Employees { get; set; }
        public virtual DbSet<Visits> Visits { get; set; }

        public virtual DbQuery<GetMostActiveEmployeesResult> GetMostActiveEmployeesResults { get; set; }

        public virtual DbQuery<GetMostVisitedDepartmentsResult> GetMostVisitedDepartmentsResults { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Initial Catalog=JTITestDB;Integrated Security=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GetMostVisitedDepartmentsResult>().HasNoKey();
            modelBuilder.Entity<GetMostActiveEmployeesResult>().HasNoKey();
            modelBuilder.Entity<Departments>(entity =>
            {
                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<Employees>(entity =>
            {
                entity.Property(e => e.FirstName).HasMaxLength(50);

                entity.Property(e => e.LastName).HasMaxLength(50);
            });

            modelBuilder.Entity<Visits>(entity =>
            {
                entity.HasOne(d => d.Department)
                    .WithMany(p => p.Visits)
                    .HasForeignKey(d => d.DepartmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Visits_Departments");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.Visits)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Visits_Employees");
            });
            modelBuilder.Seed();
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}