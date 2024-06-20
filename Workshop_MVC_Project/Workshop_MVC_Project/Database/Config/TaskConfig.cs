using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Workshop_MVC_Project.Models;

namespace Workshop_MVC_Project.Database.Config
{
    public class TaskConfig : IEntityTypeConfiguration<TaskModel>
    {
        public void Configure(EntityTypeBuilder<TaskModel> modelBuilder)
        {
            modelBuilder.ToTable("Task");

            modelBuilder.HasKey(x => x.Id);

            modelBuilder.Property(x => x.Title)
                .HasColumnType("varchar")
                .HasMaxLength(50)
                .IsRequired();

            modelBuilder.Property(x => x.Description)
                .HasColumnType("text")
                .IsRequired();

            modelBuilder.Property(x => x.IsCompleted)
                .HasColumnType("tinyint")
                .IsRequired();

            modelBuilder.Property(x => x.DueDate)
                .HasColumnType("date")
                .HasMaxLength(255)
                .IsRequired();
        }
    }
}

