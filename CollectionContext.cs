using Microsoft.EntityFrameworkCore;
using BOL;
namespace DAL;

public class CollectionContext:DbContext{

public DbSet<Employee> employees {get;set;}

protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        string conString=@"server=localhost;port=3306;user=root; password=Sakshi@2022;database=e_learning";       
        optionsBuilder.UseMySQL(conString);

    }

protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Employee>(entity => 
            {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Name).IsRequired();
            entity.Property(e => e.Email).IsRequired();
            entity.Property(e => e.Address).IsRequired();
            entity.Property(e => e.Password).IsRequired();
            entity.Property(e => e.Deptid).IsRequired();
            entity.Property(e => e.Managerid).IsRequired();
            });
            modelBuilder.Entity<Employee>().ToTable("employee");

        }
}