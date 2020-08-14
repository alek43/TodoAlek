using Microsoft.EntityFrameworkCore;


namespace TodoAlek.Models
{
    public partial class TodosContext:DbContext
    {
        public  TodosContext(DbContextOptions<TodosContext> options): 
            base(options)
        {
        }

        public DbSet<Todos> Todos { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Todos>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__Products__B40CC6CDFEF2D15E");

                entity.Property(e => e.TimeExpire).HasColumnType("dattime");

                entity.Property(e => e.TitleJob).HasColumnType("varchar(max)");


                entity.Property(e => e.DescriptionJob).HasColumnType("varchar(max)");
                    
                entity.Property(e => e.IsComplete).HasColumnType("tinyint"); 

                entity.Property(e => e.PercentageComplete).HasColumnType("int");
            });

           

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
