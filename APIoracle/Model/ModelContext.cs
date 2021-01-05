using Microsoft.EntityFrameworkCore;

namespace APIoracle.Models
{
    public partial class ModelContext : DbContext
    {
        public ModelContext()
        {
        }

        public ModelContext(DbContextOptions<ModelContext> options)
            : base(options)
        {
        }


        public virtual DbSet<AttEmployees> AttEmployees { get; set; }




        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:DefaultSchema", "Schema");


            modelBuilder.Entity<AttEmployees>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ATT_EMPLOYEES");

                entity.Property(e => e.BirthDate)
                    .HasColumnName("BIRTH_DATE")
                    .HasColumnType("DATE");

                entity.Property(e => e.BranchCode)
                    .HasColumnName("BRANCH_CODE")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.DepartmentCode)
                    .HasColumnName("DEPARTMENT_CODE")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasColumnName("EMAIL")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeCode)
                    .IsRequired()
                    .HasColumnName("EMPLOYEE_CODE")
                    .HasMaxLength(10)
                    .IsUnicode(false);



                entity.Property(e => e.EmployeeName)
                    .HasColumnName("EMPLOYEE_NAME")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeNo)
                    .HasColumnName("EMPLOYEE_NO")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeType)
                    .HasColumnName("EMPLOYEE_TYPE")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.GradeCode)
                    .HasColumnName("GRADE_CODE")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.GradeName)
                    .IsRequired()
                    .HasColumnName("GRADE_NAME")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.JionDate)
                    .HasColumnName("JION_DATE")
                    .HasColumnType("DATE");

                entity.Property(e => e.MobileNo)
                    .HasColumnName("MOBILE_NO")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NationaltiyCode)
                    .HasColumnName("NATIONALTIY_CODE")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.NationaltiyName)
                    .HasColumnName("NATIONALTIY_NAME")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PositionCode)
                    .HasColumnName("POSITION_CODE")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.SectionCode)
                    .HasColumnName("SECTION_CODE")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.SupervisorCode)
                    .HasColumnName("SUPERVISOR_CODE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UnitCode)
                    .HasColumnName("UNIT_CODE")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.WorkStatus)
                    .HasColumnName("WORK_STATUS")
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });



            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
