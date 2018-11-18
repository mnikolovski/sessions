using Microsoft.EntityFrameworkCore;
using WebApplication.Security.DataRepository.Models;

namespace WebApplication.Security.DataRepository.Context
{
    public partial class LobsterContext : DbContext
    {
        public LobsterContext()
        {
        }

        public LobsterContext(DbContextOptions<LobsterContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Invoice> Invoice { get; set; }

	    public virtual DbSet<User> User { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source={SERVER_IP};Initial Catalog={DB};User ID={USER};Password={PASS};Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Invoice>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasName("IX_Invoice")
                    .IsUnique();

                entity.HasIndex(e => new { e.UserId, e.Number })
                    .HasName("UQ_Invoice_Number")
                    .IsUnique();

                entity.Property(e => e.CreatedOn).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Duedate).HasColumnType("date");

                entity.Property(e => e.IssuedOn).HasColumnType("date");

                entity.Property(e => e.Number)
                    .IsRequired()
                    .HasMaxLength(400);

                entity.Property(e => e.TotalAmount).HasColumnType("decimal(18, 4)");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Invoice)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Invoice_User");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasIndex(e => e.Email)
                    .HasName("UQ_Email")
                    .IsUnique();

                entity.Property(e => e.CreatedOn).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(320);

                entity.Property(e => e.Name).HasMaxLength(500);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PasswordSalt)
                    .IsRequired()
                    .HasMaxLength(32);

                entity.Property(e => e.Type).HasDefaultValueSql("((1))");

                entity.Property(e => e.Username).IsRequired();
            });
        }
    }
}
